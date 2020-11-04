using System;
using CSharp.Choices;
using System.Collections.Generic;
using System.Text;

namespace Tema6_18.Outputs
{
   
    [AsChoice]
    public static partial class SendQuestionOwnerAcknowledgementResult
    {
        public interface ISendQuestionOwnerAcknowledgementResult { }

        public class AcknowledgementSent : ISendQuestionOwnerAcknowledgementResult
        {
            public AcknowledgementSent(int questionId, int questionOwnerId)
            {
                QuestionId = questionId;
                QuestionOwnerId = questionOwnerId;
            }

            public int QuestionId { get; }
            public int QuestionOwnerId { get; }
        }

        public class AcknowledgementNotSent : ISendQuestionOwnerAcknowledgementResult
        {
            public AcknowledgementNotSent(string message)
            {
                Message = message;
            }

            public string Message { get; }
        }
    }
}
