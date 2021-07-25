#include <SD.h>
#include<NoDelay.h>
#include <DS3231.h>

String output = "";
String SoundFilename = "SoundLog.csv";
String LightFilename = "LightLog.csv";

File DataFile;
DS3231  rtc(SDA, SCL);
Time t;

void runsound();//Must declare function before noDelay, function can not take arguments
//noDelay runsoundtime(900000L, runsound);//Creats a noDelay varible set to 15min, will call runsound function
noDelay runsoundtime(720000L, runsound); //12min 

void runlight();//Must declare function before noDelay, function can not take arguments
noDelay runlighttime(720000L, runlight);//12min 

void setup() {
  Serial.begin(9600);
  rtc.begin();

  if (!SD.begin(4)) {
    Serial.println(F("SD initialisation failed"));  // Chip select pin for us is pin 10. Chamge this if you use a different pin.
    while (1);
  }

  // open the file. note that only one file can be open at a time,
  // so you have to close this one before opening another.
  DataFile = SD.open(SoundFilename, FILE_WRITE);

  // if the file is available, write to it:
  if (DataFile) {
    Serial.println(F("SoundFile Made"));
    DataFile.println(F("Date,Time,Sound"));
    DataFile.close();
  }
  // if the file isn't open, pop up an error:
  else {
    Serial.println("error opening SoundLog.csv");
  }

  DataFile = SD.open(LightFilename, FILE_WRITE);

  // if the file is available, write to it:
  if (DataFile) {
    Serial.println(F("LightFile Made"));
    DataFile.println(F("Date,Time,Light"));
    DataFile.close();
  }
  // if the file isn't open, pop up an error:
  else {
    Serial.println("error opening LightLog.csv");
  }

  Serial.println("All set up @ " + GetTime());
}

void loop() {
  runsoundtime.update();//will check if set time has past and if so will run set function
  runlighttime.update();
}
