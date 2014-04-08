type HashTable(hashFunction:string->int) = //HashTable
    let array : string array = Array.zeroCreate 40
    member h.Add(str:string) = array.[hashFunction str] <- str
    member h.Find(str:string) = match array.[hashFunction str] with
                                    |"" -> false
                                    |_-> true
    member h.Delete(str:string) = array.[hashFunction str]<-""

let hash1 (str:string) = 
    let rec hash iter result =
        match iter with
            |temp when (temp < str.Length) -> hash (iter + 1) (result + str.[iter].GetHashCode())
            |_ -> result
    (hash 0 0) % (str.Length)

let hashTable = new HashTable(hash1)
let y = hashTable.Add "hello"
let result1 = hashTable.Find "hello"
printfn "Result is:%A" result1
let z = hashTable.Delete "hello"
let result2 = hashTable.Find "hello"
printfn "Result is:%A" result2