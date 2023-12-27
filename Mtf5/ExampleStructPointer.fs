namespace Mtf5
open Microsoft.FSharp.Core

[<Struct>]
type ExampleStruct =
    val mutable Data: int

module Mtf5Trade =

    let ModifyPointer (example:ExampleStruct byref) =
        example.Data <- example.Data + 1
