using System;
using System.Collections.Generic;
using System.Text;

namespace TESTEE
{
    internal class Carro
    {
        public string? Modelo { get; set; }
        public int Ano {  get; set; }
        public float Velocidade { get; set; }


        public void Acelerar()
        {
            Velocidade++;
            Console.WriteLine("Velocidade do carro e ", Velocidade);
        }


        public void Frear() => Console.WriteLine("Freando Carro...");

        //public void Frear()
        //{
        //    Console.WriteLine("Freando Carro...");
        //}
    }
}
