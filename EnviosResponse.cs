using Newtonsoft.Json;

namespace SmsCSharpDotNetClient
{
    public class EnvioResponse {

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("resposta")]
        public string Resposta { get; set; }

        [JsonProperty("lote")]
        public string Lote { get; set; }

    }
}