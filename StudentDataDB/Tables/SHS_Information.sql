CREATE TABLE [dbo].[SHS_Information]
(
	[StudentId] INT NOT NULL, 
    [TypeOfSchool] NCHAR(40) NULL, 
    [SeniorHighSchool] NCHAR(40) NULL, 
    [Strand] NCHAR(40) NULL, 
    [WithHonors] NCHAR(40) NULL, 
    [TopNotcher] NCHAR(40) NULL, 
    [AcademicRank] NCHAR(40) NULL, 
    [AcademicExcellenceAward] NCHAR(40) NULL, 
    [GradeRangeEnglish] NCHAR(40) NULL, 
    [GradeRangeMath] NCHAR(40) NULL,
    [GradeRangeScience] NCHAR(40) NULL,
    [GPA] NCHAR(40) NULL,
    CONSTRAINT [FK_StudentId] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Personal_info] ([IdNumber])
)

