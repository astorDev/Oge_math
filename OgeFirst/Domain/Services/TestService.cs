using OgeFirst.DTO;
using OgeFirst.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OgeFirst.Domain.Services
{
    public static class TestService
    {
        public static List<QuestionDTO> GetQuestionsForSubtopic(int id)
        {
            return QuestionsRepository.GetQuestionsForSubtopic(id);
        }

        public static List<ResultDTO> CheckSubmission(List<SubmissionDTO> submissions)
        {
            var result = new List<ResultDTO>();

            foreach (var answer in submissions)
            {
                int id = answer.Id;
                double studentAnswer = answer.StudentAnswer.Value;
                double rightAnswer = QuestionsRepository.GetAnswerForQuestion(id);
                bool correctness = studentAnswer == rightAnswer;
                string text = QuestionsRepository.GetTextForQuestion(id);

                result.Add(new ResultDTO
                {
                    Id = id,
                    Text = text,
                    StudentAnswer = studentAnswer,
                    RightAnswer = rightAnswer,
                    Correctness = correctness
                });
            }

            return result;
        }
    }
}