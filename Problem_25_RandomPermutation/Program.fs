// Learn more about F# at http://fsharp.org

open System

let rec permutation lst = 
    let rec getLen lt =
        match lt with
        | (_ :: ax) -> 1 + getLen ax
        | _ -> 0
    let len = getLen lst
    let rnd = Random()
    let rec insert lt ind elem =
        match (lt, ind) with
        | (ax, 0) -> elem :: ax
        | ((a :: ax), ind) -> a :: insert ax (ind-1) elem
        | ([], 0) -> [elem]
    let rec getElemAt lt ind =
        match (lt, ind) with
        | ((a :: ax), i) when i < 0 -> match (getElemAt ax ind) with
                                       | (fst, scd) -> (fst, a :: scd)
        | ((a :: ax), i) when i = 0 -> 
            match (getElemAt ax (-1)) with
            | (fst, scd) -> (a, scd)
        | ((a :: ax), i) -> match (getElemAt ax (i-1)) with
                                       | (fst, scd) -> (fst, a :: scd)
        | _ -> (0, [])
    let rec generate currLen srcLst =
        match currLen with
        | curr when curr = len -> []
        | _ -> 
            match (getElemAt srcLst (rnd.Next(len - currLen))) with
            | (fst, scd) -> fst :: (generate (currLen + 1) scd)

    generate 0 lst


[<EntryPoint>]
let main argv =
    printfn "%A" (permutation [1; 2; 3; 4; 5; 6; 7; 8; 9;])
    printfn "%A" (permutation [1; 2; 3; 4; 5; 6; 7; 8; 9;])
    printfn "%A" (permutation [1; 2; 3; 4; 5; 6; 7; 8; 9;])
    printfn "%A" (permutation [1; 2; 3; 4; 5; 6; 7; 8; 9;])
    printfn "%A" (permutation [1])
    
    Console.ReadKey() |> ignore
    0 // return an integer exit code