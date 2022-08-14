using ManagePlayer.Domain.Dto;
using ManagePlayer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagePlayer.Domain.Interfaces.Service
{
    public interface IDecisoesService
    {
        IEnumerable<Question> GetQuestions();
        bool AddQuestions(IEnumerable<DecisoesDto> decisoesDto);
    }
}
