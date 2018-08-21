// Learn more about F# at http://fsharp.org

open System

let rec dropEvery lst idx = 
    let rec dropHelper lst idx currIdx =
        match (lst, currIdx) with
        | ((_ :: ax), curr) when curr = idx -> dropHelper ax idx 1
        | ((a :: ax), curr) -> a :: dropHelper ax idx (curr + 1)
        | _ -> []
    dropHelper lst idx 1

[<EntryPoint>]
let main argv =
    printfn "%A" (dropEvery [1; 2; 3; 4; 5; 6; 7; 8; 9;] 2)
    printfn "%A" (dropEvery [1; 2; 3; 4; 5; 6; 7; 8; 9;] 4)
    printfn "%A" (dropEvery [1; 2; 3; 4; 5; 6; 7; 8; 9;] 1)
    printfn "%A" (dropEvery [1] 2)
    printfn "%A" (dropEvery [] 2)
    
    Console.ReadKey() |> ignore
    0 // return an integer exit code