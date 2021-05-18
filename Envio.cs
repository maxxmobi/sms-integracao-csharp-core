using Newtonsoft.Json;

namespace SmsCSharpDotNetClient
{
    public class MensagemSms
    {
        [JsonProperty("idCliente")]
        public string IdCliente { get; set; }

        [JsonProperty("numero")]
        public string Numero { get; set; }

        [JsonProperty("mensagem")]
        public string Mensagem { get; set; }
    }
}