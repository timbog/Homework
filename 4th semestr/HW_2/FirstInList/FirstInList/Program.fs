printfn "Press x to stop adding values to list"
let rec buildList list = //function which builds list
    let input = System.Console.ReadLine()
    match input with
        | "x" -> list
        | _ -> buildList (int (input) :: list)

let list = buildList []
printfn "Enter number to find: "
let number = int (System.Console.ReadLine())

let rec find = //function which finds an element in list
    let rec findFunction iterator=
        match (list.Item(iterator) = number) with
        | true -> iterator
        | false when iterator < list.Length - 1-> findFunction (iterator + 1)
        | false -> failwith "Number was not found."
    list.Length - findFunction 0

let output = find
printfn "Result is :%A" output