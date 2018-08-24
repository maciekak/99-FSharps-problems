// Learn more about F# at http://fsharp.org

open System

let rec insertAt lst elem pos = 
    match (lst, pos) with
    | ((a :: ax), p) when p = 0 -> elem :: a :: ax
    | ((a :: ax), p) -> a :: insertAt ax elem (p - 1)
    | ([], p) when p = 0 -> [elem]
    | _ -> []

[<EntryPoint>]
let main argv =
    printfn "%A" (insertAt [1; 2; 3;] 5 2)
    printfn "%A" (insertAt [1] 3 1)
    printfn "%A" (insertAt [] 3 0)
    
    Console.ReadKey() |> ignore
    0 // return an integer exit code