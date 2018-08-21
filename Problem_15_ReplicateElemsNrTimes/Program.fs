// Learn more about F# at http://fsharp.org

open System

let rec rep lst num = 
    let rec repeat lt num currNum =
        match (lt, currNum) with
        | ((a :: ax), n) when n > 1 -> a :: repeat (a :: ax) num (currNum - 1)
        | ((a :: ax), n) when n = 1 -> a :: repeat ax num num
        | _ -> []
    repeat lst num num

[<EntryPoint>]
let main argv =
    printfn "%A" (rep [1; 2; 3;] 3)
    printfn "%A" (rep [1] 3)
    printfn "%A" (rep [] 3)
    printfn "%A" (rep [1; 2; 3;] 1)
    printfn "%A" (rep [1] 1)
    printfn "%A" (rep [] 1)
    
    Console.ReadKey() |> ignore
    0 // return an integer exit code