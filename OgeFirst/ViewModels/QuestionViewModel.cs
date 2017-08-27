using OgeFirst.Domain.Services;
using OgeFirst.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OgeFirst.ViewModels
{
    public class QuestionViewModel
    {
        public int Id { get; set; }
        public string Text { get; set; }

        [Required(ErrorMessage = "Заполните ответ")]
        public double? StudentAnswer { get; set; }

        public QuestionViewModel(QuestionDTO dto)
        {
            this.Id = dto.Id;
            this.Text = HttpUtility.HtmlDecode(dto.Text);
            this.StudentAnswer = null;
        }

        public QuestionViewModel(QuestionViewModel s)
        {
            this.Id = s.Id;
            this.StudentAnswer = s.StudentAnswer;
            this.Text = HttpUtility.HtmlDecode(QuestionsService.GetTextForQuestion(s.Id));
        }

        public QuestionViewModel()
        {

        }

        public SubmissionDTO ToDto()
        {
            return new SubmissionDTO
            {
                Id = this.Id,
                StudentAnswer = this.StudentAnswer
            };
        }
    }
}