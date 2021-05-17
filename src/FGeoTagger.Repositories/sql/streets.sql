DROP TABLE public.streets;

CREATE TABLE public.streets
(
    id uuid NOT NULL,
    street_type_name text NOT NULL,
    street_type_reduction text,
    street_name text NOT NULL,
    street_prefix boolean NOT NULL,
    PRIMARY KEY (id)
);

ALTER TABLE public.streets
    OWNER to geotagger;
