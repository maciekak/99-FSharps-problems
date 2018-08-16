// Learn more about F# at http://fsharp.org

open System

let compress lst = 
    let rec compressHelper lt last =
        match (lt, last) with
        | ((a :: ax), last) when last = a -> compressHelper ax a
        | ((a :: ax), _) -> a :: compressHelper ax a
        | ([], _) -> []
    match lst with
    | (b :: bx) -> b :: compressHelper bx b
    | [] -> []
    
[<EntryPoint>]
let main argv =
    printfn "%A" (compress [1; 1; 2; 2; 3; 4; 4; 4; 4])
    printfn "%A" (compress [1])
    printfn "%A" (compress [])
    printfn "%A" (compress [1; 1])
    
    Console.ReadKey() |> ignore
    0 // return an integer exit code