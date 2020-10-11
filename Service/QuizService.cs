using Quizoo.Model;
using Quizoo.Service.Interfaces;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Quizoo.Service
{
    public class QuizService : BaseService, IQuizService
    {
        public QuizChoice GetChoice(string guid) {
            return Database.Find<QuizChoice>(guid);
        }

        public IList<Quiz> GetAllQuizzes()
        {
            return Database.All<Quiz>().ToList();
        }

        public Quiz GetQuiz(string id)
        {
            return Database.Find<Quiz>(id);
        }

        public IList<QuizResult> GetQuizResults()
        {
            return Database.All<QuizResult>().ToList();
        }

        public void PersistQuiz(Action persistAction)
        {
            Database.Write(persistAction);
        }

        public void WriteResults(Quiz quiz, int correctAnswers)
        {
            QuizResult result = new QuizResult
            {
                Quiz = quiz,
                CorrectAnswers = correctAnswers,
                QuizFinishedTime = DateTime.Now
            };

            PersistQuiz(() =>
            {
                Database.Add(result);
            });
        }
    }
}
