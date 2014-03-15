let rec simpleCheck value temp= //function which checks if the value is simple
    match (value % temp) with
    |0  when value<>temp -> false
    |_ when temp > 1 -> simpleCheck value (temp - 1)
    |_ -> true

let simple number= //function which returns the simple value
    let rec simpleNumber num iterator counter= 
        match simpleCheck iterator iterator with
        |true when (counter < num - 1)-> simpleNumber num (iterator + 1) (counter + 1)
        |true when (counter = num - 1)->iterator
        |_-> simpleNumber num (iterator + 1) counter
    simpleNumber 1 0

let sequence = Seq.initInfinite(fun x -> simple x)



    
