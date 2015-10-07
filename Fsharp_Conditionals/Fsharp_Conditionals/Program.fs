open System

let checksum v = 
    if v = 5 then "I am 5"
    elif v < 5 then "I am less than 5"
    else " I am another number"

let checksum2 t = 
    if t = 5 || t > 7 then "valid check"
    
    else "not in range"


[<EntryPoint>]
let main argv = 
    let check = Console.ReadLine()
    let check = int check
    printfn "%A" (checksum check)
    Console.ReadKey()
    0 // return an integer exit code
