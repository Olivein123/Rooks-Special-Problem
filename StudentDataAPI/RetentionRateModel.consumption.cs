﻿// This file was auto-generated by ML.NET Model Builder. 
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
namespace StudentDataAPI
{
    public partial class RetentionRateModel
    {
        /// <summary>
        /// model input class for RetentionRateModel.
        /// </summary>
        #region model input class
        public class ModelInput
        {
            [ColumnName(@"Address")]
            public float Address { get; set; }

            [ColumnName(@"Fund_Source")]
            public float Fund_Source { get; set; }

            [ColumnName(@"Fund_Type")]
            public float Fund_Type { get; set; }

            [ColumnName(@"HasJob")]
            public float HasJob { get; set; }

            [ColumnName(@"TotalParentsIncome")]
            public float TotalParentsIncome { get; set; }

            [ColumnName(@"NumberOfSiblings")]
            public float NumberOfSiblings { get; set; }

            [ColumnName(@"NumberOfDependentSiblings")]
            public float NumberOfDependentSiblings { get; set; }

            [ColumnName(@"Strand")]
            public float Strand { get; set; }

            [ColumnName(@"JoinedScienceHighSchool")]
            public float JoinedScienceHighSchool { get; set; }

            [ColumnName(@"WithHonors")]
            public float WithHonors { get; set; }

            [ColumnName(@"English Grade Range")]
            public float English_Grade_Range { get; set; }

            [ColumnName(@"Math Grade Range")]
            public float Math_Grade_Range { get; set; }

            [ColumnName(@"Science Grade Range")]
            public float Science_Grade_Range { get; set; }

            [ColumnName(@"GPA")]
            public float GPA { get; set; }

            [ColumnName(@"Course")]
            public float Course { get; set; }

            [ColumnName(@"Professor")]
            public float Professor { get; set; }

            [ColumnName(@"ModeOfDelivery")]
            public float ModeOfDelivery { get; set; }

            [ColumnName(@"HasScholarship")]
            public float HasScholarship { get; set; }

            [ColumnName(@"IsInCebu")]
            public float IsInCebu { get; set; }

            [ColumnName(@"CurrentStayingPlace")]
            public float CurrentStayingPlace { get; set; }

            [ColumnName(@"HasEnoughStudySpace")]
            public float HasEnoughStudySpace { get; set; }

            [ColumnName(@"ModeTransportGoingHome")]
            public float ModeTransportGoingHome { get; set; }

            [ColumnName(@"CommuteCountGoingHome")]
            public float CommuteCountGoingHome { get; set; }

            [ColumnName(@"CommuteDurationGoingHome")]
            public float CommuteDurationGoingHome { get; set; }

            [ColumnName(@"ModeTransportGoingSchool")]
            public float ModeTransportGoingSchool { get; set; }

            [ColumnName(@"CommuteCountGoingSchool")]
            public float CommuteCountGoingSchool { get; set; }

            [ColumnName(@"CommuteDurationGoingSchool")]
            public float CommuteDurationGoingSchool { get; set; }

            [ColumnName(@"IsRetained")]
            public float IsRetained { get; set; }

            [ColumnName(@"HasDevice")]
            public float HasDevice { get; set; }

        }

        #endregion

        /// <summary>
        /// model output class for RetentionRateModel.
        /// </summary>
        #region model output class
        public class ModelOutput
        {
            [ColumnName(@"Address")]
            public float Address { get; set; }

            [ColumnName(@"Fund_Source")]
            public float Fund_Source { get; set; }

            [ColumnName(@"Fund_Type")]
            public float Fund_Type { get; set; }

            [ColumnName(@"HasJob")]
            public float HasJob { get; set; }

            [ColumnName(@"TotalParentsIncome")]
            public float TotalParentsIncome { get; set; }

            [ColumnName(@"NumberOfSiblings")]
            public float NumberOfSiblings { get; set; }

            [ColumnName(@"NumberOfDependentSiblings")]
            public float NumberOfDependentSiblings { get; set; }

            [ColumnName(@"Strand")]
            public float Strand { get; set; }

            [ColumnName(@"JoinedScienceHighSchool")]
            public float JoinedScienceHighSchool { get; set; }

            [ColumnName(@"WithHonors")]
            public float WithHonors { get; set; }

            [ColumnName(@"English Grade Range")]
            public float English_Grade_Range { get; set; }

            [ColumnName(@"Math Grade Range")]
            public float Math_Grade_Range { get; set; }

            [ColumnName(@"Science Grade Range")]
            public float Science_Grade_Range { get; set; }

            [ColumnName(@"GPA")]
            public float GPA { get; set; }

            [ColumnName(@"Course")]
            public float Course { get; set; }

            [ColumnName(@"Professor")]
            public float Professor { get; set; }

            [ColumnName(@"ModeOfDelivery")]
            public float ModeOfDelivery { get; set; }

            [ColumnName(@"HasScholarship")]
            public float HasScholarship { get; set; }

            [ColumnName(@"IsInCebu")]
            public float IsInCebu { get; set; }

            [ColumnName(@"CurrentStayingPlace")]
            public float CurrentStayingPlace { get; set; }

            [ColumnName(@"HasEnoughStudySpace")]
            public float HasEnoughStudySpace { get; set; }

            [ColumnName(@"ModeTransportGoingHome")]
            public float ModeTransportGoingHome { get; set; }

            [ColumnName(@"CommuteCountGoingHome")]
            public float CommuteCountGoingHome { get; set; }

            [ColumnName(@"CommuteDurationGoingHome")]
            public float CommuteDurationGoingHome { get; set; }

            [ColumnName(@"ModeTransportGoingSchool")]
            public float ModeTransportGoingSchool { get; set; }

            [ColumnName(@"CommuteCountGoingSchool")]
            public float CommuteCountGoingSchool { get; set; }

            [ColumnName(@"CommuteDurationGoingSchool")]
            public float CommuteDurationGoingSchool { get; set; }

            [ColumnName(@"IsRetained")]
            public uint IsRetained { get; set; }

            [ColumnName(@"HasDevice")]
            public float HasDevice { get; set; }

            [ColumnName(@"Features")]
            public float[] Features { get; set; }

            [ColumnName(@"PredictedLabel")]
            public float PredictedLabel { get; set; }

            [ColumnName(@"Score")]
            public float[] Score { get; set; }

        }

        #endregion

        private static string MLNetModelPath = Path.GetFullPath("RetentionRateModel.zip");

        public static readonly Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(() => CreatePredictEngine(), true);

        /// <summary>
        /// Use this method to predict on <see cref="ModelInput"/>.
        /// </summary>
        /// <param name="input">model input.</param>
        /// <returns><seealso cref=" ModelOutput"/></returns>
        public static ModelOutput Predict(ModelInput input)
        {
            var predEngine = PredictEngine.Value;
            return predEngine.Predict(input);
        }

        private static PredictionEngine<ModelInput, ModelOutput> CreatePredictEngine()
        {
            var mlContext = new MLContext();
            ITransformer mlModel = mlContext.Model.Load(MLNetModelPath, out var _);
            return mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
        }
    }
}
