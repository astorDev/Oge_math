using OgeFirst.DTO;
using OgeFirst.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OgeFirst.Domain.Services
{
    public class RegistrationService
    {
        public static bool IsAdmin(RegistrationDTO dto)
        {
            if (!AccountsRepository.Exists(dto))
                return false;

            return AccountsRepository.GetStatus(dto) == 1;
        }
    }
}