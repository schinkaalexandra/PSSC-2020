using CSharp.Choices;
using System;
using System.Collections.Generic;
using System.Text;

namespace StackUnderflow.Domain.Core.Contexts.Question.SendAckToQuestionOwner
{
    [AsChoice]
    public static partial class SendAckToQuestionOwnerResult
    {
        public interface ISendAckToQuestionOwnerResult { }
        public class AckSent : ISendAckToQuestionOwnerResult
        {
            public int QuestionId { get; }
            public int QuestionOwnerId { get; }
            public AckSent(int questionId, int questionOwnerId)
            {
                QuestionId = questionId;
                QuestionOwnerId = questionOwnerId;
            }
        }

        public class AckNotSent : ISendAckToQuestionOwnerResult
        {
            public string Message { get; }
            public AckNotSent(string message)
            {
                Message = message;
            }
        }
    }
}
