using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OgeFirst.DTO
{
    public class ResultDTO
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public double StudentAnswer { get; set; }
        public double RightAnswer { get; set; }
        public bool Correctness { get; set; }
    }
}