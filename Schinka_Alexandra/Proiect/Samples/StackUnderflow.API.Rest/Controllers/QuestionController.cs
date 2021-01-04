using Access.Primitives.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using System.Linq;
using System.Threading.Tasks;
using StackUnderflow.EF.Models;
using Access.Primitives.EFCore;
using LanguageExt;
using StackUnderflow.Domain.Core.Contexts.Question.CreateQuestion;
using StackUnderflow.Domain.Core.Contexts.Question;
using StackUnderflow.DatabaseModel.Models;
using System;
using StackUnderflow.EF;
using Microsoft.EntityFrameworkCore;

namespace StackUnderflow.API.Rest.Controllers

{
    [ApiController]
    [Route("question")]
    public class QuestionController : ControllerBase
    {
        private readonly IInterpreterAsync _interpreter;
        private readonly DatabaseContext _dbContext;

        public QuestionController(IInterpreterAsync interpreter, DatabaseContext dbContext)
        {
            _interpreter = interpreter;
            _dbContext = dbContext;
        }

        [HttpPost("CreateQuestion")]
        public async Task<IActionResult> CreateQuestion([FromBody] CreateQuestionCmd cmd)
        {
            var dep = new QuestionDependencies();
            var questions = await _dbContext.Questions.ToListAsync();
            var ctx = new QuestionWriteContext(new EFList<Questions>(_dbContext.Questions));
            var expr = from createQuestionResult in QuestionContext.CreateQuestion(cmd) select createQuestionResult;
            var r = await _interpreter.Interpret(expr, ctx, dep);
            _dbContext.Questions.Add(new DatabaseModel.Models.Questions { QuestionId = Guid.NewGuid(), Title = cmd.Title, Body = cmd.Body, Tags = cmd.Tags });
            await _dbContext.SaveChangesAsync();

            return r.Match(
                    created => (IActionResult)Ok(created.Body),
                    notcreated => BadRequest("NotPosted"),
                    invalidRequest => ValidationProblem()
                    );
        }
    }
}