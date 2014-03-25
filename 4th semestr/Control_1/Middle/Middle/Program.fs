let list = [4.5; 7.8; 8.9; 10.3]
let rec middle iter result = //function which counts middle
    match iter with
    |0 -> result + (Core.Operators.sin(list.Item(0))/float(list.Length))
    |_ -> middle (iter - 1) (result + Core.Operators.sin(list.Item(iter))/float(list.Length))

let res = middle (list.Length - 1) 0.0
printfn "%A" res






