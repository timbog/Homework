type Operation = string
type Number = int
type Tree = 
    |Tree of Operation *Tree *Tree
    |Tip of Number

let count operation temp1 temp2 =
    match operation with
    |"+" ->temp1 + temp2
    |"-" ->temp1 - temp2
    |"*" ->temp1 * temp2
    |"/" ->temp1 / temp2
    |_ ->failwith "No such operation"

let rec countTree (tree:Tree) = //function which counts the tree
    match tree with
    |Tree(a, l, r) -> count a (countTree(l)) (countTree(r))
    |Tip b ->b 
