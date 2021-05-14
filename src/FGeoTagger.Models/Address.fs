namespace FGeoTagger.Models

module Address =
    open GeoObject

    type Address = { 
        Country: string; 
        State: string option; 
        City: GeoObject; 
        Street: GeoObject; 
        House: GeoObject; 
        Block: GeoObject option; 
        Room: GeoObject option
        }