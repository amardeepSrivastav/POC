using AutoMapper;
using POC.DTO;
using POC.Models;

namespace POC.MappingProfile
{
    public class QuestionsProfile:Profile
    {
        public QuestionsProfile()
        {
            CreateMap<Question,ReadQuestionsDTO>();
        }
    }
    
}