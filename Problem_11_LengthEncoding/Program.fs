// Learn more about F# at http://fsharp.org

open System

let encode lst = 
    let encodeIsMultiple len =
        match len with
        | l when l = 1 -> "Single"
        | l when l < 1 -> "Error"
        | _ -> "Multiple"
    let rec packHelper lt acc last = 
        match (lt, last) with
        | ((a :: ax), last) when a = last -> packHelper ax (acc + 1) a
        | ((a :: ax), last) -> ((encodeIsMultiple acc), acc, last) :: packHelper ax 1 a
        | ([], last) -> [((encodeIsMultiple acc), acc, last)]
    match lst with
    | (a :: ax) -> packHelper ax 1 a
    | [] -> []
[<EntryPoint>]
let main argv =
    printfn "%A" (encode [1; 1; 2; 2; 3; 4; 4; 4; 4])
    printfn "%A" (encode [1])
    printfn "%A" (encode [])
    printfn "%A" (encode [1; 1])
    
    Console.ReadKey() |> ignore
    0 // return an integer exit code