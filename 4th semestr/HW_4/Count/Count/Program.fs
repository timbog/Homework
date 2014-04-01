printfn "Enter expression"
let input = System.Console.ReadLine()
let countExpression() =
    let rec count iter (result:string) = 
        match (iter < input.Length) with
            |true when (input.Length <> 1)-> match input.[iter] with
                        |'+' | '-' | '*' | '/' -> count (iter + 1) (result + input.[iter].ToString())
                        |'x' -> count (iter + 1) (result + "1")
                        |_-> match (iter = 0) with
                                |true-> match input.[iter + 1] with
                                            |'*' | '/' -> count (iter + 1) (result + input.[iter].ToString())
                                            |_-> count (iter + 1) (result + "0")
                                |false-> match iter = (input.Length - 1) with               
                                            |true -> match input.[iter - 1] with
                                                        |'*' | '/' -> count (iter + 1) (result + input.[iter].ToString())
                                                        |_-> count (iter + 1) (result + "0")
                                            |false-> match input.[iter - 1] with
                                                        |'*' | '/' -> count (iter + 1) (result + input.[iter].ToString())
                                                        |_ -> match input.[iter + 1] with
                                                                |'*' | '/' -> count (iter + 1) (result + input.[iter].ToString())
                                                                |_-> count (iter + 1) (result + "0")
            |true when (input.Length = 1) -> input
            |_ -> result
    count 0 ""

let rec simplify (str:string) iter (result:string)=
        match (iter < str.Length) with
            |true-> match str.[iter] with
                        |'+' | '-' -> match str.[iter + 1] with
                                        |'0' -> simplify str (iter + 2) result
                                        |_-> simplify str (iter + 2) (result + str.[iter].ToString())
                        |'*'  -> simplify str (iter + 2) (result + (int(str.[iter - 1].ToString()) * int(str.[iter + 1].ToString())).ToString())
                        |'/'  -> simplify str (iter + 2) (result + (int(str.[iter - 1].ToString()) / int(str.[iter + 1].ToString())).ToString())
                        |_ ->  match (iter = str.Length - 1) with
                                 |true -> (result + str.[iter].ToString())
                                 |false -> match str.[iter + 1] with
                                            |'+' | '-' -> simplify str (iter + 1) (result + str.[iter].ToString())
                                            |_ -> simplify str (iter + 1) result
            |false -> result                             
printfn "Result is: "           
let x = countExpression()
printfn "%A" x
let z = simplify x 0 ""
printfn "%A" z
let y = System.Console.ReadKey()                                      
