// Learn more about F# at http://fsharp.org

open System

let rec rndSelect lst num = 
    let rnd = Random()
    let rec getLen lt = 
        match lt with
        | (_ :: ax) -> 1 + getLen ax
        | _ -> 0
    let len = getLen lst
    let rec getSingleElem lt n =
        match (lt, n) with
        | ((a :: _), n) when n = 0 -> a
        | ((_ :: ax), n) -> getSingleElem ax (n-1)
    let rec getRndElem times =
        match times with 
        | t when t = 0 -> []
        | _ -> (getSingleElem lst (rnd.Next(len)) :: (getRndElem (times-1)))
    getRndElem num

[<EntryPoint>]
let main argv =
    printfn "%A" (rndSelect [1; 2; 3; 4; 5; 6; 7; 8; 9;] 9)
    printfn "%A" (rndSelect [1; 2; 3; 4; 5; 6; 7; 8; 9;] 10)
    printfn "%A" (rndSelect [1; 2; 3; 4; 5; 6; 7; 8; 9;] 4)
    printfn "%A" (rndSelect [1; 2; 3; 4; 5; 6; 7; 8; 9;] 1)
    printfn "%A" (rndSelect [1] 2)
    
    Console.ReadKey() |> ignore
    0 // return an integer exit code