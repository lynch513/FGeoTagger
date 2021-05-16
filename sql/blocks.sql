DROP TABLE public.blocks;

CREATE TABLE public.blocks
(
    id uuid NOT NULL,
    block_name text NOT NULL,
    block_reduction text,
    "default" boolean NOT NULL,
    PRIMARY KEY (id)
);

ALTER TABLE public.blocks
    OWNER to geotagger;
