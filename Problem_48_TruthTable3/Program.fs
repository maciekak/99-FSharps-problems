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
    
let table (fn: bool -> bool -> bool) = 
    let products = List.ofSeq(seq {for x in [true; false] do for y in [true; false] -> (x, y)})
    
    let rec all lst = 
        match lst with
        | [] -> []
        | (l :: lt) -> ((fst l, snd l, fn (fst l) (snd l)) :: all lt)
    all products
let table3 (fn: bool -> bool -> bool -> bool) = 
    let products = List.ofSeq(seq {for x in [true; false] do for y in [true; false]  do for z in [true; false] -> (x, y, z)})
    let rec all lst = 
        match lst with
        | [] -> []
        | (l :: lt) -> 
            let (a, b, c) = l
            ((a, b, c, fn a b c) :: all lt)
    all products

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

    printfn "%A" (table3 (fun a b c -> (and' a (or' b (and' c (and' a (and' b c)))))))
    Console.ReadKey() |> ignore
    0 // return an integer exit code
