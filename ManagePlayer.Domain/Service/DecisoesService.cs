using AutoMapper;
using ManagePlayer.Domain.Dto;
using ManagePlayer.Domain.Entities;
using ManagePlayer.Domain.Interfaces.Repositories;
using ManagePlayer.Domain.Interfaces.Service;
using ManagePlayer.Domain.MapperProfiles;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ManagePlayer.Domain.Service
{
    public class DecisoesService : IDecisoesService
    {
        public IDecisoesRepository _decisoesRepository;
        private readonly IMapper _mapper;

        public DecisoesService(
            IDecisoesRepository decisoesRepository
        )
        {
            _decisoesRepository = decisoesRepository;
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<DecisoesProfile>();
                cfg.CreateMap<DecisoesDto, Question>();
            });
            _mapper = config.CreateMapper();
        }

        public async Task<bool> AddQuestionsAsync(IEnumerable<Question> decisoesDto)
        {
            try 
            {
                foreach(var decisao in decisoesDto)
                {
                    await _decisoesRepository.AddQuestionAsync(_mapper.Map<DecisoesDto>(decisao));
                }
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public IEnumerable<Question> GetQuestions()
        {
            try
            {
                var questions = new List<Question>(); 
                var decisoesDto = _decisoesRepository.GetQuestions();
                
                foreach(var decisaoDto in decisoesDto)
                {
                    questions.Add(_mapper.Map<Question>(decisaoDto));
                }
                return questions;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}
