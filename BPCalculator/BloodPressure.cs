using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace BPCalculator
{
    // BP categories
    public enum BPCategory
    {
        [Display(Name="Lowwwwww Blood Pressure")] Low,
        [Display(Name="Ideal Blood Pressure")]  Ideal,
        [Display(Name="Pre-High Blood Pressure")] PreHigh,
        [Display(Name="High Blood Pressure")]  High,
        [Display(Name="Invalid Values")] None
    };

    public class BloodPressure
    {
        public const int SystolicMin = 70;
        public const int SystolicMax = 190;
        public const int DiastolicMin = 40;
        public const int DiastolicMax = 100;

        [Range(SystolicMin, SystolicMax, ErrorMessage = "Invalid Systolic Value")]
        public int Systolic { get; set; }                       // mmHG

        [Range(DiastolicMin, DiastolicMax, ErrorMessage = "Invalid Diastolic Value")]
        public int Diastolic { get; set; }                      // mmHG

        // calculate BP category
        public BPCategory Category
        {
            get
            {
                
                if      (Systolic >= 70 && Systolic < 90 && Diastolic >= 40 && Diastolic < 60)
                            { return BPCategory.Low; }
                else if (((Systolic >= 70 && Systolic < 120) && (Diastolic >= 40 && Diastolic < 80)) && !((Systolic >= 70 && Systolic < 90) && (Diastolic >= 40 && Diastolic < 60)))
                            { return BPCategory.Ideal; }
                else if (((Systolic >= 70 && Systolic < 140) && (Diastolic >= 40 && Diastolic < 90)) && !((Systolic >= 70 && Systolic < 120) && (Diastolic >= 40 && Diastolic < 80)))
                            { return BPCategory.PreHigh; }
                else if (((Systolic >= 70 && Systolic <= 190) && (Diastolic >= 40 && Diastolic <= 100)) && !((Systolic >= 70 && Systolic < 140) && (Diastolic >= 40 && Diastolic < 90)))
                            { return BPCategory.High; }
                else        { return BPCategory.None; }

                
            }
        }
    }
}
