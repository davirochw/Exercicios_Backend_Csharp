using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.src
{
    internal class Cliente
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public string dt_nascimento { get; set; }
        public string renda_mensal { get; set; }
        public string estado_civil { get; set; }
        public string dependentes { get; set; }

        public VerificaDados verificaDados;

        public Cliente(string nome, string cpf, string dt_nascimento, string renda_mensal, string estado_civil, string dependentes)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.dt_nascimento = dt_nascimento;
            this.renda_mensal = renda_mensal;
            this.estado_civil = estado_civil;
            this.dependentes = dependentes;

            verificaDados = new VerificaDados(nome, cpf, dt_nascimento, estado_civil, dependentes);
        }

        public Cliente()
        {
        }

    }
}
