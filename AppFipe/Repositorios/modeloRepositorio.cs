using AppFipe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AppFipe.Repositorios
{
    public class modeloRepositorio
    {
        public static List<modelos> ListarModelos(string codigo, string TipoVeiculo)
        {
            var url = $@"https://parallelum.com.br/fipe/api/v1/{TipoVeiculo}/marcas/{codigo}/modelos";

            var resposta = Util.HttpClientUtil.ConsHttpClientAsync(url).Result;

            var Modelos = Newtonsoft.Json.JsonConvert.DeserializeObject<modeloFabricante>(resposta);   


            return Modelos.modelos;

        }

    }
}
