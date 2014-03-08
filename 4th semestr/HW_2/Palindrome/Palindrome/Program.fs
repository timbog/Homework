printfn "Enter string: "
let input = System.Console.ReadLine()

let rec palCheck (str:string) =
    let mutable temp = str.[str.Length - 1]
    match str.[0] with
        |temp when (str.Length > 2) -> palCheck str.[1..str.Length - 2]
        |temp when (str.Length = 1||str.Length = 2) -> true
        |_ -> false
let check = palCheck input
if palCheck input then
    printfn "palindrome"
 else
    printfn "no"



