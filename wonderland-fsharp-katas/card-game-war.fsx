// See the file card-game.md for detailed information.

// feel free to use these cards or use your own data structure

type Suit =
    | Spade
    | Club
    | Diamond
    | Heart

type Rank =
    | Value of int
    | Jack
    | Queen
    | King
    | Ace

let getRankValue (r:Rank) = 
    match r with
    | Value v -> v
    | Jack -> 11
    | Queen -> 12
    | King -> 13
    | Ace -> 14

let compareRank(rA:Rank,rB:Rank) =
    if getRankValue rA > getRankValue rB then 
        rA
    else 
        rB




type Card = Suit * Rank

let playRound (card1:Card,card2:Card) =
    failwith "not implemented: winning card"

let playGame (hand1:Card list, hand2:Card list) =
    failwith "not implemented: game winner"

(*
let suits = [ Spade; Club; Diamond; Heart ]
let heads = [ Jack; Queen; King; Ace ]

let ranks =
    [   for v in 2 .. 10 -> Value v
        for head in heads -> head
    ]

let deck = seq {
    for suit in suits do
        for rank in ranks -> suit,rank }
*)



// fill in tests for your game
let tests () =

    // playRound
    printfn "TODO: the highest rank wins the cards in the round"
    let winningCard (cardA:Card, cardB:Card) =
        let (sA,rA) = cardA
        let (sB,rB) = cardB
        compareRank(rA, rB)
        match rA, rB with
        | a,b when a > b ->
            cardA
        | a,b when a < b ->
            cardB
        | _ ->
            match sA,sB with
            | (Spade, _) ->
                cardB
            | (_, Heart) ->
                cardB
            | (Diamond, Club) ->
                cardA
            | (Club, Diamond) ->
                cardB
            | (_, Spade) ->
                cardA
            | (Heart, _) ->
                cardA
            | (Diamond, Diamond) 
            | (Club, Club) 
            | (Spade, Spade)
            | (Heart, Heart) ->
                failwith "madness, someone's cheating!"

            


    printfn "TODO: queens are higher rank than jacks"
    printfn "TODO: kings are higher rank than queens"
    printfn "TODO: aces are higher rank than kings"
    printfn "TODO: if the ranks are equal, clubs beat spades"
    printfn "TODO: if the ranks are equal, diamonds beat clubs"
    printfn "TODO: if the ranks are equal, hearts beat diamonds"

    // playGame
    printfn "TODO: the player loses when they run out of cards"

// run the tests
tests ()
