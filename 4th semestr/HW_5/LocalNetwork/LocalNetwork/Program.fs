type Network() = 
    let LinkMatrix = Array2D.init 3 3 (fun i j -> (i + j) % 2)
    let SystemMatrix = [|"Windows"; "MacOS"; "Linux"|]
    let VirusMatrix = Array.init (LinkMatrix.GetLength(0)) (fun i -> (i % 2) = 1)
    member n.OneMove() =
        let newInfection = Array.init (LinkMatrix.GetLength(0)) (fun x -> false)
        for i in 0..LinkMatrix.GetLength(0) - 1 do           
            for j in 0..LinkMatrix.GetLength(0) - 1 do
                if ((LinkMatrix.[i, j] = 1) && (VirusMatrix.[j])) && not ((VirusMatrix.[i]) && not (newInfection.[j])) then
                    let random = (new System.Random()).Next(0, 1000)
                    match SystemMatrix.[i] with
                    |"Windows" -> match ((random % 5 = 1) || (random % 5 = 0)) with
                                  |true-> VirusMatrix.[i] <- true
                                          newInfection.[i] <- true
                                  |false->VirusMatrix.[i] <- false
                    |"Linux" -> match (random % 5 = 3) with
                                  |true-> VirusMatrix.[i] <- true
                                          newInfection.[i] <- true
                                  |false -> VirusMatrix.[i] <- false
                    |"MacOS" -> match ((random % 5 = 1) || (random % 5 = 0) || (random % 5 = 3)) with
                                  |true-> VirusMatrix.[i] <- true
                                          newInfection.[i] <- true
                                  |false -> VirusMatrix.[i] <- false
                    |_-> failwith "No such system"
                    if (VirusMatrix.[i]) then
                        newInfection.[i] <- true
    member n.GetState() =
        let y = n.OneMove()
        VirusMatrix

    member n.AllInfected() =
        let rec check iterator =
            match (VirusMatrix.[iterator]) with
                |true when (iterator < VirusMatrix.Length - 1)-> check (iterator + 1)
                |true when (iterator = VirusMatrix.Length - 1)-> true
                |_->false
        check 0
    member n.ConnectionMatrix = LinkMatrix
    member n.OsMatrix = SystemMatrix
    member n.DisMatrix = VirusMatrix

let network = new Network()
let rec State()=
            let rec printRes iterator =
                match (iterator < network.DisMatrix.Length) with
                    |true ->
                             let state = (network .DisMatrix.[iterator].ToString())
                             printfn "%s" (network.OsMatrix.[iterator] + "-" + state)
                             let x = network.GetState()
                             printRes (iterator + 1)
                    |false -> printfn "%s" "------"
            printRes 0

let rec work() =
    match network.AllInfected() with
        |true-> printfn "All computers are infected"
        |false->
            let z = Async.Sleep(500)
            let y = State()
            work()            
let temp = work()

                        





