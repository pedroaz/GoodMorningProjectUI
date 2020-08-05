using GoodMorningUI.Core;
using GoodMorningUI.Core.BaseClasses;
using GoodMorningUI.Core.Factories;
using GoodMorningUI.Core.Narrative;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodMorningUI.Pages
{
    public partial class Index
    {
        [Inject]
        INarrativeManager NarrativeManager { get; set; }

        public Question Question { get; set; }

        protected override Task OnInitializedAsync()
        {
            Question = NarrativeManager.GetFirstQuestion();
            return base.OnInitializedAsync();
        }

        public void ClickAnswerButton(Answer answer)
        {
            Question = NarrativeManager.GetQuestionById(answer.NextQuestion);
        }
    }
}
