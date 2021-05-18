using Newtonsoft.Json;

namespace SmsCSharpDotNetClient
{

  public class StatusDoSMS
  {
    [JsonProperty("id")]
    public long id { get; set; }

    [JsonProperty("seuId")]
    public string seuId { get; set; }

    [JsonProperty("numero")]
    public string numero { get; set; }

    [JsonProperty("dataEnvio")]
    public string dataEnvio { get; set; }

    [JsonProperty("mensagem")]
    public string mensagem { get; set; }

    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("operadora")]
    public string operadora { get; set; }

    [JsonProperty("dataDaAtualizacaoDoStatus")]
    public string dataDaAtualizacaoDoStatus { get; set; }

  }

}
