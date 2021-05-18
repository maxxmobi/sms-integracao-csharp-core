using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using Refit;
using Newtonsoft.Json;

namespace SmsCSharpDotNetClient
{
    class Program
    {
        static async Task Main(string[] args)
        {

            var cliente = RestService.For<IMaxxmobiSmsApi>("https://api.maxx.mobi");
            string myusername = "";
            string mypassword = "";

            //Inicio do Exemplo de Envio de Mensagens em lote
            Console.WriteLine("Envio de SMS");
            try {
               
                var enviosResponse = await cliente.EnviaMensagensEmLoteAsync(new EnvioRequest() {
                    Usuario = myusername,
                    Senha = mypassword,
                    Requisicao = new List<MensagemSms>() {
                        new MensagemSms() {
                            IdCliente = "uis001",
                            Numero = "5571991919449",
                            Mensagem = "Teste Maxxmobi"
                        }
                    }
                });

                if(0 == enviosResponse.Status){
                    Console.WriteLine("Sms Enviado Status = " + enviosResponse.Resposta +
                     " Lote = " + enviosResponse.Lote);    
                } else {
                    throw new Exception(enviosResponse.Resposta);
                }
                

            }
            catch(Exception e) {

                Console.WriteLine("Erro ao enviar Sms!" + e.Message);

            
            }
            //Fim do Exemplo de Envio de Mensagens em Lote

            //Inicio do Exemplo da Consulta de Status de SMS
            Console.WriteLine("Busca Status Nao Lidos");
            try {

                var fetchStatusResponse = await cliente.BuscaStatusNaoLidos(new FetchStatusRequest() {
                  Usuario = myusername,
                  Senha = mypassword
                });

               if(EnumStatusDoRequest.SUCESSO == fetchStatusResponse.status) {

                 foreach(var status in fetchStatusResponse.listaDeStatus) {
                    Console.WriteLine(JsonConvert.SerializeObject(status));   
                 }
               
               
               } else if (EnumStatusDoRequest.NENHUM_ITEM_ENCONTRADO == fetchStatusResponse.status) {
               
                 Console.WriteLine("Nenhum Status Encontrado, espere mais um pouco antes de fazer a próxima consulta");

               } else {

                 Console.WriteLine("Ocorreu um erro");
               
               }

            }
            catch(Exception e) {

                Console.WriteLine("Nenhum Status Encontrado: " + e.Message);

            }
            //Fim do Exemplo da Consulta de Status de SMS

            //Inicio do Exemplo da Consulta de Retornos de SMS
            Console.WriteLine("Busca de Retornos de SMS Nao Lidos");
            try {

                var fetchRetornosResponse = await cliente.BuscaRetornosNaoLidos(new FetchRetornosRequest() {
                  Usuario = myusername,
                  Senha = mypassword
                }); 

               if("OK" == fetchRetornosResponse.status){

                 foreach(var mo in fetchRetornosResponse.listaResposta) {
                    Console.WriteLine(JsonConvert.SerializeObject(mo));   
                 }
               
               } else if ("SEM DADOS" == fetchRetornosResponse.status) {
               
                 Console.WriteLine("Nenhum Retorno Encontrado, espere mais um pouco antes de fazer a próxima consulta");

               } else {

                 Console.WriteLine("Ocorreu um erro" + JsonConvert.SerializeObject(fetchRetornosResponse) );
               
               }
               
            }
            catch(Exception e) {

                Console.WriteLine("Nenhum Retorno Encontrado: " + e.Message);

            }
            //Fim do Exemplo da Consulta de Retornos de SMS

        }
    }
}
