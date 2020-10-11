using Quizoo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quizoo.Service.Interfaces
{
    public interface IQuizService
    {
        public IList<Quiz> GetAllQuizzes();
        public Quiz GetQuiz(string id);
    }
}
