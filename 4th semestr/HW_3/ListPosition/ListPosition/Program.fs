printfn ("Press x to stop adding values to list")
let rec buildList list = //function which builds list
    let input = System.Console.ReadLine()
    match input with
        | "x" -> list
        | _ -> buildList (int (input) :: list)

let list = buildList []

let rec posFunction iterator max finalPosition = //function which finds position
    match (list.Item(iterator) + list.Item(iterator - 1) > max) with
    | true when (iterator < list.Length - 1) -> posFunction (iterator + 1) (list.Item(iterator) + list.Item(iterator - 1)) iterator
    | false when (iterator < list.Length - 1) -> posFunction (iterator + 1) max finalPosition
    | _->finalPosition

let output = posFunction 1 (list.Item(0) + list.Item(1)) 1
printfn "Result is :%A" output