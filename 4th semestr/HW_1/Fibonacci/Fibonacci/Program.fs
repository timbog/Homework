// Дополнительные сведения о F# см. на http://fsharp.net
// Дополнительную справку см. в проекте "Учебник по F#".
let rec fib n =
    if n = 1 then 1
    else if n = 2 then 2
    else fib(n - 1) + fib(n - 2)
[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    let x = System.Console.Read() - 48;
    System.Console.WriteLine(fib 4);
    0 // возвращение целочисленного кода выхода
