using ManagePlayer.Domain.Dto;
using ManagePlayer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ManagePlayer.Domain.Interfaces.Service
{
    public interface IDecisoesService
    {
        IEnumerable<Question> GetQuestions();
        Task<bool> AddQuestionsAsync(IEnumerable<Question> decisoesDto);
    }
}
