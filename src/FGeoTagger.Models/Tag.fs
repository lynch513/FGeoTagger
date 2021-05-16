namespace FGeoTagger.Models
open System

module Tag =
    open Address 
    open GeoCoord

    type Tag = {
        Id: Guid;
        Name: string;
        Subtitle: string option;
        Description: string option;
        Address: Address;
        Coord: GeoCoord;
        Created: DateTime;
        Updated: DateTime;
        }