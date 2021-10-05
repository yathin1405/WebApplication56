CREATE TABLE [dbo].[RegisterAllViewModels] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [AccountType]     NVARCHAR (MAX) NOT NULL,
    [FName]           NVARCHAR (35)  NOT NULL,
    [MName]           NVARCHAR (35)  NULL,
    [LName]           NVARCHAR (35)  NOT NULL,
    [IdentityNumber]  NVARCHAR (13)  NOT NULL,
    [Gender]          NVARCHAR (MAX) NOT NULL,
    [Email]           NVARCHAR (MAX) NOT NULL,
    [Password]        NVARCHAR (100) NOT NULL,
    [ConfirmPassword] NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_dbo.RegisterAllViewModels] PRIMARY KEY CLUSTERED ([Id] ASC)
);

