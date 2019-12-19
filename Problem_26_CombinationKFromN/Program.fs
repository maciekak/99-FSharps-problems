// Learn more about F# at http://fsharp.org

open System

let rec combination n lst = 
    let rec getLen lt =
        match lt with
        | (_ :: ax) -> 1 + getLen ax
        | _ -> 0
    let len = getLen lst
    
    let rec generate lt res combLen currLen = 
        match (combLen, currLen) with
        | (l, _) when l = 0 -> [res]
        | (l, c) when l > c -> [[]]
        | (l, c) when l = c -> [res @ lt]
        | _ -> match lt with
            | (a :: ax) -> (generate ax (res @ [a]) (combLen-1) (currLen-1))  @ (generate ax res combLen (currLen-1))

    generate lst [] n len
    
[<EntryPoint>]
let main argv =
    printfn "%A" (combination 1 [1; 2; 3; 4; 5; 6; 7])
    printfn "%A" (combination 2 [1; 2; 3; 4; 5; 6; 7])
    printfn "%A" (combination 3 [1; 2; 3; 4; 5; 6; 7])
    printfn "%A" (combination 4 [1; 2; 3; 4; 5; 6; 7])
    printfn "%A" (combination 1 [1])
    
    Console.ReadKey() |> ignore
    0 // return an integer exit code