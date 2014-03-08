let rec double number = //function which builds degree of two
    match number with 
    | 0 -> 1
    | _ -> 2 * double (number-1)

let oldList = []

let rec buildList num list = //function which builds list
    match num with
    |0 -> (double num :: list) 
    |_ ->buildList (num - 1) (double num ::list)

let result = buildList 5 oldList 
printfn "Result :%A" result