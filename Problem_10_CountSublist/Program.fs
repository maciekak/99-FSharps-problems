// Learn more about F# at http://fsharp.org

open System

let count lst = 
    let rec packHelper lt acc last = 
        match (lt, last) with
        | ((a :: ax), last) when a = last -> packHelper ax (acc + 1) a
        | ((a :: ax), last) -> (acc, last) :: packHelper ax 1 a
        | ([], last) -> [(acc, last)]
    match lst with
    | (a :: ax) -> packHelper ax 1 a
    | [] -> []
[<EntryPoint>]
let main argv =
    printfn "%A" (count [1; 1; 2; 2; 3; 4; 4; 4; 4])
    printfn "%A" (count [1])
    printfn "%A" (count [])
    printfn "%A" (count [1; 1])
    
    Console.ReadKey() |> ignore
    0 // return an integer exit code