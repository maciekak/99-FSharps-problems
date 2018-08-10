// Learn more about F# at http://fsharp.org

open System

let testList = [1; 2; 3; 4; 5; 6]

let rec lastEl aList =
    match aList with
    | (a :: []) -> a
    | (_ :: al) -> lastEl al
    | _ -> failwith "Not supported size of list"


[<EntryPoint>]
let main argv =
    printfn "%A" (lastEl testList)
    printfn "%A" (lastEl [1])
    
    Console.ReadKey() |> ignore
    0 // return an integer exit code
