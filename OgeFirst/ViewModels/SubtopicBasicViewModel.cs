using OgeFirst.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OgeFirst.ViewModels
{
    public class SubtopicBasicViewModel
    {
        public int SubtopicId { get; set; }
        public string FullName { get; set; }

        public SubtopicBasicViewModel(SubtopicBasicDTO dto)
        {
            this.FullName = "#" + dto.TopicId.ToString() + "." + dto.Order.ToString() + " - " + dto.Name;
            this.SubtopicId = dto.SubtopicId;
        }
    }
}