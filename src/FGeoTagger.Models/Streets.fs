namespace FGeoTagger.Models
open System

module Streets =
    open GeoObject

    type Streets = {
        Id: Guid;
        Street: GeoObject;
    }
