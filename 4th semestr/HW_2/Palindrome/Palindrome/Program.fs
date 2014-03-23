printfn "Enter string: "
let input = System.Console.ReadLine()

let back (str1:string) = //function which reverses the string
    let rec backString str2 =
        match str2 with
            |"" -> ""
            |tmp -> backString tmp.[1..] + tmp.[0..0]
    backString str1

let palCheck (str:string) = // function which checks if the string is palindrome
    match str.Equals(back str) with
        |true -> "Palindrome"
        |false -> "No"

let output = palCheck input
printfn "%A" output