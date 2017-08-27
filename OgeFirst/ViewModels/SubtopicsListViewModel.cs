using OgeFirst.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OgeFirst.ViewModels
{
    public class SubtopicsListViewModel
    {
        public List<SubtopicBasicViewModel> Subtopics { get; set; }

        public SubtopicsListViewModel()
        {
            this.Subtopics = new List<SubtopicBasicViewModel>();

            var dtos = SubtopicsService.GetBasics();
            foreach (var dto in dtos)
            {
                this.Subtopics.Add(new SubtopicBasicViewModel(dto));
            }
        }
    }
}