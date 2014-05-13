open System.Collections
open System.Collections.Generic

type Node<'a> = //tree itself
    | Node of 'a * Node<'a> * Node<'a>
    | Empty

type Iterator<'a>(tree:Node<'a>) = //iterator
    let rec makeList = function
        | Empty -> []
        | Node(a, l, r) -> makeList(l)@a::makeList(r)
    let mutable list = makeList tree
    let mutable current = -1
    interface IEnumerator with
        member i.MoveNext() =
                    match (current + 1 < list.Length) with
                        |true ->
                                 current <- current + 1 
                                 true
                        |false -> false
        member i.Current = box <|list.Item(current)
        member i.Reset() = (current <- -1)

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
    interface IEnumerable with
        member i.GetEnumerator() = new Iterator<'a>(node):> IEnumerator

let tr = new Tree()
tr.Add(5)
tr.Add(6)
tr.Add(7)
tr.Add(8)
for i in tr do
    printfn "%A" i
