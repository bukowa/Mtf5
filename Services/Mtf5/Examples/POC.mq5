//+------------------------------------------------------------------+
//|                                                          POC.mq5 |
//|                                       Mateusz Kurowski 2023-2024 |
//|                                        https://github.com/bukowa |
//+------------------------------------------------------------------+
#property service
#property copyright "Mateusz Kurowski 2023-2024"
#property link      "https://github.com/bukowa"
#property version   "1.00"
#include <Mtf5.mqh>

//+------------------------------------------------------------------+
//| Service program start function                                   |
//+------------------------------------------------------------------+
void OnStart()
  {
//---
  printf("starting1");
  while(!IsStopped())
  {
    printf(MTF5__PERIOD_GET());
    MTF5__PERIOD_SET(PERIOD_M15); 
    printf(MTF5__PERIOD_GET());
    Sleep(1000);
  }
}
//+------------------------------------------------------------------+
