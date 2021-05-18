using Newtonsoft.Json;

namespace SmsCSharpDotNetClient
{

  public class Retorno {

    [JsonProperty("id")]
    private long id { get; set; }

    [JsonProperty("mensagem")]
    private string mensagem { get; set; }

    [JsonProperty("seuId")]
    private string seuId { get; set; }
    
    [JsonProperty("data")]
    private string data { get; set; }

    [JsonProperty("numero")]
    private string numero { get; set; }

    [JsonProperty("operadora")]
    private string operadora { get; set; }

  }

}
