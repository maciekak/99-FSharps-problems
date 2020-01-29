// Learn more about F# at http://fsharp.org

open System

let rec group groups lst =     
    let rec getLen lt =
        match lt with
        | (_ :: ax) -> 1 + getLen ax
        | _ -> 0
    let len = getLen lst
    
    let rec generate grp lt curr maxLen currLen rest res = 
        match (grp, lt, maxLen, currLen) with
        | ([], _, _, _) -> [[[]]]
        | ((g :: []), l, _, _) -> [res @ [l]]
        | ((g :: gr), l, m, c) when c = g -> generate gr (rest) [] (m-c) (m-c) [] (res @ [curr @ l])
        | ((g :: gr), l, m, c) when g = 0 -> (generate gr (rest @ l) [] m m [] (res @ [curr]))
        | ((g :: gr), (a :: l), m, c) -> (generate ((g-1) :: gr) l (curr @ [a]) (m-1) (c-1) rest res) @ (generate (g :: gr) (l) (curr) maxLen (c-1) (rest @ [a]) res)
        | (_, _, _, _) -> [[[]]]

    generate groups lst [] len len [] []
    
[<EntryPoint>]
let main argv =
    printfn "%A" (group [1] [1])
    printfn "%A" (group [7] [1; 2; 3; 4; 5; 6; 7])
    printfn "%A" (group [2; 3] [1; 2; 3; 4; 5;])
    printfn "%A" (group [2; 2; 2] [1; 2; 3; 4; 5; 6])
    printfn "%A" (group [1; 2; 3] [1; 2; 3; 4; 5; 6])
    
    Console.ReadKey() |> ignore
    0 // return an integer exit code