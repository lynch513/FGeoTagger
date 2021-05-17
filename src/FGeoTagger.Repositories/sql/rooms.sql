DROP TABLE public.rooms;

CREATE TABLE public.rooms
(
    id uuid NOT NULL,
    room_name text NOT NULL,
    room_reduction text,
    "default" boolean NOT NULL,
    PRIMARY KEY (id)
);

ALTER TABLE public.rooms
    OWNER to geotagger;
