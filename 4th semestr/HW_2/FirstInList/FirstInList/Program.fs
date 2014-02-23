System.Console.WriteLine("Press x to stop adding values to list")
let rec buildList list =
    let input = System.Console.ReadLine()
    if (input <>"x") then
       let list = [System.Int32.Parse(input)] :: (list)
    match input with
        | "x" -> list
        | _ -> buildList list
let list = buildList []
printfn "Result is :%A" list
System.Console.WriteLine("Enter number to find: ")
let number = System.Int32.Parse(System.Console.ReadLine())

//let rec findFunction iterator=
//    match (list.Item(iterator) = number) with
//    | true -> iterator
 //   | false -> findFunction (iterator + 1)
//let output = findFunction 0;
//printfn "Result is :%A" output
