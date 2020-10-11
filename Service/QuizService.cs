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
        public void PopulateRealm()
        {
            Database.Write(() =>
            {
                Database.Add(GetSampleQuiz(), true);
                Database.Add(GetSampleQuiz(2), true);
                Database.Add(GetSampleQuiz(3), true);
            });
        }

        public Quiz GetSampleQuiz(int id = 1)
        {
            var quiz = new Quiz
            {
                Name = $"Basic knowledge test part {id}",
                Description = "We will ask you different questions in order to assess your knowledge.",
                QuizMaxTimeInSeconds = 32,
            };
            var choice1 = new QuizChoice
            {
                Text = "Angela Alfred"
            };
            var choice2 = new QuizChoice
            {
                Text = "Test Fred"
            };
            var choice3 = new QuizChoice
            {
                Text = "SDSDSD",
                IsCorrectAnswer = true
            };
            var choice4 = new QuizChoice
            {
                Text = "Test red"
            };

            var question1 = new QuizQuestion
            {
                Name = "Whats the name of a test person?",
                Description = string.Empty
            };
            question1.Choices.Add(choice1);
            question1.Choices.Add(choice2);
            question1.Choices.Add(choice3);
            question1.Choices.Add(choice4);

            quiz.Questions.Add(question1);

            var question2 = new QuizQuestion
            {
                Name = "Whats the best airport?",
                Description = string.Empty
            };
            question2.Choices.Add(choice2);
            question2.Choices.Add(choice1);
            question2.Choices.Add(choice4);
            question2.Choices.Add(choice3);

            quiz.Questions.Add(question2);

            return quiz;
        }
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
