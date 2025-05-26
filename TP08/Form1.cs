using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP08
{
    public partial class Form1 : Form
    {
        private ControllerTarefas tt = new ControllerTarefas();
        public Form1()
        {
            InitializeComponent();
            AtualizarLista();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            string nome = txt_Nome.Text;
            DateTime data = dtp_Data.Value;
            bool status = false;

            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Erro de validação", "Erro");
                return;
            }

            tt.CadastrarCliente(nome, data.ToString("yyyy-MM-dd"), status); // salva como string formatada
            tt.SalvarDados();
            AtualizarLista();
            MessageBox.Show("Cliente adicionado");
        }
        private void Limpar()
        {
            txt_Nome.Clear();
            dtp_Data.Value = DateTime.Today;
            ckb_Status.Checked = false;
            ckb_Status.Enabled = false;
        }
        private void AtualizarLista()
        {
            List<Tarefa> tarefas = tt.CarregarDados();
            dtg_Cliente.DataSource = null;
            dtg_Cliente.DataSource = tarefas;
            dtg_Cliente.ClearSelection();

            Limpar();

            if (dtg_Cliente.Rows.Count > 0)
            {
                dtg_Cliente.Rows[0].Selected = true;
            }
            Limpar();
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Nome.Text))
            {
                MessageBox.Show("Erro de validação", "Erro");
                return;
            }
            List<Tarefa> clientes = tt.CarregarDados();
            var clienteselecionado = clientes[dtg_Cliente.SelectedRows[0].Index];
            clienteselecionado.Nome = txt_Nome.Text;
            clienteselecionado.Data = dtp_Data.Value.ToString("yyyy-MM-dd");
            clienteselecionado.Status = ckb_Status.Checked;

            tt.SalvarDados();
            AtualizarLista();
            MessageBox.Show("Cliente atualizado");
        }

        private void dtg_Cliente_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            List<Tarefa> tarefas = tt.CarregarDados();
            int linhaselecionada = dtg_Cliente.SelectedRows[0].Index;
            var clienteselecionado = tarefas[linhaselecionada];

            txt_Nome.Text = clienteselecionado.Nome;
            DateTime data = dtp_Data.Value; 
            ckb_Status.Checked = clienteselecionado.Status;
            ckb_Status.Enabled = true;
        }

        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            int linhaselecionada = dtg_Cliente.SelectedRows[0].Index;
            if (/*listBox1.SelectedIndex == -1 ||*/ dtg_Cliente.SelectedRows.Count == 0 || dtg_Cliente.SelectedRows[0].Index < 0)
            {
                MessageBox.Show("Selecione uma tarefa para deletar", "Erro");
                return;
            }
            List<Tarefa> tarefas = tt.CarregarDados();
            //clientes.RemoveAt(listBox1.SelectedIndex);
            tarefas.RemoveAt(linhaselecionada);
            tt.SalvarDados();
            AtualizarLista();
            MessageBox.Show("Tarefa deletada com sucesso");
        }

        private void dtg_Cliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtg_Cliente_SelectionChanged(object sender, EventArgs e)
        {
            if (dtg_Cliente.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtg_Cliente.SelectedRows[0];

                txt_Nome.Text = row.Cells[0].Value?.ToString();

                if (DateTime.TryParse(row.Cells[1].Value?.ToString(), out DateTime parsedDate))
                {
                    dtp_Data.Value = parsedDate;
                }
                else
                {
                    dtp_Data.Value = DateTime.Today;
                }
            }
        }
    }
}
