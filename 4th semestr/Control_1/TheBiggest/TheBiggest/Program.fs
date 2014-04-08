let palCheck number = //funcion which checks if number is a palindome
    let rec degreeTen number result iterator =
        match iterator with
        |temp when (temp < number) ->degreeTen number (result * 10) (iterator + 1)
        |_-> result
    let rec revert number list =
        match number with
        |0 -> list
        |_-> revert (number / 10) ((number % 10) :: list)
    let rec build (list:List<int>) iterator num =
        match iterator with
        |temp when (temp = list.Length) -> num
        |_->build list (iterator + 1) (num + list.Item(iterator) * degreeTen (iterator) 1 0)
    (number = build (revert number []) 0 0)

let biggest = //function which finds the biggest number
    let rec big iter1 iter2 max =
        match iter2 with
            |_ when (iter1 = 1000) -> max
            |temp when (temp < 1000) -> match (palCheck (iter2 * iter1)) with
                                            |true when (iter2 * iter1 > max) -> big iter1 (iter2 + 1) (iter2 * iter1)
                                            |_ -> big iter1 (iter2 + 1) max
            |temp when (temp = 1000) -> big (iter1 + 1) 100 max
            |_->failwith"Out of range"
    big 100 100 0
printfn "Result is:%A" biggest