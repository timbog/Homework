let rec primeCheck value temp = //function which checks if the value is simple
    match (value % temp) with
    |0  when value<>temp && temp > 1 -> false
    |_ when temp > 1 -> primeCheck value (temp - 1)
    |_ -> true 

let prime number= //function which returns the simple value
    let rec primeNumber num iterator counter= 
        match primeCheck iterator iterator with
        |true when (counter <= num - 1)-> primeNumber num (iterator + 1) (counter + 1)
        |true when (counter = num) ->iterator
        |_-> primeNumber num (iterator + 1) counter
    primeNumber number 1 1

let sequence = Seq.initInfinite(fun x -> prime x)