namespace FGeoTagger.Repositories
open Npgsql.FSharp

module Rooms =
    open FGeoTagger.Models.Rooms

    let getAllRooms (connectionString: string) () : Rooms list = 
        connectionString
        |> Sql.connect
        |> Sql.query "SELECT * FROM rooms"
        |> Sql.execute (fun read -> 
            {
                Id = read.uuid "id"
                Room = { 
                    Name = read.text "room_name"
                    Reduction = read.textOrNone "room_reduction"
                }
                Default = read.bool "default"
            })

    let numberOfRooms (connectionString: string) () =
        connectionString
        |> Sql.connect
        |> Sql.query "SELECT COUNT(*) as rooms_count FROM rooms"
        |> Sql.executeRow (fun read -> read.int64 "rooms_count")

