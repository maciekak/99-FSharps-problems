// Learn more about F# at http://fsharp.org

open System

let rec lotto num max = 
    let rnd = Random()
    let rec checkIfElemInSeq lst elem = 
        match lst with
        | (a :: _) when a = elem -> true
        | (_ :: ax) -> checkIfElemInSeq ax elem
        | _ -> false
    let rec getRandomNumbers acc n =
        match n with
        | n when n = 0 -> acc
        | _ -> 
            let number = rnd.Next(max)
            let ifExist = checkIfElemInSeq acc number
            match ifExist with
            | false -> getRandomNumbers (number :: acc) (n-1)
            | _ -> getRandomNumbers acc n
    getRandomNumbers [] num


[<EntryPoint>]
let main argv =
    printfn "%A" (lotto 2 9)
    printfn "%A" (lotto 9 9)
    printfn "%A" (lotto 6 49)
    
    Console.ReadKey() |> ignore
    0 // return an integer exit code