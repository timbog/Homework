type Network (osMatrix:List<string>, virusMatrix:List<bool>, probabilityMatrix:List<int>) = 
    let LinkMatrix = Array2D.init 3 3 (fun i j -> (i + j + 1) % 2)
    let SystemMatrix = osMatrix
    let VirusMatrix = virusMatrix
    let ProbabilityMatrix = probabilityMatrix
    member n.OneMove() =
        let newInfection = Array.init (LinkMatrix.GetLength(0)) (fun x -> false)
        for i in 0..LinkMatrix.GetLength(0) do           
            for j in 0..LinkMatrix.GetLength(0) do
                if ((LinkMatrix.[i, j] = 1) && (VirusMatrix.Item(j)) && not (VirusMatrix.Item(i)) && not (newInfection.[i])) then
                    let random = (new System.Random()).Next(0, 1000)
                    match SystemMatrix.Item(i) with
                    |"Windows" -> match ((random % 5 == 1) || (random % 5 == 0)) with
                                  |true-> VirusMatrix.Item(i) <- true
                                  |false->VirusMatrix[i] <- false
                    |"Linux" -> match (random % 5 == 3) with
                                  |true-> VirusMatrix[i] <- true
                                  |false->n.VirusMatrix[i] <- false
                    |"MacOS" -> match ((random % 5 == 1) || (random % 5 == 0) || (random % 5 == 3)) with
                                  |true-> VirusMatrix[i] <- true
                                  |false->VirusMatrix[i] <- false
                    if (VirusMatrix[i]) then
                        newInfection[i] = true

