// Learn more about F# at http://fsharp.org

open System

let rec removeAt lst at = 
    match (lst, at) with
    | ((_ :: ax), index) when index = 1 -> ax
    | ((a :: ax), index) -> a :: removeAt ax (index - 1)
    | _ -> []

[<EntryPoint>]
let main argv =
    printfn "%A" (removeAt [1; 2; 3; 4; 5; 6; 7; 8; 9;] 9)
    printfn "%A" (removeAt [1; 2; 3; 4; 5; 6; 7; 8; 9;] 10)
    printfn "%A" (removeAt [1; 2; 3; 4; 5; 6; 7; 8; 9;] 4)
    printfn "%A" (removeAt [1; 2; 3; 4; 5; 6; 7; 8; 9;] 1)
    printfn "%A" (removeAt [1] 2)
    printfn "%A" (removeAt [] 2)
    
    Console.ReadKey() |> ignore
    0 // return an integer exit code