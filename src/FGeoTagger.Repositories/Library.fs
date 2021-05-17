namespace FGeoTagger.Repositories
open Npgsql.FSharp
open FGeoTagger.Models


module Repository =
    open Rooms

    let getAllRooms (connectionString: string) : Rooms list =
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
