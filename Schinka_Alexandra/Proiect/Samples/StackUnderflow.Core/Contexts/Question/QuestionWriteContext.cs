using System;
using System.Collections.Generic;
using System.Text;
using StackUnderflow.EF;
using StackUnderflow.DatabaseModel.Models;

namespace StackUnderflow.Domain.Core.Contexts.Question
{
    public class QuestionWriteContext
    {
        public ICollection<Questions> Questions { get; }
        public QuestionWriteContext(ICollection<Questions> question)
        {
            Questions = question ?? new List<Questions>();
        }
    }
}
