namespace FGeoTagger.Models
open System

module Blocks =
    open GeoType

    type Blocks = {
        Id: Guid;
        Block: GeoType;
        Default: bool
        }
