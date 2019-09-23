// Learn more about F# at http://fsharp.org

open System
open FParsec

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    // Use something random
    eprintfn "%A" digit
    0 // return an integer exit code
