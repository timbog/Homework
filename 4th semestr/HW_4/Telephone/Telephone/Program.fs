open System.IO
type TelephoneBook (nameList:List<string>, telList:List<int>) =
    member t.exit = printfn "Goodbye"
    member t.add(name, tel) = TelephoneBook(name::nameList, tel::telList)
    member t.findName(tel) =
        let equalCheck temp = (temp = tel)
        List.findIndex (equalCheck) nameList
    member t.findTel(name) =
        let equalCheck temp = (temp = name)
        nameList.Item(List.findIndex (equalCheck) telList)
    member t.Write() =
        use writer = new StreamWriter("input.txt")
        writer.Write nameList
        writer.Write telList

let telBook = new TelephoneBook([], [])
let bk = telBook.add("huisas", 52)
let temp = bk.Write


let x = System.IO.File.Create("d:\Users\Boss\Documents\GitHub\Homework\4th semestr\HW_4\Telephone")
    (*member t.Read() =
        let str  = File.ReadLines("input.txt")
        let build str1 numflag =
            for temp in str do
                match temp with 
                    |x when (x.GetHashCode() < -842352745) && (x.GetHashCode() > -842352753) -> x::str
                    |x when x = ' ' -> *)

