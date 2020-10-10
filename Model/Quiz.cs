using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace Quizoo.Model
{
    public class Quiz
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<QuizQuestion> Questions { get; set; }
        public int QuizMaxTime { get; set; } = -1;
        public bool IsQuizTimeBased => QuizMaxTime > 0;
    }
}
