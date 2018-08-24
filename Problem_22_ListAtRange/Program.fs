// Learn more about F# at http://fsharp.org

open System

let rec range beg fin = 
    match (beg, fin) with
    | (b, f) when b = f -> [f]
    | (b, f) -> b :: range (b+1) f

[<EntryPoint>]
let main argv =
    printfn "%A" (range 2 2)
    printfn "%A" (range 2 5)
    printfn "%A" (range 1 2)
    
    Console.ReadKey() |> ignore
    0 // return an integer exit code