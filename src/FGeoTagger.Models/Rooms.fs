namespace FGeoTagger.Models
open System

module Rooms =
    open GeoType

    type Rooms = {
        Id: Guid;
        Room: GeoType;
        Default: bool
    }