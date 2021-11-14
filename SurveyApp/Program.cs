using SurveyApp.Model.SurveyInfo;
using System;

namespace SurveyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var survey = new Survey(title:"nerdesin",description:"kısa", date: new DateTime(2021,1,1), numberOfQuestions: 1);
            survey.AddQuestion(new Model.QuestionInfo.Question());

        }
    }
}
