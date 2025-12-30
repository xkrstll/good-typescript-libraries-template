CREATE TABLE [dbo].[AccountTbl] (
    [Accnum]     VARCHAR (50) NOT NULL,
    [Name]       VARCHAR (10) NOT NULL,
    [FaName]     VARCHAR (50) NOT NULL,
    [Dob]        VARCHAR (50) NOT NULL,
    [Phone]      VARCHAR (15) NOT NULL,
    [Address]    VARCHAR (30) NOT NULL,
    [Education]  VARCHAR (20) NOT NULL,
    [Occupation] VARCHAR (50) NOT NULL,
    [Pin]        INT          NOT NULL,
    [Balance]    INT          NOT NULL DEFAULT 90,
    PRIMARY KEY CLUSTERED ([Accnum] ASC)
);

