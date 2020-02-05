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

let primeFactors num =
    let rec nextPrime n =
        match isPrime (n+1) with
        | true -> n+1
        | false -> nextPrime (n+1)

    let rec factors n p =
        match n with
        | 1 -> []
        | n when n % p = 0 -> p :: factors (n / p) p
        | _ -> factors n (nextPrime p)
    
    factors num 2

let res fst = 
    printfn "(%d) -> %A" fst (primeFactors fst)
[<EntryPoint>]
let main argv =
    res 5
    res 100
    res 200
    res 123
    res 31
    res 1
    res 2
    
    Console.ReadKey() |> ignore
    0
