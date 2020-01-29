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
    | num -> check 3

    

[<EntryPoint>]
let main argv =
    printfn "%d Prime? %b" 1 (isPrime 1)
    printfn "%d Prime? %b" 2 (isPrime 2)
    printfn "%d Prime? %b" 3 (isPrime 3)
    printfn "%d Prime? %b" 123 (isPrime 123)
    printfn "%d Prime? %b" 2222 (isPrime 2222)
    printfn "%d Prime? %b" 1231 (isPrime 1231)
    
    Console.ReadKey() |> ignore
    0 // return an integer exit code
