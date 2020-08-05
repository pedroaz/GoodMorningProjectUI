using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodMorningUI.Core.BaseClasses
{
    public class Answer
    {
        public string Text { get; set; }
        public QuestionId NextQuestion { get; set; }

        public Answer(string text, QuestionId nextQuestion)
        {
            Text = text;
            NextQuestion = nextQuestion;
        }
    }
}
