using GoodMorningUI.Core.BaseClasses;
using GoodMorningUI.Core.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodMorningUI.Core.Narrative
{
    public class NarrativeManager : INarrativeManager
    {
        public List<Question> Questions;

        public IQuestionFactory QuestionFactory { get; set; }

        public NarrativeManager(IQuestionFactory questionFactory)
        {
            QuestionFactory = questionFactory;
            Questions = QuestionFactory.GetAllQuestions();
        }

        public Question GetFirstQuestion()
        {
            return GetQuestionById(QuestionId.StartingQuestion);
        }

        public Question GetQuestionById(QuestionId id)
        {
            return Questions.Find(x => x.Id == id);
        }
    }
}
