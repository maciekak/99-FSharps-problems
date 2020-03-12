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

let goldbach number =
    match number with
    | 4 -> (2, 2)
    | _ ->
        let rec arePrimes lower =
            match isPrime lower with
            | true -> match isPrime (number - lower) with
                | true -> (lower, number - lower)
                | false -> arePrimes (lower+2)
            | false -> arePrimes (lower + 2)
        arePrimes 3
    
let rec goldbachSeries fst scd =
    match fst with
    | fst when fst > scd -> []
    | _ -> goldbach fst :: goldbachSeries (fst+2) scd

let res fst scd = 
    printfn "(%d, %d) -> %A" fst scd (goldbachSeries fst scd)

[<EntryPoint>]
let main argv =
    res 6 100
    res 100 200
    res 200 300
    res 122 400
    res 30 550
    res 4 4
    Console.ReadKey() |> ignore
    0 // return an integer exit code
