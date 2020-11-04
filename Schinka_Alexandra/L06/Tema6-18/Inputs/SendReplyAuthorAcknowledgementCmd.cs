using System;
using System.Collections.Generic;
using System.Text;

namespace Tema6_18.Inputs
{
    class SendReplyAuthorAcknowledgementCmd
    {
        public SendReplyAuthorAcknowledgementCmd(int replyAuthorId, int questionId, string answer)
        {
            ReplyAuthorId = replyAuthorId;
            QuestionId = questionId;
            Answer = answer;
        }

        public int ReplyAuthorId { get; }
        public int QuestionId { get; }
        public string Answer { get; }
    }
}
