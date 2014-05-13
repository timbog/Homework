let array = [| for i in 1 .. 1000000 -> i |]

let sumOfArray = 
        let threadArray = [| for i in 1 .. 100 ->  new  System.ComponentModel.BackgroundWorker()|]
        let result = ref 0
        for i in 0..99 do
            threadArray.[i].DoWork.Add(fun args ->
                let array2 = Array.filter(fun x -> (x > 10000 * i) && (x <= 10000 * (i + 1))) array
                let res = Array.sum array2
                args.Result <- box res)
            threadArray.[i].RunWorkerCompleted.Add(fun args ->
                result := !result +  unbox args.Result)
        for i in 0..99 do
            threadArray.[i].RunWorkerAsync()
        result.Value

printfn "%A" (sumOfArray)

