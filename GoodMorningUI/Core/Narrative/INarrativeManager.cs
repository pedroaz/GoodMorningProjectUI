using GoodMorningUI.Core.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodMorningUI.Core.Narrative
{
    public interface INarrativeManager
    {
        public Question GetFirstQuestion();
    }
}
