// Learn more about F# at http://fsharp.org

open System

let rotate lst count = 
    let rec len lt =
        match lt with
        | (_ :: ax) -> 1 + len ax
        | _ -> 0
    let rec takeFirstElems lt num =
        match (lt, num) with
        | (_, n) when n = 0 -> []
        | ((a :: ax), n) -> a :: takeFirstElems ax (n-1)
        | _ -> []
    let rec ignoreFirstElems lt num =
        match (lt, num) with
        | ((_ :: ax), n) when n = 1 -> ax
        | ((_ :: ax), n) -> ignoreFirstElems ax (n-1)
        | _ -> []
    let rec concat fst scd =
        match fst with
        | (a :: ax) -> a :: concat ax scd
        | [] -> scd

    match count with
    | c when c > 0 -> 
        let firstElems = takeFirstElems lst count
        concat (ignoreFirstElems lst count) firstElems
    | _ -> 
        let length = len lst
        let firstElems = takeFirstElems lst (length + count)
        concat (ignoreFirstElems lst (length + count)) firstElems

[<EntryPoint>]
let main argv =
    printfn "%A" (rotate [1; 2; 3; 4; 5; 6; 7; 8; 9;] 3)
    printfn "%A" (rotate [1; 2; 3; 4; 5; 6; 7; 8; 9;] -3)
    printfn "%A" (rotate [1; 2; 3; 4; 5; 6; 7; 8; 9;] 5)
    printfn "%A" (rotate [1; 2; 3; 4; 5; 6; 7; 8; 9;] -7)
    printfn "%A" (rotate [1] 2)
    printfn "%A" (rotate [] 2)
    
    Console.ReadKey() |> ignore
    0 // return an integer exit code