// See the file wonderland-number.md for detailed information.

let wonderlandNumber () = 123456

let haveSameDigits (n1:int,n2:int) =
    (string n1 |> Set.ofSeq) = (string n2 |> Set.ofSeq)

//#r @"../packages/Unquote/lib/net45/Unquote.dll"
//open Swensen.Unquote

let tests (wonderNum:int) =

    (string wonderNum).Length = 6 &&

    haveSameDigits (wonderNum, 2 * wonderNum) &&
    haveSameDigits (wonderNum, 3 * wonderNum) &&
    haveSameDigits (wonderNum, 4 * wonderNum) &&
    haveSameDigits (wonderNum, 5 * wonderNum) &&
    haveSameDigits (wonderNum, 6 * wonderNum)

// run the tests
// tests ()


let bruteforce (fromVal:int, toVal:int) =
    let testvalues = seq {fromVal .. toVal}
    testvalues |> Seq.filter tests
   
bruteforce(100000, 999999/6)