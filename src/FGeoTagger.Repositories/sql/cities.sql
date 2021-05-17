DROP TABLE public.cities;

CREATE TABLE public.cities
(
    id uuid NOT NULL,
    city_type_name text NOT NULL,
    city_type_reduction text,
    city_name text NOT NULL,
    city_prefix boolean NOT NULL,
    "default" boolean NOT NULL,
    PRIMARY KEY (id)
);

ALTER TABLE public.cities
    OWNER to geotagger;
