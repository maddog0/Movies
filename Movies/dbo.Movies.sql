CREATE TABLE [dbo].[Movies] (
    [Movie Title] NVARCHAR (100) NOT NULL,
    [Lengh(min)]  NVARCHAR(5)            NULL,
    [Director]    NVARCHAR (100) NULL,
    [year]        NCHAR (4)      NULL,
    [genre]       NVARCHAR (20)  NULL,
    PRIMARY KEY CLUSTERED ([Movie Title] ASC)
);

