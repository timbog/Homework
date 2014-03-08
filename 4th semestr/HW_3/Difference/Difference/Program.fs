printfn ("Press x to stop adding values to list")
let rec buildList list = //function which builds the list
    let input = System.Console.ReadLine()
    match input with
        | "x" -> list
        | _ -> buildList (int(input) :: list)

let list = buildList []

let different() = //function which chtacks if list is unique
    let rec differenceFunction iterator =
        let rec compare i = 
            if i = list.Length - 1 then true
            else
                match (list.Item(iterator) <> list.Item(i + 1)) with
                | true -> compare (i + 1)
                | false -> false       
        match (compare (iterator)) with
        | true when (iterator < list.Length - 1)-> differenceFunction (iterator + 1)
        | false -> false
        |_ -> true
    differenceFunction 0

let output = different();
printfn "Result is :%A" output