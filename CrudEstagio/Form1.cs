using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CrudEstagio.Bll;
using CrudEstagio.Dao;


namespace CrudEstagio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listar();
            
        }

        public void fill_listbox()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Dados dado = new Dados();
            salvar(dado);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dados dado = new Dados();
            alterar(dado);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dados dado = new Dados();
            excluir(dado);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DadosBll bll = new DadosBll();

            try
            {
                dataGridView1.DataSource = bll.listarPorCidade();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro Exibir Dados"+ erro);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void salvar(Dados dado)
        {
            DadosBll dadoBll = new DadosBll();

            dado.Nome = txtNome.Text;
            dado.Sexo = txtSexo.Text;
            dado.DataDado = txtData.Text;
            dado.Cidade = txtCidade.Text;

            dadoBll.salvar(dado);

            MessageBox.Show("Contato Adicionado");
            listar();
            limparCampos();
        }

        private void alterar(Dados dado) 
        {
            DadosBll dadoBll = new DadosBll();

            dado.CodContato = Convert.ToInt32(txtCod.Text);
            dado.Nome = txtNome.Text;
            dado.Sexo = txtSexo.Text;
            dado.DataDado = txtData.Text;
            dado.Cidade = txtCidade.Text;

            dadoBll.alterar(dado);

            MessageBox.Show("Contato Editado");
            listar();
            limparCampos();
                
        }

        private void excluir(Dados dado)
        {
            DadosBll dadoBll = new DadosBll();

            dado.CodContato = Convert.ToInt32(txtCod.Text);

            dadoBll.excluir(dado);

            MessageBox.Show("Contato Excluido");
            listar();
            limparCampos();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listar()
        {
            DadosBll dadoBll = new DadosBll();

            dataGridView1.DataSource = dadoBll.listar();
        }

        private void limparCampos()
        {
            txtCod.Clear();
            txtNome.Clear();
            txtSexo.SelectedIndex = -1;
            txtCidade.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCod.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSexo.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtData.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtCidade.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void txtSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
