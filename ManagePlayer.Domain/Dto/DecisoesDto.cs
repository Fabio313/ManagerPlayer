using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ManagePlayer.Domain.Dto
{
    public class DecisoesDto
    {
        [JsonPropertyName("Nome")] 
        public string Nome { get; set; }

        [JsonPropertyName("Descricao")]
        public string Descricao { get; set; }

        [JsonPropertyName("OpcaoPositiva")]
        public string OpcaoPositiva { get; set; }

        [JsonPropertyName("RespostaPositiva")]
        public string RespostaPositiva { get; set; }

        [JsonPropertyName("OpcaoNegativa")]
        public string OpcaoNegativa { get; set; }

        [JsonPropertyName("RespostaNegativa")]
        public string RespostaNegativa { get; set; }

        [JsonPropertyName("Status")]
        public bool Status { get; set; }
    }
}
