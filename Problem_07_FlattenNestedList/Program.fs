﻿// Learn more about F# at http://fsharp.org

open System

type 'a NestedList = 
    | List of 'a NestedList list
    | Elem of 'a

let rec flattenList lst =
    let rec concat lst1 lst2 =
        match lst1 with
        | (x :: xs) -> x :: concat xs lst2
        | [] -> lst2

    let rec helper lt =
        match lt with
        | [] -> []
        | (Elem x :: xs) -> Elem x :: helper xs
        | (List x :: xs) -> concat (helper x) (helper xs)

    helper lst
    
[<EntryPoint>]
let main argv =
    let testList = [List [Elem 2; Elem 3; List [List [Elem 1; Elem 7]; Elem 6]; Elem 12]]
    printfn "%A" testList
    printfn "%A" (flattenList testList)
    
    Console.ReadKey() |> ignore
    0 // return an integer exit code