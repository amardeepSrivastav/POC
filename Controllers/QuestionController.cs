using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using AutoMapper;
using Microsoft.Extensions.Logging;
using POC.Data;
using POC.DTO;
using POC.Models;

namespace POC.Controllers
{
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionRepository _questionRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<QuestionController> _logger;

        public QuestionController(IQuestionRepository questionRepository,IMapper mapper, ILogger<QuestionController> logger)
        {
            _questionRepository = questionRepository;
            _mapper = mapper;
            _logger = logger;
        }
        [Route("api/Questions")]
        [HttpGet]
        public ActionResult<IEnumerable<ReadQuestionsDTO>> GetAllQuestions()
        {
            try{
                 var questions = _questionRepository.GetAllQuestions();
            return Ok(questions);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return null;
         
        }

        [HttpPost]
        [Route("api/Answers")]
        public ActionResult GetAnswers(int[] qIDs) {
             try{
                 var answers = _questionRepository.GetAnswers(qIDs);
            return Ok(answers);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return null;
        }
    }
}