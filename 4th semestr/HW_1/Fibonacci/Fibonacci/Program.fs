// Дополнительные сведения о F# см. на http://fsharp.net
// Дополнительную справку см. в проекте "Учебник по F#".
let rec fib n =
    if n = 1 then 0
    else if n = 2 then 1
    else fib(n - 1) + fib(n - 2)
[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    let x = System.Int32.Parse(System.Console.ReadLine());
    System.Console.WriteLine(fib x);
    0 // возвращение целочисленного кода выхода
