CREATE TABLE [dbo].[Family_Profile]
(
	[StudentId] INT NULL,
	CONSTRAINT [FK_IDStudent] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Personal_Info] ([IdNumber]), 
    
)
