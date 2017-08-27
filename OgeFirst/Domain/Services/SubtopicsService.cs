using OgeFirst.DTO;
using OgeFirst.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OgeFirst.Domain.Services
{
    public class SubtopicsService
    {
        public static List<SubtopicBasicDTO> GetBasics()
        {
            return SubtopicsRepository.GetBasics();
        }

        public static SubtopicDTO GetOne(int id)
        {
            return SubtopicsRepository.GetOne(id);
        }
    }
}