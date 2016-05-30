CREATE TABLE [dbo].[statue]
 (
    
	[TilføjNote]   Varchar(MAX)  NOT NULL,
	[Info]   Varchar(MAX)  NOT NULL,
	[MaterialeOgType]   Varchar(MAX)  NOT NULL,
	[Placering]   Varchar(MAX)  NOT NULL,
	[Navn]   INT  NOT NULL,
    [Note]   INT  NOT NULL,
    [SkulpturID]   INT  NOT NULL,
    [IndsætBillede]   INT  NOT NULL,
	[KritiskTidspunkt]   INT  NOT NULL,
	[BehandlingsForslag]   INT  NOT NULL,
	[SidstSet]   INT  NOT NULL,
	[FirmaNavn]   INT  NOT NULL,
	[Pris]   INT  NOT NULL,
	[SkadeKategori]   INT  NOT NULL,
	[BilledeAfSkade]   INT  NOT NULL,
	[PrintSkulptur] INT NOT NULL,


    PRIMARY KEY CLUSTERED ([SkulpturID] ASC),
    
);

Create Table [dbo].[Materiale] 
( 
[SkadeKatagori] BIT not null,
[Algeskade] BIT not null,
[Ridset] BIT not null,
[Haervaerk] BIT not null,
[Misfarvninger] BIT not null,
[RUST] BIT not null,
[SkadeKategori] BIT Primary Key Clustered ([SkadeKategori] ASC)
);

Create Table [dbo].[Materialer]
(
[Materiale] BIT not null,
[Beton] BIT not null,
[Marmor] BIT not null,
[Jern] BIT not null,
[Kobber] BIT not null,
[Guld] BIT not null,
[Soelv] BIT not null,
[Bronze] BIT not null,
[Porcelean] BIT not null,
[Granit] BIT not null,
[Sten] BIT not null,
[Is] BIT not null,
[Træ] BIT not null,
[Zink] BIT not null,
[Elfenben] BIT not null,
[Gallium] BIT not null,
[Aluminium] BIT not null,
[Plastic] BIT not null,
[Ler] BIT not null,
[Messing] BIT not null,
[Diamant] BIT not null,
[Platinium] BIT not null,
[Bly] BIT not null,
[Tin] BIT not null,
[Nikkel] BIT not null,
[Chrom] BIT not null,
[Carbon] BIT not null,
[Titanium] BIT not null,
[Kalk] BIT not null,
[Staal] BIT not null,
[Materialer] BIT Primary Key Clustered ([Materialer] ASC)
);