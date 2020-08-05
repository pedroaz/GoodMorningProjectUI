using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodMorningUI.Core.BaseClasses
{
    public class Question
    {
        public QuestionId Id { get; set; }
        public string Text { get; set; }
        public List<Answer> Answers { get; set; }

        public Question(QuestionId id, string text, List<Answer> answers)
        {
            Id = id;
            Text = text;
            Answers = answers;
        }
    }
}
