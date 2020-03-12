// Learn more about F# at http://fsharp.org

open System

let and' a b =
    a && b
let or' a b =
    a || b
let xor' a b =
    a && not b || not a && b
let nor' a b =
    not (a || b)
let nand' a b =
    not (a && b)
let not' a =
    not a
let eq' a b =
    a = b
let impl' a b =
    not (a && not b)


    



[<EntryPoint>]
let main argv =
    printfn "%b" (and' true false)
    printfn "%b" (or' true false)
    printfn "%b" (xor' true false)
    printfn "%b" (nor' true false)
    printfn "%b" (nand' true false)
    printfn "%b" (not' true)
    printfn "%b" (eq' true false)
    printfn "%b" (impl' false false)

    Console.ReadKey() |> ignore
    0 // return an integer exit code
