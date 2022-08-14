using Dapper;
using ManagePlayer.Domain.Dto;
using ManagePlayer.Domain.Entities;
using ManagePlayer.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ManagePlayer.Infrastructure.Data.Sql.Repositories
{
    public class DecisoesRepository : IDecisoesRepository
    {
        public SqlConnection _conn;
        public DecisoesRepository()
        {

            string connString = "Data Source=DESKTOP-BTO2B72;Initial Catalog=FeiraProfissão;Persist Security Info=True;User ID=sa;Password=locao2.0";
            _conn = new SqlConnection(connString);
        }

        public bool AddQuestion(DecisoesDto questao)
        {
            string sql = @"INSERT INTO Decisoes 
                         (Nome, Descricao, OpcaoPositiva, RespostaPositiva, OpcaoNegativa, RespostaNegativa, Status)
                         Values(@Nome, @Descricao, @OpcaoPositiva, @RespostaPositiva, @OpcaoNegativa, @RespostaNegativa, @Status);";

            _conn.Open();
            _conn.Execute(sql,questao);
            _conn.Close();
            
            return true;
        }

        public IList<DecisoesDto> GetQuestions()
        {
            return new List<DecisoesDto>();
        }
    }
}
