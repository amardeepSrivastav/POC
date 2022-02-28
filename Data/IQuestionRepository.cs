using System.Collections.Generic;
using POC.DTO;
using POC.Models;

namespace POC.Data
{
    public interface IQuestionRepository
    {
        IEnumerable<ReadQuestionsDTO> GetAllQuestions();
        int[] GetAnswers(int[] qIDs);
    }
}