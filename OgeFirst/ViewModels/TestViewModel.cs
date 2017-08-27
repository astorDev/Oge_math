using OgeFirst.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OgeFirst.ViewModels
{
    public class TestViewModel
    {
        public string Title { get; set; }
        public List<QuestionViewModel> Questions { get; set; }
        public int TopicId { get; set; }

        public TestViewModel(int id, TestType type)
        {
            this.Questions = new List<QuestionViewModel>();
            this.TopicId = id;

            if (type == TestType.Subtopic)
            {
                this.Title = SubtopicsService.GetOne(id).Name + " - тест";
                var dtos = TestService.GetQuestionsForSubtopic(id);

                foreach (var dto in dtos)
                {
                    this.Questions.Add(new QuestionViewModel(dto));
                }
            }
        }

        public TestViewModel(TestViewModel submission)
        {
            this.Title = submission.Title;
            this.Questions = submission.Questions.ConvertAll(s => new QuestionViewModel(s));   
        }

        public TestViewModel()
        {

        }
    }

    public enum TestType
    {
        Subtopic,
        Topic
    }
}