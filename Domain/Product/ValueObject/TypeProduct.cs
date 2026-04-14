using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Product.ValueObject
{
    public class TypeProduct
    {
        public string Value { get; }

        private TypeProduct(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Tipo inválido.");

            Value = value;
        }

        //Cerveja
        public static TypeProduct LongNeck() => new("LongNeck");
        public static TypeProduct Garrafa() => new("Garrafa 600");
        public static TypeProduct Litro() => new("Litro");
        public static TypeProduct Latao() => new("Latão");

        //SemAlcool
        public static TypeProduct RefrigeranteLata() => new("RefrigeranteLata");
        public static TypeProduct Refrigerante600() => new("Refrigerante 600");

        public static TypeProduct AguaSemGaz() => new("Agua sem Gáz");
        public static TypeProduct AguaComGaz() => new("Agua com Gáz");

        public static TypeProduct Suco() => new("Agua sem Gáz");


    }
}