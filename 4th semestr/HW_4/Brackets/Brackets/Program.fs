printfn "Enter string"
let input = System.Console.ReadLine()

let opposite bracket = 
    match bracket with
    |'}' ->'{'
    |']' ->'['
    |')' ->'('
    |_ ->failwith "Not bracket"

let ifCorrect = //function which returns if sequence is correct
    let rec correctBracket list iterator =
        match input.[iterator] with
        | '{' | '(' | '[' when iterator <> input.Length - 1 -> correctBracket (input.[iterator] :: list) (iterator + 1)
        |  bracket when ((bracket ='}') || (bracket =')') || (bracket =']')) && (iterator <> input.Length - 1) && (list.Head = opposite bracket)->  correctBracket (list.Tail) (iterator + 1)
        |  bracket when ((bracket ='}') || (bracket =')') || (bracket =']')) && (list.Head = opposite bracket) && (list.Length = 1) && (iterator = input.Length - 1) -> true
        | '{' | '(' | '[' |'}' | ')' | ']' -> false
        | _ when iterator <> input.Length - 1 -> correctBracket list (iterator + 1)
        | _ when iterator = input.Length - 1 && list.Length = 0 -> true
        |_ -> false
    correctBracket [] 0
printfn "Result is: %A" ifCorrect
