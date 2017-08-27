using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OgeFirst.DTO
{
    public class SubtopicDTO
    {
        public int SubtopicId { get; set; }
        public int TopicId { get; set; }
        public int Order { get; set; }
        public string Name { get; set; }
        
        public string Description { get; set; }
        public string VideoLink { get; set; }

    }
}