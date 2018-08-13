// Learn more about F# at http://fsharp.org

open System

let listLength aList = 
    let rec helperListLength bList len = 
        match bList with 
        | [] -> 0
        | a :: al -> helperListLength al len+1
    helperListLength aList 0
    
[<EntryPoint>]
let main argv =
    printfn "%A" (listLength [1; 2; 3; 4; 5; 6;])
    printfn "%A" (listLength [1])
    printfn "%A" (listLength [])

    
    Console.ReadKey() |> ignore
    0 // return an integer exit code