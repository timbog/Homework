let rec numberMultiplication number result = //function which counts number multiplication
    match number with 
    | 0 ->result
    | _->numberMultiplication (number / 10) (result * (number % 10))

let input = int (System.Console.ReadLine())
let output = numberMultiplication input 1
printfn "Result :%A" output
