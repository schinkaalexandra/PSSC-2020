using System;
using System.Collections.Generic;
using System.Text;
using Access.Primitives.IO;
using Tema6_18.Inputs;
using Tema6_18.Outputs;
using static PortExt;

namespace Tema6_18
{
    public static class Domain
    {
        public static Port<ValidateReplyResult.IValidateReplyResult> ValidateReply(int authorId, int questionId,
            string answer)
            => NewPort<CreateReplyCmd, ValidateReplyResult.IValidateReplyResult>(
                new CreateReplyCmd(authorId, questionId, answer));

        public static Port<CheckLanguageResult.ICheckLanguageResult> CheckLanguage(string text)
            => NewPort<CheckLanguageCmd, CheckLanguageResult.ICheckLanguageResult>(new CheckLanguageCmd(text));
        public static Port<SendQuestionOwnerAcknowledgementResult.ISendQuestionOwnerAcknowledgementResult> SendAckToQuestionOwner(int questionId, int questionOwnerId, string reply)
        => NewPort<SendQuestionOwnerAcknowledgementCmd, SendQuestionOwnerAcknowledgementResult.ISendQuestionOwnerAcknowledgementResult>(new SendQuestionOwnerAcknowledgementCmd(questionId,questionOwnerId, reply));

        public static Port<SendReplyAuthorAcknowledgementResult.ISendReplyAuthorAcknowledgementResult> SendAckToReplyAuthor(int replyAuthorId, int questionId, string answer)
        => NewPort<SendReplyAuthorAcknowledgementCmd, SendReplyAuthorAcknowledgementResult.ISendReplyAuthorAcknowledgementResult>(new SendReplyAuthorAcknowledgementCmd(replyAuthorId, questionId, answer));

    }
}
