using SurveyApp.Model.PersonInfo;
using SurveyApp.Model.QuestionInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.Model.SurveyInfo
{
    public class Survey
    {
        

        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime Date { get; private set; }
        public int NumberOfQuestions { get; private set; }
        public Person Person { get; private set; }

        private List<Question> _questions = new List<Question>();
        public IReadOnlyList<Question> Questions => _questions;
        

        public Survey(string title, string description, DateTime date, int numberOfQuestions)
        {
            Title = title;
            Description = description;
            Date = date;
            NumberOfQuestions = numberOfQuestions;
        }

        public void AddQuestion(Question question)
        {
            if(Questions.Count < NumberOfQuestions)
            {
                var isSame = Questions.Any(x => x.Description == question.Description);
                if (!isSame)
                {
                    _questions.Add(question);
                }
                else
                {
                    throw new Exception("Aynı soru girişi yapılmıştır. Tekrar Deneyiniz");
                }
                
            }
            else
            {
                throw new Exception("Belirlenen soru sayısı geçilmiştir. Daha fazla soru girişi yapılammaz");
            }
            
        }

        public void SetUser(Person person)
        {
            this.Person = person;
        }


    }
}
