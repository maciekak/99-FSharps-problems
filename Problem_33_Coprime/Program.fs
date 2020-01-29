// Learn more about F# at http://fsharp.org

open System

let rec gcd fst snd =
    match (fst, snd) with
    | (fst, snd) when snd = 0 -> fst
    | (fst, snd) -> gcd snd (fst % snd)
let isCoprime fst snd =
    (gcd fst snd) = 1


let res fst snd = 
    printfn "(%d %d) -> %b" fst snd (isCoprime fst snd)
[<EntryPoint>]
let main argv =
    res 5 15
    res 15 5
    res 140 187
    res 6 49
    res 12 123

    Console.ReadKey() |> ignore
    0 // return an integer exit code
