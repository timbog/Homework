﻿printfn "Press x to stop adding values to list"

let rec buildList list = //function which builds list
    let input = System.Console.ReadLine() 
    match input with
        | "x" -> list
        | _ -> int (input) :: buildList list

let oldList = buildList []

let buildNewList list = //function which builds new list
    let rec back list newList =
        match list with
            |(h::t) -> back t (h::newList)
            |[] -> newList
    back list []

let output = buildNewList oldList
printfn "Circulated List :%A" output
