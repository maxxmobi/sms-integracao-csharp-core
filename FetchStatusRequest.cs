using Newtonsoft.Json;

namespace SmsCSharpDotNetClient
{

  public class FetchStatusRequest
  {

    [JsonProperty("usuario")]
    public string Usuario { get; set; }

    [JsonProperty("senha")]
    public string Senha { get; set; }

  }

}
