//+------------------------------------------------------------------+
//|                                                         Mtf5.mqh |
//|                                       Mateusz Kurowski 2023-2024 |
//|                                        https://github.com/bukowa |
//+------------------------------------------------------------------+
#property copyright "Mateusz Kurowski 2023-2024"
#property link      "https://github.com/bukowa"
//+------------------------------------------------------------------+
//| defines                                                          |
//+------------------------------------------------------------------+
// #define MacrosHello   "Hello, world!"
// #define MacrosYear    2010
//+------------------------------------------------------------------+
//| DLL imports                                                      |
//+------------------------------------------------------------------+
// #import "user32.dll"
//   int      SendMessageA(int hWnd,int Msg,int wParam,int lParam);
// #import "my_expert.dll"
//   int      ExpertRecalculate(int wParam,int lParam);
// #import
#import "Mtf5/Mtf5.dll"
//+------------------------------------------------------------------+
//| EX5 imports                                                      |
//+------------------------------------------------------------------+
// #import "stdlib.ex5"
//   string ErrorDescription(int error_code);
// #import
//+------------------------------------------------------------------+
ENUM_TIMEFRAMES OUT_ENUM_TIMEFRAMES(uchar i)
{
  switch(i)
  {
  case 0:
    return(PERIOD_M1);
  case 1:
    return(PERIOD_M2);
  case 2:
    return(PERIOD_M3);
  case 3:
    return(PERIOD_M4);
  case 4:
    return(PERIOD_M5);
  case 5:
    return(PERIOD_M6);
  case 6:
    return(PERIOD_M10);
  case 7:
    return(PERIOD_M12);
  case 8:
    return(PERIOD_M15);
  case 9:
    return(PERIOD_M20);
  case 10:
    return(PERIOD_M30);
  case 11:
    return(PERIOD_H1);
  case 12:
    return(PERIOD_H2);
  case 13:
    return(PERIOD_H3);
  case 14:
    return(PERIOD_H4);
  case 15:
    return(PERIOD_H6);
  case 16:
    return(PERIOD_H8);
  case 17:
    return(PERIOD_H12);
  case 18:
    return(PERIOD_D1);
  case 19:
    return(PERIOD_W1);
  case 20:
    return(PERIOD_MN1);
  }
  return(-1);
}
//+------------------------------------------------------------------+
//+------------------------------------------------------------------+
//|                                                                  |
//+------------------------------------------------------------------+
uchar IN_ENUM_TIMEFRAMES(ENUM_TIMEFRAMES period)
{
  switch(period)
  {
  case PERIOD_M1:
    return 0;
  case PERIOD_M2:
    return 1;
  case PERIOD_M3:
    return 2;
  case PERIOD_M4:
    return 3;
  case PERIOD_M5:
    return 4;
  case PERIOD_M6:
    return 5;
  case PERIOD_M10:
    return 6;
  case PERIOD_M12:
    return 7;
  case PERIOD_M15:
    return 8;
  case PERIOD_M20:
    return 9;
  case PERIOD_M30:
    return 10;
  case PERIOD_H1:
    return 11;
  case PERIOD_H2:
    return 12;
  case PERIOD_H3:
    return 13;
  case PERIOD_H4:
    return 14;
  case PERIOD_H6:
    return 15;
  case PERIOD_H8:
    return 16;
  case PERIOD_H12:
    return 17;
  case PERIOD_D1:
    return 18;
  case PERIOD_W1:
    return 19;
  case PERIOD_MN1:
    return 20;
  }
  return 255;
}

void MTF5__PERIOD_SET(ENUM_TIMEFRAMES period) {
  Predefined::_PERIOD_set(IN_ENUM_TIMEFRAMES(period));
}

ENUM_TIMEFRAMES MTF5__PERIOD_GET() {
  return OUT_ENUM_TIMEFRAMES(Predefined::_PERIOD_get());
}
