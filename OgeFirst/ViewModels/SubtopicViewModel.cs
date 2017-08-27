using OgeFirst.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OgeFirst.ViewModels
{
    public class SubtopicViewModel
    {
        public int SubtopicId { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public string VideoLink { get; set; }

        public SubtopicViewModel(int id)
        {
            this.SubtopicId = id;
            var dto = SubtopicsService.GetOne(id);

            this.Title = dto.Name + " (номер " + dto.TopicId + " из ОГЭ)";
            this.Name = dto.Name;
            this.Description = HttpUtility.HtmlDecode(dto.Description);
            this.VideoLink = dto.VideoLink;
        }
    }
}