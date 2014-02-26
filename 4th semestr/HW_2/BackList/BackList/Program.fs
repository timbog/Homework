System.Console.WriteLine("Press x to stop adding values to list")
let rec buildList list =
    let input = System.Console.ReadLine() 
    match input with
        | "x" -> list
        | _ -> buildList list @ [System.Int32.Parse(input)]
let oldList = buildList []
let buildNewList list = 
    let rec back list newList =
        match list with
            |(h::t) -> back t (newList @ [h])
            |[] -> newList
    back list []
let output = buildNewList oldList
printfn "Circulated List :%A" output
