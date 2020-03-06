// Learn more about F# at http://fsharp.org

open System

let isPrime num =
    let rec check n =
        match n with
        | n when n*n > num -> true
        | n when num % n = 0 -> false
        | n -> check (n+2)

    match num with
    | num when num < 2 -> false
    | num when num = 2 -> true
    | num when num % 2 = 0 -> false
    | num -> check 3

    
let primeRange n m =
    let rec getList ind = 
        match ind with
        | i when ind <= m ->
            let prime = isPrime i
            match prime with
            | true -> i :: getList (ind + 1)
            | false -> getList (ind + 1)
        | _ -> []
    getList n
[<EntryPoint>]
let main argv =
    printfn "Range: %A" (primeRange 2 20)
    printfn "Range: %A" (primeRange 2 3)
    printfn "Range: %A" (primeRange 5 7)
    printfn "Range: %A" (primeRange 2 200)
    printfn "Range: %A" (primeRange 2 100)
    
    Console.ReadKey() |> ignore
    0 // return an integer exit code
