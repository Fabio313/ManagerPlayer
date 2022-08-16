using ManagePlayer.Domain.Dto;
using ManagePlayer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ManagePlayer.Domain.Interfaces.Repositories
{
    public interface IDecisoesRepository
    {
        IEnumerable<DecisoesDto> GetQuestions();
        Task<bool> AddQuestionAsync(DecisoesDto questao);
    }
}
