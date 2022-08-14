using AutoMapper;
using ManagePlayer.Domain.Dto;
using ManagePlayer.Domain.Entities;
using ManagePlayer.Domain.Interfaces.Repositories;
using ManagePlayer.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagePlayer.Domain.Service
{
    public class DecisoesService : IDecisoesService
    {
        public IDecisoesRepository _decisoesRepository;
        private readonly IMapper _mapper;

        DecisoesService(
            IDecisoesRepository decisoesRepository,
            IMapper mapper
        )
        {
            _decisoesRepository = decisoesRepository;
            _mapper = mapper;
        }

        public bool AddQuestions(IEnumerable<DecisoesDto> decisoesDto)
        {
            try 
            {
                foreach(var decisao in decisoesDto)
                {
                    _decisoesRepository.AddQuestion(decisao);
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
            catch(Exception)
            {
                return null;
            }
        }
    }
}
