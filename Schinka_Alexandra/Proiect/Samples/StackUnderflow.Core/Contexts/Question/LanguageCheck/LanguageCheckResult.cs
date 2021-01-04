using CSharp.Choices;
using System;
using System.Collections.Generic;
using System.Text;

using Access.Primitives.IO;



namespace StackUnderflow.Domain.Core.Contexts.Question.LanguageCheck
{
    [AsChoice]
   public static partial class LanguageCheckResult
    {
        public interface ILanguageCheckResult { }

        public class TextChecked : ILanguageCheckResult
        {
            public string Message { get; }
            public TextChecked(string message)
            {
                Message = message;
            }
        }
        public class TextNotChecked : ILanguageCheckResult
        {
            public string ErrorMessage { get; }
            public TextNotChecked(string errorMessage)
            {
                ErrorMessage = errorMessage;
            }
        }
        public class ManualReviewRequired : ILanguageCheckResult
        {
            public string Text { get; }
            public ManualReviewRequired(string text)
            {
                Text = text;
            }
        }

    }
}
