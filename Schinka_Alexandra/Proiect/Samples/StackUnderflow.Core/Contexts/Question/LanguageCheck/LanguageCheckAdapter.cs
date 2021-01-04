using Access.Primitives.IO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static StackUnderflow.Domain.Core.Contexts.Question.LanguageCheck.LanguageCheckResult;

namespace StackUnderflow.Domain.Core.Contexts.Question.LanguageCheck
{
    public class LanguageCheckAdapter : Adapter<LanguageCheckCmd, ILanguageCheckResult, QuestionWriteContext, QuestionDependencies>
    {
        public override Task PostConditions(LanguageCheckCmd cmd, ILanguageCheckResult result, QuestionWriteContext state)
        {
            return Task.CompletedTask;
        }

        public async override Task<ILanguageCheckResult> Work(LanguageCheckCmd cmd, QuestionWriteContext state, QuestionDependencies dependencies)
        {
            return new TextChecked("Valid");
        }
    }
}
