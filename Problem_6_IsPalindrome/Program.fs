// Learn more about F# at http://fsharp.org

open System

let isPalindrome lt = 
    let rec helperReverse original result =
        match original with
        | [] -> result
        | a :: al -> helperReverse al (a :: result)
    let rec checkIfEqual lt1 lt2 =
        match (lt1, lt2) with
        | ((a :: al), (b :: bl)) when a = b -> checkIfEqual al bl
        | ([], []) -> true
        | _ -> false
    checkIfEqual (helperReverse lt []) lt
    
[<EntryPoint>]
let main argv =
    printfn "%A" (isPalindrome [1; 2; 3; 4; 5; 6;])
    printfn "%A" (isPalindrome [1])
    printfn "%A" (isPalindrome [])
    printfn "%A" (isPalindrome [1; 2; 3; 2; 1])
    printfn "%A" (isPalindrome [1; 2; 2; 1])

    
    Console.ReadKey() |> ignore
    0 // return an integer exit code