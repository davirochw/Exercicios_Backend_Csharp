using System.IO;
using Ex01.src;
using Newtonsoft.Json;

var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\clientes.json");
var clientes = JsonConvert.DeserializeObject<List<Cliente>>(json);


foreach (var c in clientes)
{
    string nome = c.nome;
    string cpf = c.cpf;
    string dt_nascimento = c.dt_nascimento;
    string renda_mensal = c.renda_mensal;
    string estado_civil = c.estado_civil;
    string dependentes = c.dependentes;

    Cliente cliente = new Cliente(nome, cpf, dt_nascimento, renda_mensal, estado_civil, dependentes);
}


// var errosExibidos = JsonConvert.SerializeObject(cliente, Formatting.Indented);
