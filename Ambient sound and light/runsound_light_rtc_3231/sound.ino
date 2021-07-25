void runsound()
{
  //Sample for 1 minute
  do
  {
    if (digitalRead(OUT_PIN) == LOW) {
      sampleBufferValue++; //If sound then keep incrementing
    }
    counter++;

  } while (counter < 10600000); //this equates to 1 minute


  Serial.println(GetTime() + sampleBufferValue); //write out value of sum of ones.

  DataFile = SD.open(SoundFilename, FILE_WRITE);

  // if the file is available, write to it
  if (DataFile)
  {
    DataFile.println(GetTime() + (String)sampleBufferValue);
    DataFile.close();
  }
  counter = 0;
  sampleBufferValue = 0; //reset to zero
}
