open System

let checkvalue (argv : string []) : int =
    if argv.Length > 0 then      
        let couldparse, consolein = Int32.TryParse(argv.[0])
        if couldparse then consolein
        else
            let canparse, keyin = Int32.TryParse(Console.ReadLine())
            if canparse then keyin
            else 0
    else
        let canparse, keyin = Int32.TryParse(Console.ReadLine())
        if canparse then keyin
        else 0

let fibonacci n =
    let mutable first = 0
    let mutable second = 1
    let mutable temp = 0
    for index = 1 to n do
        temp <- first + second
        first <- second
        second <- temp
    first

let rec fibonaccirecursive n =
    if n <= 2 then 1
        elif n = 0 then 0
        else
            fibonaccirecursive (n - 1) + fibonaccirecursive (n - 2)

[<EntryPoint>]
let main argv =
    let input = checkvalue argv
//    let calc = fibonacci input
    let calc2 = fibonaccirecursive input
//    Console.WriteLine(calc)
    Console.WriteLine(calc2)
    Console.ReadKey()
    0 // return an integer exit code
