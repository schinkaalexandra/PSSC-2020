﻿using Access.Primitives.Extensions.ObjectExtensions;
using Access.Primitives.IO;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static StackUnderflow.Domain.Core.Contexts.Question.CreateQuestion.CreateQuestionResult;

namespace StackUnderflow.Domain.Core.Contexts.Question.CreateQuestion
{
    class CreateQuestionAdapter : Adapter<CreateQuestionCmd, ICreateQuestionResult, QuestionWriteContext, QuestionDependencies>
    {
        public override Task PostConditions(CreateQuestionCmd cmd, ICreateQuestionResult result, QuestionWriteContext state)
        {
            return Task.CompletedTask;
        }

        public async override Task<ICreateQuestionResult> Work(CreateQuestionCmd cmd, QuestionWriteContext state, QuestionDependencies dependencies)
        {
            var workflow = from valid in cmd.TryValidate()
                           let t = AddQuestion(state, CreateQuestionFromCmd(cmd))
                           select t;
            state.Questions.Add(new DatabaseModel.Models.Questions { QuestionId = Guid.NewGuid(), Title = "Titlul intrebarii", Body = "Descrierea intrebarii", Tags = "Tag-urile intrebarii" });

            var result = await workflow.Match(
                Succ: r => r,
                Fail: er => new QuestionNotPosted(er.Message)
                );

            return result;
        }

        private ICreateQuestionResult AddQuestion(QuestionWriteContext state, object v)
        {
            return new QuestionPosted(Guid.NewGuid(), "Titlul intrebarii", "Descrierea intrebarii", "Tag-urile intrebarii");
        }

        private object CreateQuestionFromCmd(CreateQuestionCmd cmd)
        {
            return new { };
        }
    }
}

