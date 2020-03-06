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

    let rec factors n p c =
        match n with
        | 1 -> [(p, c)]
        | n when n % p = 0 -> factors (n / p) p (c+1)
        | _ -> match c with
            | 0 -> factors n (nextPrime p) 0
            | _ -> (p, c) :: factors n (nextPrime p) 0
    
    factors num 2 0


let phi m = 
    let pairs = primeFactors m

    let rec iterate list = 
        match list with
        | (l :: lt) -> 
            let (fst, scd) = l
            ((float)fst-1.0) ** ((float)scd-1.0) * (float) fst * iterate lt 
        | [] -> 1.0
    iterate pairs
            
let res fst = 
    printfn "(%d) -> %A" fst (primeFactors fst)
    printfn "(%f)" (phi fst)

[<EntryPoint>]
let main argv =
    res 5
    res 100
    res 200
    res 123
    res 31
    res 2

    Console.ReadKey() |> ignore
    0
