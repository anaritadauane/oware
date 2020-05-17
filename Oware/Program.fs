module Oware

open System.IO
open System.Xml.Linq
open System.Xml.Linq

type StartingPosition =
    | South
    | North



type Board = {
   Houses: int list 
   State : string 
   Score : int * int 

    
}


let getSeeds n board = List.item(n-1) board.Houses 

let updateSeeds n board = 
  let spaces = List.init 12 (fun i -> 
                                      match i = n - 1 with 
                                      | true -> 0
                                      | false -> getSeeds i board) // to make the house equal to 0 seeds 
  
  match getSeeds n board > 0 with 
  | true -> None 
  | false -> Some (getSeeds n board, {board with Houses = spaces})



let useHouse n board =  failwith "Not implemented"
                      
                      
                     
let start position = 
                    match position with 
                    | South -> {Houses = [4;4;4;4;4;4;4;4;4;4;4;4]; State = "Starting"; Score = (0,0)}
                    | _ -> {Houses = [4;4;4;4;4;4;4;4;4;4;4;4]; State = "Starting"; Score = (0,0)}

let score board = failwith "Not implemented"
                 

let gameState board = 


    let southScore,northScore = board.Score

    match southScore = 24 && northScore = 24 with 
    | true -> "Game ended in a draw"
    | false -> match southScore > 24 && northScore < 24 with 
               | true -> "South won"
               | false -> "North won"


[<EntryPoint>] 
let main _ =0 // return an integer exit code
    