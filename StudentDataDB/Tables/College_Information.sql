﻿CREATE TABLE [dbo].[College_Information]
(
	[StudentId] INT NOT NULL, 
    [Course] VARCHAR(MAX) NULL, 
    [YearLevel] VARCHAR(MAX) NULL, 
    [ProgMidtermGrade] INT NOT NULL, 
    [ExpectedProg1Grade] VARCHAR(MAX) NOT NULL, 
    [Prog1Professor] VARCHAR(MAX) NULL, 
    [ModeOfDelivery] VARCHAR(MAX) NULL, 
    [HasScholarship] VARCHAR(MAX) NULL, 
    [ScholarshipType] VARCHAR(MAX) NOT NULL, 
    [HasExperience] VARCHAR(MAX) NULL, 
    [ProgrammingLanguages] VARCHAR(MAX) NOT NULL, 
    [HasDevice] VARCHAR(MAX) NULL, 
    [IsInCebu] VARCHAR(MAX) NULL, 
    [CurrentPlace] VARCHAR(MAX) NULL, 
    [HasRoom] VARCHAR(MAX) NULL, 
    [HasEnoughSpace] VARCHAR(MAX) NULL, 
    [ModeOfTransportationToSchool] VARCHAR(MAX) NULL, 
    [CommuteCountToSchool] VARCHAR(MAX) NULL, 
    [CommuteDurationToSchool] VARCHAR(MAX) NULL, 
    [ArriveSchoolFeeling] VARCHAR(MAX) NULL, 
    [ModeOfTransportationHome] VARCHAR(MAX) NULL, 
    [CommuteCountToHome] VARCHAR(MAX) NULL, 
    [CommuteDurationToHome] VARCHAR(MAX) NULL, 
    [ArriveHomeFeeling] VARCHAR(MAX) NULL, 
    [PursueCourseReason] VARCHAR(MAX) NULL,
    CONSTRAINT [FK_StudentId] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Personal_Info] ([IdNumber])

)
