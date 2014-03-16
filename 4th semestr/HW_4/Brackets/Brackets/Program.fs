printfn "Enter string"
let input = System.Console.ReadLine()
let ifCorrect = //function which returns if sequence is correct
    let rec correctBracket list iterator =
        match input.[iterator] with
        | '{' | '(' | '[' when iterator <> input.Length - 1 -> correctBracket (input.[iterator] :: list) (iterator + 1)
        | '}' when list.Head = '{' && iterator <> input.Length - 1 -> correctBracket (list.Tail) (iterator + 1)
        | ']' when list.Head = '[' && iterator <> input.Length - 1 -> correctBracket (list.Tail) (iterator + 1)
        | ')' when list.Head = '(' && iterator <> input.Length - 1 -> correctBracket (list.Tail) (iterator + 1)
        | '}' when list.Head = '{' && (list.Length = 1) && iterator = input.Length - 1 -> true
        | ']' when list.Head = '[' && (list.Length = 1) && iterator = input.Length - 1 -> true
        | ')' when list.Head = '(' && (list.Length = 1) && iterator = input.Length - 1 -> true
        | '{' | '(' | '[' |'}' | ')' | ']' -> false
        | _ when iterator <> input.Length - 1 -> correctBracket list (iterator + 1)
        | _ when iterator = input.Length - 1 && list.Length = 0 -> true
        |_ -> false
    correctBracket [] 0
printfn "Result is: %A" ifCorrect
     