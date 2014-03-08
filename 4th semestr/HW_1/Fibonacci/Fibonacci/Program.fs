let rec fib n = //fibonacci counting
    if n = 1 then 0
    else if n = 2 then 1
    else fib(n - 1) + fib(n - 2)

let x = int (System.Console.ReadLine())
let output = fib x
printfn "%A" output
