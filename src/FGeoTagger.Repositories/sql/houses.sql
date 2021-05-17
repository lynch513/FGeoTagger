DROP TABLE public.houses;

CREATE TABLE public.houses
(
    id uuid NOT NULL,
    house_name text NOT NULL,
    house_reduction text,
    "default" boolean NOT NULL,
    PRIMARY KEY (id)
);

ALTER TABLE public.houses
    OWNER to geotagger;
