using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.Model.QuestionInfo
{
    public class Question
    {


        public string Description { get; private set; }
        public QuestionType QuestionType { get; private set; }


        public Question(string description, QuestionType questionType)
        {
            Description = description;
            QuestionType = questionType;
        }

        public void addQ()
        {

        }

    }
        
}
