// Дополнительные сведения о F# см. на http://fsharp.net
// Дополнительную справку см. в проекте "Учебник по F#".

[<EntryPoint>]
let main argv = 
    System.Console.WriteLine("Press x to stop adding values to list")
    let mutable input = System.Console.ReadLine()
    let rec buildList list =
        let oldList = (list) @ [System.Int32.Parse(input)] 
        match input with
            | "x" -> list
            | _ -> buildList list
    let oldList = buildList []
    let buildNewList list = 
        let rec back list newList =
            match list with
                |(h::t) -> back t (h::newList)
                |[] -> newList
        back list []
    let output = buildNewList oldList
    printfn "New List :%A" output
