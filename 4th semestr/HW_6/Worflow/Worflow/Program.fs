﻿type Rounding(accuracy : int) =
    member this.Bind ((x : float), (rest : float -> float)) = System.Math.Round(rest x , accuracy)
    member this.Return (x : float) = System.Math.Round(x, accuracy)

let result = Rounding 3 {
        let! a = 2.0 / 12.0
        let! b = 3.5
        return a / b
    }
printfn "%A" result
