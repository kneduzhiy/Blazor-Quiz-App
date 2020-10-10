using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace Quizoo.Model
{
    public class QuizQuestion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<QuizChoice> Choices { get; set; }
        public int SecondsToFinish { get; set; }

        public QuizChoice GetCorrectAnswer() => GetCorrectMultipleAnswers().FirstOrDefault();
        public IList<QuizChoice> GetCorrectMultipleAnswers() => Choices.Where(x => x.IsCorrectAnswer).ToList();
    }
}
