type Tree<'a> = //tree
    | Tree of 'a * Tree<'a> * Tree<'a>
    | Tip of 'a

let rec map(change:'a -> 'a) tree = //treeMap
    match tree with
        |Tree.Tree(temp, tree1, tree2) -> Tree.Tree(change temp, map change tree1, map change tree2)
        |Tree.Tip(temp) -> Tree.Tip(change temp)


