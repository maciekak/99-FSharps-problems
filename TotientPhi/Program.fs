// Learn more about F# at http://fsharp.org

open System

let rec gcd fst snd =
    match (fst, snd) with
    | (fst, snd) when snd = 0 -> fst
    | (fst, snd) -> gcd snd (fst % snd)
let isCoprime fst snd =
    (gcd fst snd) = 1

let phi num =
    let rec helperPhi value =
        match value with
        | n when n <= 1 -> 1
        | _ -> match (isCoprime num value) with
            | true -> 1 + helperPhi (value-1)
            | false -> helperPhi (value-1)
    helperPhi (num-1)

let res fst = 
    printfn "%d -> %d" fst (phi fst )
[<EntryPoint>]
let main argv =
    res 1
    res 15
    res 140
    res 6
    res 10

    Console.ReadKey() |> ignore
    0 // return an integer exit code
