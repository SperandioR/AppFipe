using AppFipe.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AppFipe.Repositorios
{
    public class AnoRepositorio
    {
        //Criando um Metodo para carregar ano do automóveis.
        public static List<Ano> ListarAnoCarro(string codigo, string TipoVeiculo, string CodCarro)
        {
            var url = $@"https://parallelum.com.br/fipe/api/v1/{TipoVeiculo}/marcas/{codigo}/modelos/{CodCarro}/anos";
            var resposta = Util.HttpClientUtil.ConsHttpClientAsync(url);

            List<Ano> Ano = JsonSerializer.Deserialize<List<Ano>>(resposta.Result);


            return Ano;


        }

    }

}