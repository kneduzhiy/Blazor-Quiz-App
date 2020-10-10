using Quizoo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quizoo.Service
{
    public class QuizService
    {
        public Quiz GetSampleQuiz()
        {
            return new Quiz
            {
                Id = 1,
                Name = "Grundwissen Teil 1",
                Description = "Hier testen wir dein Grundwissen zu verschiedenen Themen.",
                Questions = new List<QuizQuestion> {
                    new QuizQuestion
                    {
                        Id = 1,
                        Name = "Wie heißt der/die deutsche BundeskanzlerIn?",
                        Description = string.Empty,
                        Choices = new List<QuizChoice>
                        {
                            new QuizChoice
                            {
                                Id = 2,
                                Text = "Alfred Knierim"
                            },
                            new QuizChoice
                            {
                                Id = 3,
                                Text = "Angela Knierim"
                            },
                            new QuizChoice
                            {
                                Id = 4,
                                Text = "Angela Merkel",
                                IsCorrectAnswer = true
                            },
                            new QuizChoice
                            {
                                Id = 5,
                                Text = "Catharina Jud"
                            }
                        }
                    },
                    new QuizQuestion
                    {
                        Id = 2,
                        Name = "Wie heißt der beste deutsche Flughafen?",
                        Description = string.Empty,
                        Choices = new List<QuizChoice>
                        {
                            new QuizChoice
                            {
                                Id = 2,
                                Text = "MUC",
                                IsCorrectAnswer = true
                            },
                            new QuizChoice
                            {
                                Id = 3,
                                Text = "FRA"
                            },
                            new QuizChoice
                            {
                                Id = 4,
                                Text = "BER"
                            },
                            new QuizChoice
                            {
                                Id = 5,
                                Text = "FMM"
                            }
                        }
                    },
                    new QuizQuestion
                    {
                        Id = 3,
                        Name = "Wie heißt der beste Terminal Duty Manager?",
                        Description = string.Empty,
                        Choices = new List<QuizChoice>
                        {
                            new QuizChoice
                            {
                                Id = 2,
                                Text = "AK"
                            },
                            new QuizChoice
                            {
                                Id = 3,
                                Text = "KQ"
                            },
                            new QuizChoice
                            {
                                Id = 4,
                                Text = "Knierim",
                                IsCorrectAnswer = true
                            },
                            new QuizChoice
                            {
                                Id = 5,
                                Text = "CJ"
                            }
                        }
                    }
                }
            };
        }
    }
}
