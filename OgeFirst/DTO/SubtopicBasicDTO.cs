using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OgeFirst.DTO
{
    public class SubtopicBasicDTO
    {
        public int SubtopicId { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public int TopicId { get; set; }
    }
}