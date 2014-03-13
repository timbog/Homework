let rec simpleCheck value temp= //function which checks if the value is simple
    match (value % temp) with
    |0  when value<>temp -> false
    |_ when temp > 1 -> simpleCheck value (temp - 1)
    |_ -> true

let rec simpleNumber i = //function which returns the nearest simple value
    match simpleCheck i i with
    |true -> i
    |false-> simpleNumber i + 1

let sequence = Seq.initInfinite(fun x -> simpleNumber x)



    
