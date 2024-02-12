CREATE TABLE [dbo].[SHS_Information]
(
	[StudentId] INT NOT NULL, 
    [TypeOfSchool] NCHAR(40) NOT NULL,
    [JoinedScienceHigh] NCHAR(40) NOT NULL,
    [ScienceHighSchool] VARCHAR(MAX) NULL,
    [SeniorHighSchool] VARCHAR(MAX) NOT NULL, 
    [Strand] VARCHAR(MAX) NOT NULL, 
    [WithHonors] NCHAR(40) NOT NULL, 
    [InTopTen] NCHAR(40) NOT NULL, 
    [AcademicRank] NCHAR(40) NULL, 
    [AcademicExcellenceAward] NCHAR(40) NULL, 
    [GradeRangeEnglish] NCHAR(40) NOT NULL, 
    [GradeRangeMath] NCHAR(40) NOT NULL,
    [GradeRangeScience] NCHAR(40) NOT NULL,
    [GPA] NCHAR(40) NOT NULL,
    CONSTRAINT [FK_StudentIdNumber] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Personal_Info] ([IdNumber])
)