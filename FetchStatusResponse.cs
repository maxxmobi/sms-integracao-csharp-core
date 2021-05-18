using Newtonsoft.Json;
using System.Collections.Generic;

namespace SmsCSharpDotNetClient
{

  public class FetchStatusResponse {

    [JsonProperty("status")]
    public EnumStatusDoRequest status  { get; set; }

    [JsonProperty("listaDeStatus")]
    public List<StatusDoSMS> listaDeStatus { get; set; }

  }

}
