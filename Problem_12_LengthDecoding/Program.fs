// Learn more about F# at http://fsharp.org

open System

let rec decode lst = 
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
        | (_, len, ch) -> createList len ch
    match lst with
    | (a :: ax) -> concat (decodeSingle a) (decode ax)
    | [] -> []
[<EntryPoint>]
let main argv =
    printfn "%A" (decode [("Multiple", 2, 1); ("Multiple", 2, 2); ("Single", 1, 3); ("Multiple", 4, 4)])
    printfn "%A" (decode [("Single", 1, 1)])
    printfn "%A" (decode [])
    printfn "%A" (decode [("Multiple", 2, 1)])
    
    Console.ReadKey() |> ignore
    0 // return an integer exit code