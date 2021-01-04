using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StackUnderflow.Domain.Core.Contexts.Question.LanguageCheck
{
    public class LanguageCheckCmd
    {
        [Required]
        public string Text { get; }

        public LanguageCheckCmd(string text)
        {
            Text = text;
        }
    }
}
