using Newtonsoft.Json;

namespace SmsCSharpDotNetClient
{
  public class FetchRetornosRequest
  {

    [JsonProperty("usuario")]
    public string Usuario { get; set; }

    [JsonProperty("senha")]
    public string Senha { get; set; }
  }
}
