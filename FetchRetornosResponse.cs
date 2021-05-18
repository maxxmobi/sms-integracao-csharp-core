using Newtonsoft.Json;
using System.Collections.Generic;

namespace SmsCSharpDotNetClient
{

  public class FetchRetornosResponse
  {

    [JsonProperty("status")]
    public string status { get; set; }
    //public EnumStatusDoRequest status { get; set; }

    [JsonProperty("listaResposta")]
    public List<Retorno> listaResposta { get; set; }

  }

}
