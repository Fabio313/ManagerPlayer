using Dapper;
using ManagePlayer.Domain.Dto;
using ManagePlayer.Domain.Entities;
using ManagePlayer.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

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

        public async Task<bool> AddQuestionAsync(DecisoesDto questao)
        {
            string sql = @"INSERT INTO Decisoes 
                         (Nome, Descricao, OpcaoPositiva, RespostaPositiva, OpcaoNegativa, RespostaNegativa, Status)
                         Values(@Nome, @Descricao, @OpcaoPositiva, @RespostaPositiva, @OpcaoNegativa, @RespostaNegativa, @Status)";

            _conn.Open();
            await _conn.ExecuteAsync(
                sql: sql,
                param: new
                {
                    Nome = questao.Nome,
                    Descricao = questao.Descricao,
                    OpcaoPositiva = questao.OpcaoPositiva,
                    RespostaPositiva = questao.RespostaPositiva,
                    OpcaoNegativa = questao.OpcaoNegativa,
                    RespostaNegativa = questao.RespostaNegativa,
                    Status= questao.Status
                }
            );
            _conn.Close();
            
            return true;
        }

        public IEnumerable<DecisoesDto> GetQuestions()
        {
            string sql = @"SELECT Nome
                                 ,Descricao
                                 ,OpcaoPositiva
                                 ,RespostaPositiva
                                 ,OpcaoNegativa
                                 ,RespostaNegativa
                                 ,Status
                           FROM Decisoes";

            _conn.Open();
            var query = _conn.Query<DecisoesDto>(sql);
            _conn.Close();

            return query;
        }
    }
}
