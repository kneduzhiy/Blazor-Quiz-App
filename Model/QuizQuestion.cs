using Realms;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace Quizoo.Model
{
    public class QuizQuestion : RealmObject
    {
        [PrimaryKey]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<QuizChoice> Choices { get; }
        public int SecondsToFinish { get; set; }

        public QuizChoice GetCorrectAnswer() => GetCorrectMultipleAnswers().FirstOrDefault();
        public IList<QuizChoice> GetCorrectMultipleAnswers() => Choices.Where(x => x.IsCorrectAnswer).ToList();
    }
}
