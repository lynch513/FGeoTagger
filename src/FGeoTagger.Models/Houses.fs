namespace FGeoTagger.Models
open System

module Houses =
    open GeoType

    type Houses = {
        Id: Guid;
        House: GeoType;
        Default: bool
    }
