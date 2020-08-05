using GoodMorningUI.Core.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodMorningUI.Core.Factories
{
    public class QuestionFactory : IQuestionFactory
    {
        public List<Question> GetAllQuestions()
        {
            List<Question> questions = new List<Question>();
            questions.Add(StartingQuestion());
            questions.Add(FinalQuestion());
            return questions;
        }

        private Question StartingQuestion()
        {
            return new Question(
                QuestionId.StartingQuestion,
                "Are you Ok?",
                new List<Answer>() {
                    new Answer(
                        "Yes",
                        QuestionId.FinalQuestion
                    ),
                    new Answer(
                        "No",
                        QuestionId.FinalQuestion
                    )
                }
            );
        }

        private Question FinalQuestion()
        {
            return new Question(
                QuestionId.FinalQuestion,
                "Thank you!",
                new List<Answer>() {
                    
                }
            );
        }
    }
}
