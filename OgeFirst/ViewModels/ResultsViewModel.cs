using OgeFirst.Domain.Services;
using OgeFirst.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OgeFirst.ViewModels
{
    public class ResultsViewModel
    {
        public List<CheckedAnswerViewModel> CheckedAnswers { get; set; }
        public string Title { get; set; }

        public ResultsViewModel()
        {

        }

        public ResultsViewModel(TestViewModel submission)
        {
            this.CheckedAnswers = new List<CheckedAnswerViewModel>();
            var answers = submission.Questions;
            var answerDtos = new List<SubmissionDTO>();


            foreach (var answer in answers)
            {
                answerDtos.Add(answer.ToDto());
            }

            var dtos = TestService.CheckSubmission(answerDtos);

            Title = SubtopicsService.GetOne(submission.TopicId).Name;
            int rightAnswersCount = 0;
            foreach (var answer in dtos)
            {
                rightAnswersCount += Convert.ToInt32(answer.Correctness);
            }

            Title += ". Результат: " + rightAnswersCount.ToString() + "/" + dtos.Count;

            dtos.ForEach(d => CheckedAnswers.Add(new CheckedAnswerViewModel(d)));
        }
    }
}