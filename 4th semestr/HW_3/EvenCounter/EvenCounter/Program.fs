printfn ("Press x to stop adding values to list")
let rec buildList list = //function which builds list
    let input = System.Console.ReadLine()
    match input with
        | "x" -> list
        | _ -> buildList (int (input) :: list)

let list = buildList [] 

let newList1 = List.filter (fun x -> x % 2 = 0) list //with using filter
printfn "Result is :%A" newList1.Length

let newList2  = List.fold(fun acc x -> acc + ((x + 1) % 2)) 0 list // with using fold
printfn "Result is :%A" newList1.Length

let tempList = List.map (fun x ->
                          match x % 2 with
                            |0 -> x
                            |_ -> 0) list //with using map
let newList3 = List.filter (fun x -> x <> 0) list
printfn "Result is :%A" newList3.Length


