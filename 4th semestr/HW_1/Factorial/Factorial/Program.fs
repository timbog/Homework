let rec factorial n = //factorial counting
    if n < 2 then 1
    else n * factorial(n - 1)

let x = int (System.Console.ReadLine())
let result = factorial x
printfn "Result is :%A" result

