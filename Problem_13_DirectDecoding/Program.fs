// Learn more about F# at http://fsharp.org

open System
type 'a ListElem =
    | Single of 'a
    | Multiple of int * 'a
    
let rec decodeDirect lst = 
    let rec createList len ch =
        match len with
        | l when l = 1 -> [ch]
        | l when l < 1 -> []
        | _ -> ch :: createList (len-1) ch
    let rec concat fst snd = 
        match fst with
        | (a :: ax) -> a :: concat ax snd
        | [] -> snd
    let decodeSingle elem = 
        match elem with
        | Single a -> [a]
        | Multiple (len, ch) -> createList len ch
    match lst with
    | (a :: ax) -> concat (decodeSingle a) (decodeDirect ax)
    | [] -> []
[<EntryPoint>]
let main argv =
    printfn "%A" (decodeDirect [Multiple (2, 1); Multiple (2, 2); Single 3; Multiple (4, 4)])
    printfn "%A" (decodeDirect [Single 1])
    printfn "%A" (decodeDirect [])
    printfn "%A" (decodeDirect [Multiple (2, 1)])
    
    Console.ReadKey() |> ignore
    0 // return an integer exit code