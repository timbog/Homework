﻿let func x l = List.map (fun y -> y * x) l

let func1 x: (int) list -> (int) list = List.map (fun y -> y * x)