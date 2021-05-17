open System
open Npgsql.FSharp
open Microsoft.Extensions.Configuration
open System.Reflection

open FGeoTagger.Repositories

module Program =

    module DbSettings =
        let config = (new ConfigurationBuilder ())
                        .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                        .AddJsonFile("appsettings.json")
                        .AddUserSecrets("6f2cfbaf-b2e4-4140-9565-580a81aa6a91")
                        .Build()
        let connectionString : string =
            Sql.host config.["ConnectionString:host"]
            |> Sql.database config.["ConnectionString:database"]
            |> Sql.username config.["ConnectionString:Username"]
            |> Sql.password config.["ConnectionString:Password"] 
            |> Sql.port (int config.["ConnectionString:port"])
            |> Sql.formatConnectionString


    [<EntryPoint>]
    let main argv =
        let rooms = Repository.getAllRooms DbSettings.connectionString
        printfn "Rooms:\n%s" (string rooms)
        0 // return an integer exit code