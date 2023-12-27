//+------------------------------------------------------------------+
//|                                                          POC.mq5 |
//|                                       Mateusz Kurowski 2023-2024 |
//|                                        https://github.com/bukowa |
//+------------------------------------------------------------------+
#property service
#property copyright "Mateusz Kurowski 2023-2024"
#property link      "https://github.com/bukowa"
#property version   "1.00"
#import "Mtf5/Mtf5.dll"
//+------------------------------------------------------------------+
//|                                                                  |
//+------------------------------------------------------------------+


//+------------------------------------------------------------------+
//|                                                                  |
//+------------------------------------------------------------------+
void OnStart()
{
  printf("Starting...");
  ExampleStruct example;
  example.Data = 0;
  ExampleStruct example2;
  example.Data = -100;
  while(!IsStopped())
  {
    Check(example);
    Check(example2);
    Sleep(1000);
  }
};

// this function has to be declared below OnStart
void Check(ExampleStruct &e)
{
  printf("before: " + e.Data);
  Mtf5Trade::ModifyPointer(e);
  printf("after: " + e.Data);
};
