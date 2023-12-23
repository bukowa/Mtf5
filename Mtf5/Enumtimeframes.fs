namespace Mtf5

module Predefined =
    let hello (name: string) =
        "hello"
    
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
        | ERROR  = 254uy
        | NOTSET = 255uy
    

    let mutable _PERIOD = ENUM_TIMEFRAMES.NOTSET

    let _PERIOD_get (_: unit): uint8 =
        match _PERIOD with
        | ENUM_TIMEFRAMES.PERIOD_M1 -> 0uy
        | ENUM_TIMEFRAMES.PERIOD_M2 -> 1uy
        | ENUM_TIMEFRAMES.PERIOD_M3 -> 2uy
        | ENUM_TIMEFRAMES.PERIOD_M4 -> 3uy
        | ENUM_TIMEFRAMES.PERIOD_M5 -> 4uy
        | ENUM_TIMEFRAMES.PERIOD_M6 -> 5uy
        | ENUM_TIMEFRAMES.PERIOD_M10 -> 6uy
        | ENUM_TIMEFRAMES.PERIOD_M12 -> 7uy
        | ENUM_TIMEFRAMES.PERIOD_M15 -> 8uy
        | ENUM_TIMEFRAMES.PERIOD_M20 -> 9uy
        | ENUM_TIMEFRAMES.PERIOD_M30 -> 10uy
        | ENUM_TIMEFRAMES.PERIOD_H1 -> 11uy
        | ENUM_TIMEFRAMES.PERIOD_H2 -> 12uy
        | ENUM_TIMEFRAMES.PERIOD_H3 -> 13uy
        | ENUM_TIMEFRAMES.PERIOD_H4 -> 14uy
        | ENUM_TIMEFRAMES.PERIOD_H6 -> 15uy
        | ENUM_TIMEFRAMES.PERIOD_H8 -> 16uy
        | ENUM_TIMEFRAMES.PERIOD_H12 -> 17uy
        | ENUM_TIMEFRAMES.PERIOD_D1 -> 18uy
        | ENUM_TIMEFRAMES.PERIOD_W1 -> 19uy
        | ENUM_TIMEFRAMES.PERIOD_MN1 -> 20uy
        | ENUM_TIMEFRAMES.NOTSET -> 255uy
        | ENUM_TIMEFRAMES.ERROR -> 254uy
        | _ -> 254uy

    let _PERIOD_set (period: uint8) =
        _PERIOD <-
                match period with
                | 0uy -> ENUM_TIMEFRAMES.PERIOD_M1
                | 1uy -> ENUM_TIMEFRAMES.PERIOD_M2
                | 2uy -> ENUM_TIMEFRAMES.PERIOD_M3
                | 3uy -> ENUM_TIMEFRAMES.PERIOD_M4
                | 4uy -> ENUM_TIMEFRAMES.PERIOD_M5
                | 5uy -> ENUM_TIMEFRAMES.PERIOD_M6
                | 6uy -> ENUM_TIMEFRAMES.PERIOD_M10
                | 7uy -> ENUM_TIMEFRAMES.PERIOD_M12
                | 8uy -> ENUM_TIMEFRAMES.PERIOD_M15
                | 9uy -> ENUM_TIMEFRAMES.PERIOD_M20
                | 10uy -> ENUM_TIMEFRAMES.PERIOD_M30
                | 11uy -> ENUM_TIMEFRAMES.PERIOD_H1
                | 12uy -> ENUM_TIMEFRAMES.PERIOD_H2
                | 13uy -> ENUM_TIMEFRAMES.PERIOD_H3
                | 14uy -> ENUM_TIMEFRAMES.PERIOD_H4
                | 15uy -> ENUM_TIMEFRAMES.PERIOD_H6
                | 16uy -> ENUM_TIMEFRAMES.PERIOD_H8
                | 17uy -> ENUM_TIMEFRAMES.PERIOD_H12
                | 18uy -> ENUM_TIMEFRAMES.PERIOD_D1
                | 19uy -> ENUM_TIMEFRAMES.PERIOD_W1
                | 20uy -> ENUM_TIMEFRAMES.PERIOD_MN1
                | 255uy -> ENUM_TIMEFRAMES.NOTSET
                | _ -> ENUM_TIMEFRAMES.ERROR
