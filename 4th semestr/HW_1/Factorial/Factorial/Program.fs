// Дополнительные сведения о F# см. на http://fsharp.net
// Дополнительную справку см. в проекте "Учебник по F#".
let rec fac n =
    if n < 2 then 1
    else n * fac(n - 1)
[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    let x = System.Int32.Parse(System.Console.ReadLine());
    System.Console.WriteLine(fac x);
    0 // возвращение целочисленного кода выхода
