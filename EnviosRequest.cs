using System.Collections.Generic;
using Newtonsoft.Json;

namespace SmsCSharpDotNetClient
{
    public class EnvioRequest
    {

        [JsonProperty("usuario")]
        public string Usuario { get; set; }

        [JsonProperty("senha")]
        public string Senha { get; set; }

        [JsonProperty("requisicao")]
        public List<MensagemSms> Requisicao { get; set; }

    }
}