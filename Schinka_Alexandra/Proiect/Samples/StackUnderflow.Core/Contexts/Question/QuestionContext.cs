
using Access.Primitives.IO;
using StackUnderflow.Domain.Core.Contexts.Question.CreateQuestion;
using StackUnderflow.Domain.Core.Contexts.Question.LanguageCheck;
using StackUnderflow.Domain.Core.Contexts.Question.SendAckToQuestionOwner;
using System;
using System.Collections.Generic;
using System.Text;
using static StackUnderflow.Domain.Core.Contexts.Question.CreateQuestion.CreateQuestionResult;
using static StackUnderflow.Domain.Core.Contexts.Question.LanguageCheck.LanguageCheckResult;
using static StackUnderflow.Domain.Core.Contexts.Question.SendAckToQuestionOwner.SendAckToQuestionOwnerResult;

namespace StackUnderflow.Domain.Core.Contexts.Question
{
    public static class QuestionContext
    {
        public static Port<ICreateQuestionResult> CreateQuestion(CreateQuestionCmd createQuestionCmd) =>
            NewPort<CreateQuestionCmd, ICreateQuestionResult>(createQuestionCmd);

        public static Port<ILanguageCheckResult>LanguageCheck(LanguageCheckCmd checkLanguageCmd) =>
           NewPort<LanguageCheckCmd, ILanguageCheckResult>(checkLanguageCmd);

        private static Port<T2> NewPort<T1, T2>(T1 checkLanguageCmd)
        {
            throw new NotImplementedException();
        }

        public static Port<ISendAckToQuestionOwnerResult> SendAckToQuestionOwner(SendAckToQuestionOwnerCmd sendAckToQuestionOwnerCmd) =>
            NewPort<SendAckToQuestionOwnerCmd, ISendAckToQuestionOwnerResult>(sendAckToQuestionOwnerCmd);
    }
}
