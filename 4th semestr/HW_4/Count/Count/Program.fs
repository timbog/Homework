type Expression =
    | Value of int
    | Sum of Expression * Expression
    | Multiplication of Expression * Expression
    | X

let rec differentiate (expression:Expression) =
    match expression with
        |Expression.Value(temp) -> Expression.Value(0)
        |Expression.Sum(temp1, temp2) -> Expression.Sum((differentiate temp1), (differentiate temp2))
        |Expression.X -> Expression.Value(1)
        |Expression.Multiplication(temp1, temp2) -> Expression.Sum(Expression.Multiplication(temp1, differentiate(temp2)), Expression.Multiplication(temp2, differentiate(temp1)))

let rec simplify (expression:Expression) =
    match expression with
        |Expression.Sum(Expression.Value(0) ,temp1) | Expression.Sum(temp1 ,Expression.Value(0)) -> temp1
        |Expression.Multiplication(Expression.Value(1) ,temp1) | Expression.Multiplication(temp1 ,Expression.Value(1)) -> temp1
        |Expression.Multiplication(Expression.Value(0) ,temp1) | Expression.Multiplication(temp1 ,Expression.Value(0)) -> Expression.Value(0)
        |Expression.Sum(temp1, temp2) -> Expression.Sum(simplify temp1, simplify temp2)
        |Expression.Multiplication(temp1, temp2) -> Expression.Multiplication(simplify temp1, simplify temp2)
        |temp -> temp
let rec print (expression:Expression) =
    match expression with
        |Expression.Value(temp) -> printfn "%A" temp
        |Expression.Sum(temp1, temp2) -> 
                                        print temp1
                                        printfn"%s" "+"
                                        print temp2
        |Expression.X -> printfn "%s" "x"
        |Expression.Multiplication(temp1, temp2) -> 
                                        print temp1
                                        printfn"%s" "*"
                                        print temp2

let exp = Expression.Sum(Expression.Multiplication(Expression.X, Expression.Value(2)), Expression.Value(3))
let x = differentiate exp
let y = simplify exp
let z = print y