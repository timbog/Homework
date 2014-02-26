System.Console.WriteLine("Press x to stop adding values to list")
let rec buildList list =
    let input = System.Console.ReadLine()
    match input with
        | "x" -> list
        | _ -> buildList (list @ [System.Int32.Parse(input)])
let list = buildList []
System.Console.WriteLine("Enter number to find: ")
let number = System.Int32.Parse(System.Console.ReadLine())
let rec findFunction iterator=
    match (list.Item(iterator) = number) with
    | true -> iterator
    | false -> findFunction (iterator + 1)
let output = findFunction 0;
printfn "Result is :%A" output