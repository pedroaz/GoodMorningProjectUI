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
                        QuestionId.StartingQuestion
                    ),
                    new Answer(
                        "No",
                        QuestionId.StartingQuestion
                    )
                }
            );
        }
    }
}
