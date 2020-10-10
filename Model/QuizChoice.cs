namespace Quizoo.Model
{
    public class QuizChoice
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool IsCorrectAnswer { get; set; } = false;
        public bool Selected { get; set; } = false;
    }
}