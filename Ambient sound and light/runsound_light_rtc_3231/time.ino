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
