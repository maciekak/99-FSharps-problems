// Learn more about F# at http://fsharp.org

open System

let rec split lst len = 
    let rec helper lst len count = 
        match (lst, count) with
        | ((a :: ax), c) when c = len -> ([a], ax)
        | ((a :: ax), c) -> match (helper ax len (c + 1)) with
                            | (fst, scd) -> (a :: fst, scd)
        | _ -> ([], [])
    helper lst len 1

[<EntryPoint>]
let main argv =
    printfn "%A" (split [1; 2; 3; 4; 5; 6; 7; 8; 9;] 9)
    printfn "%A" (split [1; 2; 3; 4; 5; 6; 7; 8; 9;] 10)
    printfn "%A" (split [1; 2; 3; 4; 5; 6; 7; 8; 9;] 4)
    printfn "%A" (split [1; 2; 3; 4; 5; 6; 7; 8; 9;] 1)
    printfn "%A" (split [1] 2)
    printfn "%A" (split [] 2)
    
    Console.ReadKey() |> ignore
    0 // return an integer exit code