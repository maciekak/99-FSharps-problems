// Learn more about F# at http://fsharp.org

open System

let rec preLastEl aList =
    match aList with
    | (a :: _ :: []) -> a
    | (_ :: b :: al) -> preLastEl (b :: al)
    | _ -> failwith "Not enought length of list"

[<EntryPoint>]
let main argv =
    printfn "%A" (preLastEl [1; 2; 3; 4; 5;])
    printfn "%A" (preLastEl [1; 2;])


    Console.ReadKey() |> ignore
    0 // return an integer exit code