type Network() = 
    let linkMatrix = Array2D.init 3 3 (fun i j -> (i + j) % 2)
    let systemMatrix = [|"Windows"; "MacOS"; "Linux"|]
    let virusMatrix = Array.init (linkMatrix.GetLength(0)) (fun i -> (i % 2) = 1)
    member n.OneMove() = //one move of infection
        let newInfection = Array.init (linkMatrix.GetLength(0)) (fun x -> false)
        let infect value iterator =
            match value with
              |true-> virusMatrix.[iterator] <- true
                      newInfection.[iterator] <- true
              |false->virusMatrix.[iterator] <- false
        for i in 0..linkMatrix.GetLength(0) - 1 do           
            for j in 0..linkMatrix.GetLength(0) - 1 do
                if ((linkMatrix.[i, j] = 1) && (virusMatrix.[j])) && not ((virusMatrix.[i]) && not (newInfection.[j])) then
                    let random = (new System.Random()).Next(0, 1000)
                    match systemMatrix.[i] with
                    |"Windows" -> infect ((random % 5 = 1) || (random % 5 = 0)) i
                    |"Linux" -> infect (random % 5 = 3) i
                    |"MacOS" -> infect ((random % 5 = 1) || (random % 5 = 0) || (random % 5 = 3)) i
                    |_-> failwith "No such system"
                    if (virusMatrix.[i]) then
                        newInfection.[i] <- true

    member n.AllInfected() = Array.forall (fun x -> (x = true)) (virusMatrix)
    member n.ConnectionMatrix = linkMatrix
    member n.OsMatrix = systemMatrix
    member n.DisMatrix = virusMatrix

let network = new Network()
let rec State() = //function which returns state of network
            let rec printRes iterator =
                match (iterator < network.DisMatrix.Length) with
                    |true ->
                             let state = (network .DisMatrix.[iterator].ToString())
                             printfn "%s" (network.OsMatrix.[iterator] + "-" + state)
                             network.OneMove()|> ignore
                             printRes (iterator + 1)
                    |false -> printfn "%s" "------"
            printRes 0

let rec work() = // work of network
    match network.AllInfected() with
        |true-> printfn "All computers are infected"
        |false->
            let z = Async.Sleep(500)
            let y = State()
            work()            
let temp = work()

                        





