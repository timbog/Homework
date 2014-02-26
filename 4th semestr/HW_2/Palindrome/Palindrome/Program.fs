System.Console.WriteLine("Enter string: ")
let input = System.Console.ReadLine();

let palCheck (str:string) =
    match str.[0] with
    |str.[str.Length] when (str.Length <> (1||0))-> palCheck str.[1..str.Length - 1]
    |str.[str.Length] when (str.Length = (1||0)) ->true
    |_ -> false
let check = palCheck input
if check then
    System.Console.WriteLine("palindrome")
 else
     System.Console.WriteLine("no")



