namespace FGeoTagger.Models
open System

module Cities =
    open GeoObject

    type Cities = {
        Id: Guid;
        City: GeoObject;
        Default: bool
        }
