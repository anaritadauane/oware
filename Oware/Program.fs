module Oware

type StartingPosition =
    | South
    | North

let getSeeds n board = List.item(n-1) board


let useHouse n board =  
  let _ = getSeeds n board
                      //let num = getSeeds n board 
                      
                      
                        




let start position = 
                    match position with 
                    | South -> [4;4;4;4;4;4;4;4;4;4;4;4]
                    | _ -> [4;4;4;4;4;4;4;4;4;4;4;4] 

let score board = failwith "Not implemented"

let gameState board = failwith "Not implemented"

[<EntryPoint>]
let main _ = 0 // return an integer exit code
    