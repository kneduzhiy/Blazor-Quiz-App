using Realms;
using System;

namespace Quizoo.Model
{
    public class QuizChoice : RealmObject
    {
        [PrimaryKey]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Text { get; set; }
        public bool IsCorrectAnswer { get; set; } = false;
    }
}