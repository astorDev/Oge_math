using OgeFirst.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OgeFirst.ViewModels
{
    public class CheckedAnswerViewModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public double StudentAnswer { get; set; }
        public double RightAnswer { get; set; }
        public string Result { get; set; }
        public string ResultCss { get; set; }

        public CheckedAnswerViewModel()
        {

        }

        public CheckedAnswerViewModel(ResultDTO dto)
        {
            this.Id = dto.Id;
            this.Text = HttpUtility.HtmlDecode(dto.Text);
            this.StudentAnswer = dto.StudentAnswer;
            this.RightAnswer = dto.RightAnswer;
            this.Result = dto.Correctness ? "Верно" : "Неверно";
            this.ResultCss = dto.Correctness ? "correct" : "incorrect";
        }
    }
}