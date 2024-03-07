CREATE TABLE [dbo].[Personal_Info]
(
	[StudentId] INT NOT NULL PRIMARY KEY, 
    [LastName] VARCHAR(MAX) NOT NULL, 
    [FirstName] VARCHAR(MAX) NOT NULL, 
    [MiddleName] VARCHAR(MAX) NULL, 
    [Address] VARCHAR(MAX) NOT NULL, 
    [FundSource] VARCHAR(MAX) NOT NULL, 
    [FundSourceType] VARCHAR(MAX) NOT NULL, 
    [Job] VARCHAR(MAX) NOT NULL, 
    [SalaryEnough] VARCHAR(MAX) NOT NULL, 
    [SalaryRange] VARCHAR(MAX) NOT NULL
)
