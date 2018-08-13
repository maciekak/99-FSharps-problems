// Learn more about F# at http://fsharp.org

open System

let reverseList aList = 
    let rec helperReverse original result =
        match original with
        | [] -> result
        | a :: al -> helperReverse al (a :: result)
    helperReverse aList []
    
[<EntryPoint>]
let main argv =
    printfn "%A" (reverseList [1; 2; 3; 4; 5; 6;])
    printfn "%A" (reverseList [1])
    printfn "%A" (reverseList [])

    
    Console.ReadKey() |> ignore
    0 // return an integer exit code