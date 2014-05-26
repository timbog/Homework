let array = [| for i in 1 .. 1000000 -> 1 |]
let sumOfArray = 
        let threadArray = [| for i in 1 .. 100 ->  new  System.ComponentModel.BackgroundWorker()|]
        let result = ref 0
        for i in 0..99 do
            threadArray.[i].DoWork.Add(fun args -> 
                let res = Array.sum (Array.sub array i 10000)       
                args.Result <- box res)
            threadArray.[i].RunWorkerCompleted.Add(fun args ->
                result := !result +  unbox args.Result)
        for i in 0..99 do
            threadArray.[i].RunWorkerAsync()
        result.Value

printfn "%A" (sumOfArray)

