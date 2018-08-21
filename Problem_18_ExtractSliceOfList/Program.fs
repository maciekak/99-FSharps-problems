// Learn more about F# at http://fsharp.org

open System

let rec slice lst beg fin = 
    let rec helper lst count = 
        match (lst, count) with
        | ((a :: ax), c) when beg <= c && c <= fin -> a  :: helper ax (count + 1)
        | ((_ :: ax), c) when beg > c -> helper ax (count + 1)
        | _ -> []
    helper lst 1

[<EntryPoint>]
let main argv =
    printfn "%A" (slice [1; 2; 3; 4; 5; 6; 7; 8; 9;] 2 9)
    printfn "%A" (slice [1; 2; 3; 4; 5; 6; 7; 8; 9;] 4 10)
    printfn "%A" (slice [1; 2; 3; 4; 5; 6; 7; 8; 9;] 4 5)
    printfn "%A" (slice [1; 2; 3; 4; 5; 6; 7; 8; 9;] 1 1)
    printfn "%A" (slice [1] 2 3)
    printfn "%A" (slice [] 2 3)
    
    Console.ReadKey() |> ignore
    0 // return an integer exit code