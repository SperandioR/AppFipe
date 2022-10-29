using System; //Biblioteca C#.
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFipe.Util
{
    public class HttpClientUtil // Alterando a classe interno para public.
    {
        //Criando Métodos com nome Http... e adicionando endereço.
        public static async Task<String> ConsHttpClientAsync(String endereco)
        {
            
           //criando uma requisição Http para buscar uma requsição da Url.
           var client = new HttpClient();               
            try
            {
                HttpRequestMessage response = await client.GetAsync(endereco).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                return responseBody;

            }
            catch (Exception)
            {
                return "";
                
            }

        }

    }
}
