CREATE TABLE [dbo].[Personal_Info]
(
	[IdNumber] INT NOT NULL PRIMARY KEY, 
    [LastName] NCHAR(40) NOT NULL, 
    [FirstName] NCHAR(40) NOT NULL, 
    [MiddleName] NCHAR(40) NULL, 
    [Address] NCHAR(40) NOT NULL, 
    [FundSource] NCHAR(40) NOT NULL, 
    [FundSourceType] NCHAR(40) NOT NULL, 
    [Job] NCHAR(40) NOT NULL, 
    [SalaryEnough] NCHAR(40) NOT NULL, 
    [SalaryRange] NCHAR(40) NOT NULL
)
