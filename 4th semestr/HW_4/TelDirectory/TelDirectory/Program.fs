open System.IO
let rec tel (telList:List<int>) (nameList:List<string>) = //telephone function
    match int (System.Console.ReadLine())  with
        |0 -> printfn "Thanks for using, good luck"
        |1 -> 
            printfn "Enter name"
            let name = System.Console.ReadLine()
            printfn "Enter telephone number"
            let telNumber = int (System.Console.ReadLine())
            printfn "Information saved. Press number of command"
            tel (telNumber::telList) (name::nameList)
        |2 -> 
            printfn "Enter name: "
            let name = System.Console.ReadLine()
            let equalCheck temp = (temp = name)
            let numX = List.findIndex (equalCheck) nameList
            printfn "%A" (telList.Item(numX))
            printfn "Press number of command"
            tel (telList) (nameList)
        |3 ->
            printfn "Enter telephone: "
            let telNumber = int (System.Console.ReadLine())
            let equalCheck temp = (temp = telNumber)
            let nameX = List.findIndex (equalCheck) telList
            printfn "%A" (nameList.Item(nameX))
            printfn "Press number of command"
            tel (telList) (nameList)
        |4 ->
            List.iter2 (fun x y -> File.AppendAllText ("input.txt", x + " " + y.ToString() + "\n")) nameList telList
            printfn "Writing to file completed"
            printfn "Press number of command"
            tel (telList) (nameList)
        |5 ->
            printfn "Reading from file: "  
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
            let fst() =
                match temp1 with
                    |[a,b] -> a
                    |_-> failwith "Incorrect"
            let scd() =
                match temp1 with
                    |[a,b] -> b
                    |_-> failwith "Incorrect"
            printfn "Press number of command"
            tel (fst() @ telList) (scd() @ nameList)
        |_ ->
            printfn "Incorrect command"
            printfn "Press number of correct command"
            tel (telList) (nameList)

printfn "Hello. Press 0 to exit, 1 to add something to directory, 2,3 - to find telephone/name by name/telephone, 4 to write to file, 5 to read from file. Have fun!"
let temp = tel [] []





                                
