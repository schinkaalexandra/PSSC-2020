// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using CSharp.Choices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tema6_18.Outputs
{
    public static partial class SendReplyAuthorAcknowledgementResult
    {
        public static ISendReplyAuthorAcknowledgementResult Match(this ISendReplyAuthorAcknowledgementResult self, System.Func<AcknowledgementSent, ISendReplyAuthorAcknowledgementResult> whenAcknowledgementSent, System.Func<AcknowledgementNotSent, ISendReplyAuthorAcknowledgementResult> whenAcknowledgementNotSent)
        {
            switch ((self))
            {
                case AcknowledgementSent acknowledgementsent:
                    return whenAcknowledgementSent(acknowledgementsent);
                case AcknowledgementNotSent acknowledgementnotsent:
                    return whenAcknowledgementNotSent(acknowledgementnotsent);
                default:
                    throw new System.NotSupportedException("This switch statement should be exhaustive");
            }
        }

        public static async System.Threading.Tasks.Task<ISendReplyAuthorAcknowledgementResult> MatchAsync(this ISendReplyAuthorAcknowledgementResult self, System.Func<AcknowledgementSent, System.Threading.Tasks.Task<ISendReplyAuthorAcknowledgementResult>> whenAcknowledgementSent, System.Func<AcknowledgementNotSent, System.Threading.Tasks.Task<ISendReplyAuthorAcknowledgementResult>> whenAcknowledgementNotSent)
        {
            switch ((self))
            {
                case AcknowledgementSent acknowledgementsent:
                    return await whenAcknowledgementSent(acknowledgementsent);
                case AcknowledgementNotSent acknowledgementnotsent:
                    return await whenAcknowledgementNotSent(acknowledgementnotsent);
                default:
                    throw new System.NotSupportedException("This switch statement should be exhaustive");
            }
        }

        public static R Match<R>(this ISendReplyAuthorAcknowledgementResult self, System.Func<AcknowledgementSent, R> whenAcknowledgementSent, System.Func<AcknowledgementNotSent, R> whenAcknowledgementNotSent)
        {
            switch ((self))
            {
                case AcknowledgementSent acknowledgementsent:
                    return whenAcknowledgementSent(acknowledgementsent);
                case AcknowledgementNotSent acknowledgementnotsent:
                    return whenAcknowledgementNotSent(acknowledgementnotsent);
                default:
                    throw new System.NotSupportedException("This switch statement should be exhaustive");
            }
        }

        public static async System.Threading.Tasks.Task<R> MatchAsync<R>(this ISendReplyAuthorAcknowledgementResult self, System.Func<AcknowledgementSent, System.Threading.Tasks.Task<R>> whenAcknowledgementSent, System.Func<AcknowledgementNotSent, System.Threading.Tasks.Task<R>> whenAcknowledgementNotSent)
        {
            switch ((self))
            {
                case AcknowledgementSent acknowledgementsent:
                    return await whenAcknowledgementSent(acknowledgementsent);
                case AcknowledgementNotSent acknowledgementnotsent:
                    return await whenAcknowledgementNotSent(acknowledgementnotsent);
                default:
                    throw new System.NotSupportedException("This switch statement should be exhaustive");
            }
        }
    }
}