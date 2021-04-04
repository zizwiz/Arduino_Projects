/* 
 * Setting the time in the Real Time Clock Module
   using DS3231 Library made by Henning Karlsen which can be found and downloaded from his website, www.rinkydinkelectronics.com.
*/

#include <DS3231.h>
#include <LiquidCrystal.h> // includes the LiquidCrystal Library 

String DataString = ""; // a String to hold incoming data
bool Complete = false;  // whether the string is complete

DS3231  rtc(SDA, SCL);
LiquidCrystal lcd(12, 11, 6, 5, 4, 3); //Define LCD display pins RS,E,D4,D5,D6,D7

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
    rtc.setTime(DataString.substring(0,2).toInt(), DataString.substring(2,4).toInt(),DataString.substring(4,6).toInt());    // Set the time e.g. 19:38:00 (24hr format)
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
    rtc.setTime(DataString.substring(0,2).toInt(), DataString.substring(2,4).toInt(),DataString.substring(4,6).toInt());    // Set the time e.g. 19:38:00 (24hr format)
    rtc.setDate(DataString.substring(6,8).toInt(), DataString.substring(8,10).toInt(),DataString.substring(10,14).toInt());    // Set the date DD.MM.YYYY e.g. 04.02.2020        
    clearLCDLine(2); // clear DOW line as they are not all same length
    rtc.setDOW(DataString.substring(14,15).toInt());         // Set Day-of-Week by number where SUNDAY = 7
    
    // clear the string and drop flag
    DataString = "";
    Complete = false;

    //send ACK to PC, you can add more checks here like read the data back to PC as well.
    Serial.write(char(0x06));
  }
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
