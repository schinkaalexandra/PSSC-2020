﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Tema6_18.Inputs
{
    public class CreateReplyCmd
    {
        [Required]
        public int AuthorId { get; }

        [Required]
        public int QuestionId { get; }

        [Required]
        public string Text { get; }

        public CreateReplyCmd(int authorId, int questionId, string text)
        {
            AuthorId = authorId;
            QuestionId = questionId;
            Text = text;
        }
    }
}
