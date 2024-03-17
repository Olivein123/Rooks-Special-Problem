CREATE TABLE [dbo].[SHS_Information]
(
	[StudentId] INT NOT NULL, 
    [TypeOfSchool] VARCHAR(MAX) NOT NULL,
    [JoinedScienceHigh] VARCHAR(MAX) NOT NULL,
    [ScienceHighSchool] VARCHAR(MAX) NULL,
    [SeniorHighSchool] VARCHAR(MAX) NOT NULL, 
    [Strand] VARCHAR(MAX) NOT NULL, 
    [WithHonors] VARCHAR(MAX) NOT NULL, 
    [InTopTen] VARCHAR(MAX) NOT NULL, 
    [AcademicRank] VARCHAR(MAX) NULL, 
    [AcademicExcellenceAward] VARCHAR(MAX) NULL, 
    [GradeRangeEnglish] VARCHAR(MAX) NOT NULL, 
    [GradeRangeMath] VARCHAR(MAX) NOT NULL,
    [GradeRangeScience] VARCHAR(MAX) NOT NULL,
    [GPA] VARCHAR(MAX) NOT NULL,
    [Programming1Grade] VARCHAR(MAX) NULL, 
    CONSTRAINT [FK_StudentIdNumber] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Personal_Info] ([StudentId])
)