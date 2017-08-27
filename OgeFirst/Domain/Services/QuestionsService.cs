using OgeFirst.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OgeFirst.Domain.Services
{
    public class QuestionsService
    {
        public static string GetTextForQuestion(int id)
        {
            return QuestionsRepository.GetTextForQuestion(id);
        }
    }
}