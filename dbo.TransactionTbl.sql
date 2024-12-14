CREATE TABLE [dbo].[TransactionTbl] (
    [Tid]    INT          IDENTITY (1, 1) NOT NULL,
    [AccNum] VARCHAR (50) NOT NULL,
    [Type]   VARCHAR (20) NOT NULL,
    [Amount] VARCHAR(50)          NOT NULL,
    [TDate]  VARCHAR(50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Tid] ASC)
);

