/* 
 * Setting the time in the Real Time Clock Module
   using DS3231 Library made by Henning Karlsen which can be found and downloaded from his website, www.rinkydinkelectronics.com.
*/
#include <DS3231.h>
#include <LiquidCrystal_I2C.h> // includes the LiquidCrystal Library 

String DataString = ""; // a String to hold incoming data
bool Complete = false;  // whether the string is complete

Time t;

DS3231  rtc(SDA, SCL);
LiquidCrystal_I2C lcd(0x27, 20, 4);

void setup() {
  // initialize serial:
  Serial.begin(9600);      //run at 9600
  // reserve 21 bytes for the inputString:
  DataString.reserve(21);

  rtc.begin(); // Initialize the rtc object
  lcd.begin(20, 4); // Initializes the interface to the LCD screen, and specifies the dimensions (width and height) of the display }

  lcd.setCursor(0, 0);
  lcd.print("Time: ");
  lcd.setCursor(0, 1);
  lcd.print("Date: ");
  lcd.setCursor(0, 2);
  lcd.print("Day: ");
  lcd.setCursor(0, 3);
  lcd.print("Temp: ");
}

void loop() {
  lcd.setCursor(7, 0);
  lcd.print(rtc.getTimeStr());
  lcd.setCursor(7, 1);
  lcd.print(rtc.getDateStr());
  lcd.setCursor(7, 2);
  lcd.print(rtc.getDOWStr());
  lcd.setCursor(7, 3);
  lcd.print(rtc.getTemp());
  lcd.print(char(0xDF));
  lcd.print("C");
  // Set Clock when complete flag has been set:
  if (Complete)
  {
    // Here we set the clock from the incoming data    
    rtc.setTime((DataString.substring(0,2).toInt())-1, DataString.substring(2,4).toInt(),DataString.substring(4,6).toInt());    // Set the time e.g. 19:38:00 (24hr format)
    rtc.setDate(DataString.substring(6,8).toInt(), DataString.substring(8,10).toInt(),DataString.substring(10,14).toInt());    // Set the date DD.MM.YYYY e.g. 04.02.2020        
    clearLCDLine(2); // clear DOW line as they are not all same length
    rtc.setDOW(DataString.substring(14,15).toInt());         // Set Day-of-Week by number where SUNDAY = 7
    
    // clear the string and drop flag
    DataString = "";
    Complete = false;

    //send ACK to PC, you can add more checks here like read the data back to PC as well.
    Serial.write(char(0x06));
  }
  
  delay(1000);

  // Set Clock when complete flag has been set:
  if (Complete)
  {
    // Here we set the clock from the incoming data    
    rtc.setTime((DataString.substring(0,2).toInt()-1), DataString.substring(2,4).toInt(),DataString.substring(4,6).toInt());    // Set the time e.g. 19:38:00 (24hr format)
    rtc.setDate(DataString.substring(6,8).toInt(), DataString.substring(8,10).toInt(),DataString.substring(10,14).toInt());    // Set the date DD.MM.YYYY e.g. 04.02.2020        
    clearLCDLine(2); // clear DOW line as they are not all same length
    rtc.setDOW(DataString.substring(14,15).toInt());         // Set Day-of-Week by number where SUNDAY = 7
    
    // clear the string and drop flag
    DataString = "";
    Complete = false;

    //send ACK to PC, you can add more checks here like read the data back to PC as well.
    Serial.write(char(0x06));
    
  }

  Serial.println("All set up @ " + GetTime());
}

/*
  SerialEvent occurs whenever new data comes in the hardware serial RX. This
  routine is run between each time loop() runs, so using delay inside loop can
  delay response. Multiple bytes of data may be available. We only send data
  once.
*/
void serialEvent() {
  while (Serial.available()) {
    // get the new byte:
    char inChar = (char)Serial.read();
    // add it to the DataString:
    DataString += inChar;
    // if the incoming character is EOT 0x04, set a flag so the main loop can
    // do something with the data:
    if (inChar == 0x04) {
      Complete = true; //raise flag
    }
  }
}

//clear only lines to be rewritten
void clearLCDLine(int line)
{
  lcd.setCursor(7, line);
  for (int n = 7; n < 20; n++) // 20 indicates 0-20 symbols in line.
  {
    lcd.print(" ");
  }
}

String GetTime()
{
  String MyTime = "";
  String MyTime2 = "";
  String MyDST = "";

  //UK summertime = false = UTC+1, wintertime = true = UTC
  t = rtc.getTime();
  MyTime = (String)rtc.getDateStr(); //as dd.mm.yyyy
  MyTime2 = rtc.getTimeStr(); //winter time UTC time e.g 15:35:29

  bool DST = 1;
  byte yy = t.year % 100;  //get year of century

  byte mm = (MyTime.substring(3, 5)).toInt();
  byte dd = (MyTime.substring(0, 2)).toInt();

  byte x1 = 31 - (yy + yy / 4 - 2) % 7; //last Sunday March
  byte x2 = 31 - (yy + yy / 4 + 2) % 7; // last Sunday October

  if ((mm > 3 && mm < 10) || (mm == 3 && dd >= x1) || (mm == 10 && dd < x2))
  {
    DST = 0;
  }

  if (!DST)
  {
    //If Summer time we add an hour UTC+1
    MyDST  = MyTime2.substring(2);
    MyTime2 = ((MyTime2.substring(0, 2)).toInt()) + 1;

    if (MyTime2.toInt() < 10)
    { // add leading zero
      MyTime2 = "0" + (String)MyTime2;
    }
    else
    {
      MyTime2 = (String)MyTime2;
    }
  }

  return (MyTime + "," + MyTime2 + MyDST + ",");
}
