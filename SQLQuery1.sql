CREATE TABLE [dbo].[CarImages] (
    [ImageId]   INT             IDENTITY (1, 1) NOT NULL,
    [CarId]     INT             NULL,
    [ImagePath] NVARCHAR (1000) NULL,
    [ImageDate] DATETIME        NULL,
    PRIMARY KEY CLUSTERED ([ImageId] ASC)
);
