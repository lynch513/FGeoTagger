namespace FGeoTagger.Models

module GeoObject =
    open GeoType

    type GeoObject = {
        Type: GeoType;
        Name: string;
        Prefix: bool option;
        } 