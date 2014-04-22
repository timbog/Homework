open System.IO
let fst temp =
    match temp with
        |[a,b] -> a
        |_-> failwith "Incorrect"
let scd temp =
    match temp with
        |[a,b] -> b
        |_-> failwith "Incorrect"
let readFromFile =
            let fileChecker() =         
                match (File.Exists("input.txt")) with
                    |false -> failwith "No such file"                                           
                    |true -> null
            let temp = fileChecker()
            let strArray = File.ReadAllLines("input.txt")
            let rec buildTelBook list1 list2 iter =
                match (iter <= strArray.Length - 1) with
                    |true ->
                            let t  = strArray.[iter].Split(' ')                          
                            buildTelBook ((int t.[1])::list1) (t.[0]::list2) (iter + 1)
                    |false -> [list1, list2]                                                  
            let temp1 = buildTelBook [] [] 0
            temp1
                        
let rec tel (telList:List<int>) (nameList:List<string>) = //telephone function
    match (System.Console.ReadLine())  with
        |temp when temp = "0" -> printfn "Thanks for using, good luck"
        |temp when temp = "1" -> 
            printfn "Enter name"
            let name = System.Console.ReadLine()
            printfn "Enter telephone number"
            let telNumber = int (System.Console.ReadLine())
            printfn "Information saved. Press number of command"
            tel (telNumber::telList) (name::nameList)
        |temp when temp = "2" -> 
            printfn "Enter name: "
            let name = System.Console.ReadLine()
            let equalCheck temp = (temp = name)
            let numX =
                try
                    (List.findIndex (equalCheck) nameList)
                with
                    | :?  System.Collections.Generic.KeyNotFoundException -> 
                                                                                printfn "Doen't exist"
                                                                                -1
            if (numX <> -1) then
                printfn "%A" (telList.Item(numX))
            printfn "Press number of command"
            tel (telList) (nameList)
        |temp when temp = "3" ->
            printfn "Enter telephone: "
            let telNumber = int (System.Console.ReadLine())
            let equalCheck temp = (temp = telNumber)
            let nameX =
                try
                    List.findIndex (equalCheck) telList
                with
                    | :?  System.Collections.Generic.KeyNotFoundException ->
                                                                              printfn "Doen't exist"
                                                                              -1
            if (nameX <> -1) then                                                                             
                printfn "%A" (nameList.Item(nameX))
            printfn "Press number of command"
            tel (telList) (nameList)
        |temp when temp = "4" ->
            let nameList2 = List.filter(fun (x) -> (List.tryFind(fun y -> y = x)  (scd(readFromFile))) = None) nameList
            let telList2 = List.filter(fun (x) -> (List.tryFind(fun y -> y = x)  (fst(readFromFile))) = None) telList
            List.iter2 (fun x y -> File.AppendAllText ("input.txt", x + " " + y.ToString() + "\n")) nameList2 telList2
            printfn "Writing to file completed"
            printfn "Press number of command"
            tel (telList) (nameList)
        |temp when temp = "5" ->
            printfn "Reading from file: "  
            printfn "Completed"
            printfn "Press number of command"
            tel (fst(readFromFile) @ telList) (scd(readFromFile) @ nameList)
        |_ ->
            printfn "Incorrect command"
            printfn "Press number of correct command"
            tel (telList) (nameList)

printfn "Hello. Press 0 to exit, 1 to add something to directory, 2,3 - to find telephone/name by name/telephone, 4 to write to file, 5 to read from file. Have fun!"
let temp = tel (fst(readFromFile)) (scd(readFromFile))





                                
