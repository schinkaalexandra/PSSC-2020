using System;
using System.Collections.Generic;
using System.Text;

namespace Tema6_18.Inputs
{
    class SendQuestionOwnerAcknowledgementCmd
    {
        public SendQuestionOwnerAcknowledgementCmd(int questionId, int questionOwnerId, string questionReply)
        {
            QuestionId = questionId;
            QuestionOwnerId = questionOwnerId;
            QuestionReply =questionReply;
        }

        public int QuestionId { get; }
        public int QuestionOwnerId { get; }
        public string QuestionReply { get; }
    }

}

