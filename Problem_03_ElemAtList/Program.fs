// Learn more about F# at http://fsharp.org

open System

let elemAt aList at =
    let rec helperElemAt bList curr =
        match (bList, curr) with
        | (_, c) when c < 1 -> failwith "Not correct index"
        | ([], _) -> failwith "Not enough elements in list"
        | ((a :: _), c) when c = at -> a
        | ((a :: al), c) when c < at -> helperElemAt al (c + 1)
    helperElemAt aList 1

let testList = [1; 2; 3; 4; 5; 6;]
        



[<EntryPoint>]
let main argv =
    printfn "%A" (elemAt testList 1)
    printfn "%A" (elemAt testList 6)
    printfn "%A" (elemAt testList 4)
    //printfn "%A" (elemAt testList 8)
    //printfn "%A" (elemAt testList 0)

    
    Console.ReadKey() |> ignore
    0 // return an integer exit code