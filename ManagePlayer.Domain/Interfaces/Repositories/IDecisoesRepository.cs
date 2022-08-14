using ManagePlayer.Domain.Dto;
using ManagePlayer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagePlayer.Domain.Interfaces.Repositories
{
    public interface IDecisoesRepository
    {
        IList<DecisoesDto> GetQuestions();
        bool AddQuestion(DecisoesDto questao);
    }
}
