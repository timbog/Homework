printfn "Enter string"
let input = System.Console.ReadLine()

let opposite bracket = 
    match bracket with
    |'}' ->'{'
    |']' ->'['
    |')' ->'('
    |_ ->failwith "Not bracket"

let isCloseBracket str (list:List<char>) =
    match str with
    |('}' | ')' | ']') when (list.Head = opposite str) -> true
    |_ -> false

let ifCorrect = //function which returns if sequence is correct
    let rec correctBracket list iterator =
        match input.[iterator] with
        | '{' | '(' | '[' when iterator <> input.Length - 1 -> correctBracket (input.[iterator] :: list) (iterator + 1)
        |  bracket when (isCloseBracket bracket list) && (iterator <> input.Length - 1)->  correctBracket (list.Tail) (iterator + 1)
        |  bracket when (isCloseBracket bracket list) && (iterator = input.Length - 1) && (list.Length = 1)  -> true
        | '{' | '(' | '[' |'}' | ')' | ']' -> false
        | _ when iterator <> input.Length - 1 -> correctBracket list (iterator + 1)
        | _ when iterator = input.Length - 1 && list.Length = 0 -> true
        |_ -> false
    correctBracket [] 0
printfn "Result is: %A" ifCorrect
