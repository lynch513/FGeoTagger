-- DROP TABLE public.tags;

CREATE TABLE public.tags
(
    id uuid NOT NULL,
    name text COLLATE pg_catalog."default" NOT NULL,
    subtitle text COLLATE pg_catalog."default",
    description text COLLATE pg_catalog."default",
    address_country text COLLATE pg_catalog."default" NOT NULL,
    address_state text COLLATE pg_catalog."default",
    address_city_type_name text COLLATE pg_catalog."default" NOT NULL,
    address_city_type_reduction text COLLATE pg_catalog."default",
    address_city_name text COLLATE pg_catalog."default" NOT NULL,
    address_city_prefix boolean NOT NULL,
    address_street_type_name text COLLATE pg_catalog."default" NOT NULL,
    address_street_type_reduction text COLLATE pg_catalog."default",
    address_street_name text COLLATE pg_catalog."default" NOT NULL,
    address_street_prefix boolean NOT NULL,
    address_house_type_name text COLLATE pg_catalog."default" NOT NULL,
    address_house_type_reduction text COLLATE pg_catalog."default",
    address_house_name text COLLATE pg_catalog."default" NOT NULL,
    address_block_type_name text COLLATE pg_catalog."default",
    address_block_type_reduction text COLLATE pg_catalog."default",
    address_block_name text COLLATE pg_catalog."default",
    address_room_type_name text COLLATE pg_catalog."default",
    address_room_type_reduction text COLLATE pg_catalog."default",
    address_room_name text COLLATE pg_catalog."default",
    created timestamp without time zone NOT NULL,
    updated timestamp without time zone NOT NULL,
    coord_latitude double precision NOT NULL,
    coord_longitude double precision NOT NULL,
    CONSTRAINT tags_pkey PRIMARY KEY (id)
)

TABLESPACE pg_default;

ALTER TABLE public.tags
    OWNER to geotagger;
