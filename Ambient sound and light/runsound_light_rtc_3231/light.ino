void runlight ()
{
  double Vout = int(analogRead(0)) * 0.0048828125;
  //int lux=500/(10*((5-Vout)/Vout));//use this equation if the LDR is in the upper part of the divider
  int lux = (2500 / Vout - 500) / 10;

  Serial.println(GetTime() + "L " + (String)lux);

  DataFile = SD.open(LightFilename, FILE_WRITE);

  // if the file is available, write to it
  if (DataFile)
  {
    DataFile.println(GetTime() + (String)lux);
    DataFile.close();
  }
}
