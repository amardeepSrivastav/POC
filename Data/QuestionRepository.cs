using System;
using System.Collections.Generic;
using System.Linq;
using POC.DTO;
using POC.Models;
using POC.Data;

namespace POC.Data
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly POCDbContext _context;

        public QuestionRepository(POCDbContext context)
        {
            _context = context;
        }
        public IEnumerable<ReadQuestionsDTO> GetAllQuestions()
        {
            var Questions = _context.Questions
                    .Select(x => new { QnID = x.QuestionId, Qn = x.QuestionText, x.Option1, x.Option2, x.Option3, x.Option4 })
                    .OrderBy(y => Guid.NewGuid())
                    .ToArray();
                var updated = Questions.AsEnumerable()
                    .Select(x => new ReadQuestionsDTO()
                    {
                        QuestionId = x.QnID,
                        QuestionText = x.Qn,
                        Options = new string[] { x.Option1, x.Option2, x.Option3, x.Option4 }
                    }).ToList();
            return updated;
        }

        public int[] GetAnswers(int[] qIDs)
        {
            return _context.Questions
                    .AsEnumerable()
                    .Where(y => qIDs.Contains(y.QuestionId))
                    .OrderBy(x => { return Array.IndexOf(qIDs, x.QuestionId); })
                    .Select(z => z.Answer)
                    .ToArray();
        }
    }
}