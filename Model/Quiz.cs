using Realms;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace Quizoo.Model
{
    public class Quiz : RealmObject
    {
        [PrimaryKey]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<QuizQuestion> Questions { get; }
        public int QuizMaxTimeInSeconds { get; set; } = -1;
        public bool IsQuizTimeBased => QuizMaxTimeInSeconds > 0;
    }
}
