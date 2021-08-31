using System;
using System.Collections.Generic;
using System.Text;

namespace GradingSystem
{
    class GradingSystemProperties
    {
        public string CourseDescription { get; set; }
        public double CourseScore { get; set; }
        public int CourseUnit { get; set; }
        public string CourseGrade { get; set; }
        public int CourseGradeUnit { get; set; }
        public int CourseWeightPoint { get; set; }
        public string Remark { get; set; }
        

        public GradingSystemProperties(string CourseDescription, double CourseScore, int CourseUnit, 
                                       string CourseGrade, int CourseGradeUnit, int CourseWeightPoint,string Remark)
        {
            this.CourseDescription        = CourseDescription;
            this.CourseScore              = CourseScore;
            this.CourseUnit               = CourseUnit;
            this.CourseGrade              = CourseGrade;
            this.CourseGradeUnit          = CourseGradeUnit;
            this.CourseWeightPoint        = CourseWeightPoint;
            this.Remark                   = Remark;
        }
    }
}
