type Expression = //expression itself
    | Value of int
    | Sum of Expression * Expression
    | Multiplication of Expression * Expression
    | Division of Expression * Expression
    | Difference of Expression * Expression
    | X

let rec differentiate (expression:Expression) = //differentiation
    match expression with
        |Expression.Value(temp) -> Expression.Value(0)
        |Expression.Sum(temp1, temp2) -> Expression.Sum((differentiate temp1), (differentiate temp2))
        |Expression.Difference(temp1, temp2) -> Expression.Difference((differentiate temp1), (differentiate temp2))
        |Expression.X -> Expression.Value(1)
        |Expression.Multiplication(Expression.Value(temp1), Expression.X) | Expression.Multiplication(Expression.X, Expression.Value(temp1)) -> Expression.Value(temp1)
        |Expression.Multiplication(temp1, temp2) -> Expression.Sum(Expression.Multiplication(temp1, differentiate(temp2)), Expression.Multiplication(temp2, differentiate(temp1)))
        |Expression.Division(temp1, temp2) -> Expression.Division(Expression.Difference(Expression.Multiplication(temp2, differentiate(temp1)), Expression.Multiplication(temp1, differentiate(temp2))), Expression.Multiplication(temp2, temp2))

let rec simplify (expression:Expression) = //simplification
    match expression with
        |Expression.Sum(Expression.Value(0) ,temp1) | Expression.Sum(temp1 ,Expression.Value(0)) -> simplify temp1
        |Expression.Difference(temp1 ,Expression.Value(0)) -> simplify temp1
        |Expression.Multiplication(Expression.Value(1), temp1) | Expression.Multiplication(temp1, Expression.Value(1)) -> simplify temp1
        |Expression.Multiplication(Expression.Value(0), temp1) | Expression.Multiplication(temp1, Expression.Value(0)) -> Expression.Value(0)
        |Expression.Division(Expression.Value(0), temp1) -> Expression.Value(0)
        |Expression.Division(temp1, Expression.Value(0)) -> failwith("Division by zero")
        |Expression.Sum(temp1, temp2) -> Expression.Sum(simplify temp1, simplify temp2)
        |Expression.Multiplication(temp1, temp2) -> Expression.Multiplication(simplify temp1, simplify temp2)
        |Expression.Difference(temp1, temp2) -> Expression.Difference(simplify temp1, simplify temp2)
        |Expression.Division(temp1, temp2) -> Expression.Division(simplify temp1, simplify temp2)
        |temp -> temp

let rec print (expression:Expression) = //correct print
    match expression with
        |Expression.Value(temp) -> printf "%A" temp
        |Expression.Sum(temp1, temp2) ->
                                        printf"%s" "(" 
                                        print temp1
                                        printf"%s" "+"
                                        print temp2
                                        printf"%s" ")"
        |Expression.X -> printf "%s" "x"
        |Expression.Multiplication(temp1, temp2) ->
                                        printf"%s" "(" 
                                        print temp1
                                        printf"%s" "*"
                                        print temp2
                                        printf"%s" ")"
        |Expression.Difference(temp1, temp2) ->
                                        printf"%s" "(" 
                                        print temp1
                                        printf"%s" "-"
                                        print temp2
                                        printf"%s" ")"
        |Expression.Division(temp1, temp2) ->
                                        printf"%s" "(" 
                                        print temp1
                                        printf"%s" "/"
                                        print temp2
                                        printf"%s" ")"


let exp = Expression.Difference(Expression.Multiplication(Expression.Multiplication(Expression.X, Expression.Value(2)),Expression.X), Expression.Value(3))
let x = differentiate exp
let y = simplify x
let z = print  y