using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StackUnderflow.Domain.Core.Contexts.Question.CreateQuestion
{
   public class CreateQuestionCmd
    {
        [Required]
        public string Title { get; set; }           //titlul intrebarii
        [Required]
        public string Body { get; set; }            //descrierea detaliala a intrebarii
        [Required]
        public string Tags { get; set; }                     //domeniul/domeniile din care face parte intrebarea
        public CreateQuestionCmd() { }
        public CreateQuestionCmd(string title, string body, string tags)
        {
            Title = title;
            Body = body;
            Tags = tags;
        }
    }
}
