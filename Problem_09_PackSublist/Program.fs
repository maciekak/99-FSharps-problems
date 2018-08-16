// Learn more about F# at http://fsharp.org

open System

let pack lst = 
    let rec packHelper lt acc last = 
        match (lt, last) with
        | ((a :: ax), last) when a = last -> packHelper ax (a :: acc) a
        | ((a :: ax), _) -> acc :: packHelper ax [a] a
        | ([], _) -> [acc]
    match lst with
    | (a :: ax) -> packHelper ax [a] a
    | [] -> [[]]
[<EntryPoint>]
let main argv =
    printfn "%A" (pack [1; 1; 2; 2; 3; 4; 4; 4; 4])
    printfn "%A" (pack [1])
    printfn "%A" (pack [])
    printfn "%A" (pack [1; 1])
    
    Console.ReadKey() |> ignore
    0 // return an integer exit code