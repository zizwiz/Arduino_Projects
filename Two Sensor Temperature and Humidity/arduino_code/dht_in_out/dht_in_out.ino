#include <DHT.h>
#include <LiquidCrystal_I2C.h>
#include <Wire.h>
#include <Adafruit_Sensor.h>
//#include <Adafruit_BME280.h>
#include <Adafruit_BMP280.h>

#define DHTPIN1 3 //define the pins we will use to get the data from.

LiquidCrystal_I2C lcd(0x27, 20, 4); // set the LCD address to 0x27 for a 20 chars and 4 line display

//create an array to put the read data into
#define DHTTYPE DHT22   // DHT 22  (AM2302)
DHT dht(DHTPIN1, DHTTYPE); //// Initialize DHT sensor for normal 16mhz Arduino

//Adafruit_BME280 bme;
Adafruit_BMP280 bme;

float humidity[2];
float temperature[2];
float pressure[1];
float smiley[20] = {0};
float PreviousValue = 0;

int graph[20];
int block_size = 0;
int pressureNow;

char SerialInput = '0';

String output = "";

// We need this so Arduino will actually count a minute.
unsigned long counter = -1;
unsigned long count = 0;

unsigned long seconds = 1000L; //Notice the L 
unsigned long minute = seconds * 60;
unsigned long iterations = 59L;


//Define Custom Characters


byte happy[] =
{
  B11011,
  B11011,
  B00100,
  B00100,
  B10001,
  B10001,
  B01110,
  B00000
};

byte level[] =
{
  B11011,
  B11011,
  B00100,
  B00100,
  B01110,
  B10001,
  B01110,
  B00000
};

byte sad[] =
{
  B11011,
  B11011,
  B00100,
  B00100,
  B01110,
  B10001,
  B10001,
  B00000
};

byte empty[] =
{
  B00000,
  B00000,
  B00000,
  B00000,
  B00000,
  B00000,
  B00000,
  B00000
};

byte up[] =
{
  B11111,
  B11111,
  B00000,
  B00000,
  B00000,
  B00000,
  B00000,
  B00000
};

byte even[] =
{
  B00000,
  B00000,
  B00000,
  B11111,
  B11111,
  B00000,
  B00000,
  B00000
};

byte down[] =
{
  B00000,
  B00000,
  B00000,
  B00000,
  B00000,
  B00000,
  B11111,
  B11111
};

void setup()
{
  lcd.init();  // initialise the class
  lcd.backlight(); //switch on the backlight

  Serial.begin(9600);  //open the RS232 port at 9600 baud
  dht.begin();
  
  if (!bme.begin(0x76)) {
    Serial.println("Could not find a valid BME280 sensor, check wiring!");
    while (1);
  }

  //Write the non-changing data
  lcd.setCursor(0, 0);
  lcd.print("I");
  lcd.setCursor(0, 1);
  lcd.print("O");
  lcd.setCursor(0, 2);
  lcd.print("O");

  // create custom chars
  lcd.createChar(0, empty);
  lcd.createChar(1, up);
  lcd.createChar(2, even);
  lcd.createChar(3, down);
  lcd.createChar(4, happy);
  lcd.createChar(5, level);
  lcd.createChar(6, sad);

  memset(graph, 0, sizeof(graph)); //fill with 0
  memset(smiley, 0, sizeof(smiley)); //fill with 0
}

void loop()
{

  output = "";
  //Read the inside sensor data
  temperature[0] = dht.readTemperature(); // Gets the values of the temperature
  humidity[0] = dht.readHumidity(); // Gets the values of the humidity

  //   Read the outside sensor data
  temperature[1] = bme.readTemperature();
//  humidity[1] = bme.readHumidity();
  pressure[0] = bme.readPressure() / 100.0F;

  //Line 0 = inside
  lcd.setCursor(1, 0);
  lcd.print(" ");
  lcd.print(temperature[0]);
  lcd.print((char)223);
  lcd.print("C ");
  lcd.setCursor(13, 0);
  lcd.print(humidity[0]);
  lcd.print("%");

  // construct the data to send out the RS232 if required
  output += String(temperature[0]) + "," + String(humidity[0]) + ",";

  //line 2 and 3 = outside
  lcd.setCursor(1, 1);
  lcd.print(" ");
  lcd.print(temperature[1]);
  lcd.print((char)223);
  lcd.print("C ");
  lcd.setCursor(13, 1);
  lcd.print(humidity[1]);
  lcd.print("%");

  lcd.setCursor(1, 2);
  lcd.print(" ");
  lcd.print(pressure[0]);
  lcd.print("mb  ");
  lcd.setCursor(11, 2);

  counter ++;

  //lcd.print(pressure[1]);


//  pressureNow = pressure[0];
//
//lcd.print(pressureNow);
//lcd.print(PreviousValue);
//
//if (PreviousValue > 0)
//{
//  if ( pressureNow > PreviousValue) {
//    block_size = 1;
//  }
//  else if (pressureNow == PreviousValue) {
//    block_size = 2;
//  }
//  else if (pressureNow < PreviousValue) {
//    block_size = 3;
//  }
//}
//  PreviousValue = pressureNow;


  // construct the data to send out the RS232 if required
  output += String(temperature[1]) + "," + String(humidity[1]) + "," + String(pressure[0]) + ",";

  if ((counter > iterations) || (counter == 0)) // draw graph every hour 
  {
    DrawGraph();
    counter = 0;
  }

  if (Serial)
  {
    SerialInput = Serial.read();
    if (SerialInput == '1')
    {
      Serial.println(output); //send output to the App
    }
    SerialInput = '0';
  }


  delay(minute); // delay = 1 minute as unsigned Long
}


void DrawGraph()
{
  int line = 0;
  int value = 0;
  int pNow = 0;
  int latestP = 0;


  pressureNow = pressure[0];
  
  if (PreviousValue > 0)
  {
    if ( pressureNow > PreviousValue) {
      block_size = 1;
    }
    else if (pressureNow == PreviousValue) {
      block_size = 2;
    }
    else if (pressureNow < PreviousValue) {
      block_size = 3;
    }
  }
    PreviousValue = pressureNow;

  for (int i = 1; i < 20; i++)
  {
    pNow = smiley[i];
    lcd.setCursor(line, 3);
    line = line + 1;
    value = graph[i];
    lcd.write(byte(value));
    graph[i - 1] = graph[i];
    smiley[i - 1] = pNow;
  }
  latestP = pressure[0];
  smiley[19] = latestP;
  graph[19] = block_size;
  lcd.write(byte(block_size));

  lcd.setCursor(13, 2);
  //lcd.print("       ");

  if (graph[0] != 0)
  {
    lcd.setCursor(13, 2);
    if (smiley[0] > smiley[19]) {
      lcd.write(6);
    }
    else if (smiley[0] = smiley[19]) {
      lcd.write(5);
    }
    else if (smiley[0] < smiley[19]) {
      lcd.write(4);
    }
  }

  if (graph[9] != 0)
  {
    lcd.setCursor(16, 2);
    if (smiley[9] > smiley[19]) {
      lcd.write(6);
    }
    else if (smiley[9] = smiley[19]) {
      lcd.write(5);
    }
    else if (smiley[9] < smiley[19]) {
      lcd.write(4);
    }
  }

  if (graph[18] != 0)
  {
    lcd.setCursor(19, 2);
    if (smiley[18] > smiley[19]) {
      lcd.write(6);
    }
    else if (smiley[18] = smiley[19]) {
      lcd.write(5);
    }
    else if (smiley[18] < smiley[19]) {
      lcd.write(4);
    }
  }

}
