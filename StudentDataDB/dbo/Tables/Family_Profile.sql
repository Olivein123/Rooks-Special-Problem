CREATE TABLE [dbo].[Family_Profile]
(
	[StudentId] INT NOT NULL,

	[MotherOccupation] VARCHAR(MAX) NOT NULL, 
    [FatherOccupation] VARCHAR(MAX) NOT NULL, 
    [TotalIncome] VARCHAR(MAX) NOT NULL, 
    [TotalSiblings] INT NOT NULL, 
    [ParentDependentSiblings] INT NOT NULL, 
    [GraduatedSiblings] INT NOT NULL, 
    CONSTRAINT [FK_IDStudent] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Personal_Info] ([StudentId]), 
    
)
