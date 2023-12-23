namespace Mtf5

module Predefined =
    val hello: string -> string
    type ENUM_TIMEFRAMES =
        | PERIOD_M1 = 0uy
        | PERIOD_M2 = 1uy
        | PERIOD_M3 = 2uy
        | PERIOD_M4 = 3uy
        | PERIOD_M5 = 4uy
        | PERIOD_M6 = 5uy
        | PERIOD_M10 = 6uy
        | PERIOD_M12 = 7uy
        | PERIOD_M15 = 8uy
        | PERIOD_M20 = 9uy
        | PERIOD_M30 = 10uy
        | PERIOD_H1 = 11uy
        | PERIOD_H2 = 12uy
        | PERIOD_H3 = 13uy
        | PERIOD_H4 = 14uy
        | PERIOD_H6 = 15uy
        | PERIOD_H8 = 16uy
        | PERIOD_H12 = 17uy
        | PERIOD_D1 = 18uy
        | PERIOD_W1 = 19uy
        | PERIOD_MN1 = 20uy
        | NOTSET = 255uy
        
    val mutable _PERIOD: ENUM_TIMEFRAMES
    val _PERIOD_set: uint8 -> unit
    val _PERIOD_get: unit -> uint8
