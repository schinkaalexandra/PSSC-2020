// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using CSharp.Choices;

namespace Tema6_18.Outputs
{
    public static partial class CheckLanguageResult
    {
        public static ICheckLanguageResult Match(this ICheckLanguageResult self, System.Func<TextChecked, ICheckLanguageResult> whenTextChecked, System.Func<CheckFailed, ICheckLanguageResult> whenCheckFailed)
        {
            switch ((self))
            {
                case TextChecked textchecked:
                    return whenTextChecked(textchecked);
                case CheckFailed checkfailed:
                    return whenCheckFailed(checkfailed);
                default:
                    throw new System.NotSupportedException("This switch statement should be exhaustive");
            }
        }

        public static async System.Threading.Tasks.Task<ICheckLanguageResult> MatchAsync(this ICheckLanguageResult self, System.Func<TextChecked, System.Threading.Tasks.Task<ICheckLanguageResult>> whenTextChecked, System.Func<CheckFailed, System.Threading.Tasks.Task<ICheckLanguageResult>> whenCheckFailed)
        {
            switch ((self))
            {
                case TextChecked textchecked:
                    return await whenTextChecked(textchecked);
                case CheckFailed checkfailed:
                    return await whenCheckFailed(checkfailed);
                default:
                    throw new System.NotSupportedException("This switch statement should be exhaustive");
            }
        }

        public static R Match<R>(this ICheckLanguageResult self, System.Func<TextChecked, R> whenTextChecked, System.Func<CheckFailed, R> whenCheckFailed)
        {
            switch ((self))
            {
                case TextChecked textchecked:
                    return whenTextChecked(textchecked);
                case CheckFailed checkfailed:
                    return whenCheckFailed(checkfailed);
                default:
                    throw new System.NotSupportedException("This switch statement should be exhaustive");
            }
        }

        public static async System.Threading.Tasks.Task<R> MatchAsync<R>(this ICheckLanguageResult self, System.Func<TextChecked, System.Threading.Tasks.Task<R>> whenTextChecked, System.Func<CheckFailed, System.Threading.Tasks.Task<R>> whenCheckFailed)
        {
            switch ((self))
            {
                case TextChecked textchecked:
                    return await whenTextChecked(textchecked);
                case CheckFailed checkfailed:
                    return await whenCheckFailed(checkfailed);
                default:
                    throw new System.NotSupportedException("This switch statement should be exhaustive");
            }
        }
    }
}