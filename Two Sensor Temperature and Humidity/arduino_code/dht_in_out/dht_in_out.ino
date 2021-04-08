#include <DHT.h>;
#include <LiquidCrystal_I2C.h>

#define DHTPIN1 2 //define the pins we will use to get the data from.
#define DHTPIN2 3

LiquidCrystal_I2C lcd(0x27,16,2);  // set the LCD address to 0x27 for a 16 chars and 2 line display

//create an array to put the read data into
DHT dht[] = {
  {DHTPIN1, DHT22},
  {DHTPIN2, DHT22},
};

float humidity[2];
float temperature[2];

char SerialInput = '0';

void setup()
{
   	lcd.init();  // initialise the class
    lcd.backlight(); //switch on the backlight

  Serial.begin(9600);  //open the RS232 port at 9600 baud
  for (auto& sensor : dht) {
    sensor.begin();
  }

//Write the non-changing data
   lcd.setCursor(0,0);
   lcd.print("I");
   lcd.setCursor(0,1);
   lcd.print("O");
  
}

void loop()
{
     
  
  //Read the sensor data
  for (int i = 0; i < 2; i++) {
    temperature[i] = dht[i].readTemperature();
    humidity[i] = dht[i].readHumidity();
  }

  int line = 0;  
  String output = "";
  
// write the data to the LCD screen
  for (int i = 0; i < 2; i++) {
      
    lcd.setCursor(1,line);
    lcd.print(" ");
    lcd.print(temperature[i]);
    lcd.print((char)223);
    lcd.print("C");
    lcd.setCursor(10,line);
    lcd.print(humidity[i]);
    lcd.print("%");

    // construct the data to send out the RS232 if required
    output += String(temperature[i]) + "," + String(humidity[i]) + ",";
   
    
    line = 1;
    }

    //read from serial port and send to Windows App
    
    if (Serial)
    {
    SerialInput = Serial.read();
    if (SerialInput=='1') 
    {
      Serial.println(output); //send output to the App 
    }
    SerialInput = '0';
    }
    
    
  delay(5000);
}
