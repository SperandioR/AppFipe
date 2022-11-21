using AppFipe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFipe.Repositorios
{
    public class VeiculoRepositorios
    {
        public static List<Veiculos> ListarVeiculos()
        {
            List<Veiculos> lveiculos = new List<Veiculos>()
            {
                new Veiculos() { Id = 1, Tipo = "carros" } ,
                new Veiculos() { Id = 2, Tipo = "motos" } ,
                new Veiculos() { Id = 3, Tipo = "caminhoes" } ,
            
            };
            return lveiculos;



        }


    }
}
