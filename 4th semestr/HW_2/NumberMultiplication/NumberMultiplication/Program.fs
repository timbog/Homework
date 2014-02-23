let rec numberMultiplication number result =
    match number with
    | 0 ->result
    | _->numberMultiplication (number / 10) (result * (number % 10))
let input = System.Int32.Parse(System.Console.ReadLine())
let output = numberMultiplication input 1
printfn "Result :%A" output
