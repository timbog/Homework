type Node<'a> = //tree itself
    | Node of 'a * Node<'a> * Node<'a>
    | Empty

type Tree() = //tree with value adding
    let mutable node = Node.Empty
    member t.Add(value) =
        let rec insert value tree= 
            match tree with
            | Empty -> Node(value, Empty, Empty)
            | Node(v, left, right) when value < v -> Node(v, insert value left, right)
            | Node(v, left, right) when value > v -> Node(v, left, insert value right)
            | Node(_, _, _) as n -> n
        node <- insert (value) (node)
    member t.getNode() = node

type Iterator(tree:Tree) = //iterator
    let makeList = 
        let rec build node treeList:List<Node<'a>>=
            match node with
                |Node(v, left, right) when (left = Empty) && (right = Empty) -> (node::treeList)
                |Empty -> treeList
                |Node(v, left, right) -> 
                                         let temp = build left (treeList)
                                         build right (temp @ node::treeList)
        build (tree.getNode()) []
    let mutable list = List.rev(makeList)
    let mutable current = -1

    member i.Next =
                    match (current + 1 < list.Length) with
                        |true ->
                                 current <- current + 1 
                                 list.Item(current)
                        |false -> failwith("End of list")
    member i.First = 
                    current <- 0
                    list.Item(0)
    member i.getList = list        
        
let tr = new Tree()
tr.Add(6)
tr.Add(7)
tr.Add(5)
let it = new Iterator(tr) 
printfn "%A" it.First
printfn "%A" it.Next
printfn "%A" it.Next

                        



