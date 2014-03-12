type Tree<'a> = 
    |Tree of 'a *Tree<'a> *Tree<'a>
    |Tip of 'a
let rec height tree =
    match tree with
    |Tree(_,l,r) when (height l >= height r)-> (height l ) + 1
    |Tree(_,l,r) when (height l <= height r)-> (height r) + 1
    |Tip _-> 1