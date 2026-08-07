using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio
{
    internal class AgendaTelefonica
    {
        Dictionary<string, string> colecao {  get; set; }


        public void inserir(string nome, string numero)
        {
            colecao.Add(nome, numero);
        }

        public string buscarNumero(string nome)
        {
            if (colecao.TryGetValue(nome, out string numero))
            {
                return numero;
            }
            else return "a";
            }
        

        public void remover(string nome)
        {
            colecao.Remove(nome);
        }

        //public int tamanho()
        //{

        //}
        
    }
}
