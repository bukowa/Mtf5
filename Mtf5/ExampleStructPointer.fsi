namespace Mtf5

[<Struct>]
type ExampleStruct =
    val mutable Data: int


module Mtf5Trade =
    val ModifyPointer: ExampleStruct byref -> unit
