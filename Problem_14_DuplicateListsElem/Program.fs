// Learn more about F# at http://fsharp.org

open System

let rec dupli lst = 
    match lst with
    | (a :: ax) -> a :: a :: dupli ax
    | [] -> []

[<EntryPoint>]
let main argv =
    printfn "%A" (dupli [1; 2; 3;])
    printfn "%A" (dupli [1])
    printfn "%A" (dupli [])
    
    Console.ReadKey() |> ignore
    0 // return an integer exit code