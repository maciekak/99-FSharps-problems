// Learn more about F# at http://fsharp.org

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
        | (Elem x :: xs) -> x :: helper xs
        | (List x :: xs) -> concat (helper x) (helper xs)

    helper lst
    
[<EntryPoint>]
let main argv =
    (*printfn "%A" (flattenList (NestedList (Elem 3)))
    printfn "%A" (flattenList [1])
    printfn "%A" (flattenList [])
    printfn "%A" (flattenList [1; 2; 3; 2; 1])
    printfn "%A" (flattenList [1; 2; 2; 1])*)

    
    Console.ReadKey() |> ignore
    0 // return an integer exit code