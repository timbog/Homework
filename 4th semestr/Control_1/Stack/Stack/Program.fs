type Stack() = //Stack
    let mutable list = []
    member s.Push(value) = list<-(value::list)
    member s.Pop = match list with
                    |[] -> failwith "Empty Stack"
                    |_->
                        let temp = list.Head
                        list<-list.Tail;
                        temp
    member s.isEmpty() = list.IsEmpty

let stack = new Stack()
stack.Push(5)
stack.Push(6)
let y = stack.Pop
let u = stack.isEmpty()
printfn"%A" u
