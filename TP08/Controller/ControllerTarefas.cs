using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace TP08
{
    internal class ControllerTarefas
    {
        private string arquivoCaminho = "tarefas.json";
        private List<Tarefa> tarefas = new List<Tarefa>();

        public List<Tarefa> CarregarDados()
        {
            if (File.Exists(arquivoCaminho))
            {
                string json = File.ReadAllText(arquivoCaminho);
                tarefas = JsonSerializer.Deserialize<List<Tarefa>>(json) ?? new List<Tarefa>();
            }

            return tarefas;
        }

        public void CadastrarCliente(string nome, string data, bool status)
        {
            //int novoId = tarefas.Count > 0 ? tarefas[tarefas.Count - 1].Id + 1 : 0;
            tarefas.Add(new Tarefa
            {
                Nome = nome,
                Data = data,
                Status = false
            });
        }

        public void SalvarDados()
        {
            string json = JsonSerializer.Serialize(tarefas);
            File.WriteAllText(arquivoCaminho, json);
        }
    }

}
