using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quizoo.Model
{
    public class QuizResult : RealmObject
    {
        [PrimaryKey]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public Quiz Quiz { get; set; }
        public int CorrectAnswers { get; set; }
        public DateTimeOffset QuizFinishedTime { get; set; }
    }
}
