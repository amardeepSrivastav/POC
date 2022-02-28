namespace POC.DTO
{
    public class ReadQuestionsDTO
    {
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public int Answer { get; set; }

        public string[] Options{get;set;}
    }
}