using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DesafioInterProcess
{
    public partial class Form1 : Form
    {
        SqlConnection conexao;
        SqlDataAdapter dataAdapter;
        public Form1()
        {
            InitializeComponent();
        }
        public string nome;
        public string dataNascimento;
        public string cpf;
        public string sexo;
        public string rua;
        public string estado;
        public string bairro;
        public string cep;
        public string numero;
        public string codigoID;
        public string enderecoID;

        private void btnNovoPacienteClick(object sender, EventArgs e)
        {
            FormNovoPaciente formNovoPaciente = new FormNovoPaciente();
            formNovoPaciente.Show();
        }
        private void btnListarPacientes_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Server=DESKTOP-EMHTR96 ;Database=BD_clinica ;User Id=vando2 ;Password=1234;");
                string consulta = "SELECT USUARIO.ID, USUARIO.NOME, USUARIO.data_nascimento, USUARIO.cpf, USUARIO.sexo, ENDERECO.ID AS endereco_id, ENDERECO.rua, ENDERECO.sigla_estado, ENDERECO.bairro, ENDERECO.cep, ENDERECO.numero_casa FROM ENDERECO INNER JOIN USUARIO ON(ENDERECO.usuario_id = USUARIO.id) WHERE USUARIO.is_active = 1";
                DataSet dataSet = new DataSet();

                dataAdapter = new SqlDataAdapter(consulta, conexao);

                conexao.Open();

                dataAdapter.Fill(dataSet);
                dataGridPacientes.DataSource = dataSet.Tables[0];
                dataGridPacientes.Columns["ID"].Visible = false;
                dataGridPacientes.Columns["endereco_id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
            }
        }
        private void obtemDadosGrid(int index)
        {

            nome = dataGridPacientes[1, index].Value.ToString();
            dataNascimento = dataGridPacientes[2, index].Value.ToString();
            cpf = dataGridPacientes[3, index].Value.ToString();
            sexo = dataGridPacientes[4, index].Value.ToString();
            rua = dataGridPacientes[6, index].Value.ToString();
            estado = dataGridPacientes[7, index].Value.ToString();
            bairro = dataGridPacientes[8, index].Value.ToString();
            cep = dataGridPacientes[9, index].Value.ToString();
            numero = dataGridPacientes[10, index].Value.ToString();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            int indexLine = dataGridPacientes.CurrentRow == null ? -1 : dataGridPacientes.CurrentRow.Index;
            try
            {
                codigoID = dataGridPacientes[0, indexLine].Value.ToString();
                enderecoID = dataGridPacientes[5, indexLine].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro..." + ex.Message);
            }
            if (indexLine >= 0)
            {

                obtemDadosGrid(indexLine);

                FormEditUsuario formEditUsuario = new FormEditUsuario
                {
                    codigoID = codigoID,
                    enderecoID = enderecoID,
                    nome = nome,
                    dataNascimento = dataNascimento,
                    cpf = cpf,
                    sexo = sexo,
                    rua = rua,
                    estado = estado,
                    bairro = bairro,
                    cep = cep,
                    numero = numero
                };

                formEditUsuario.FormEditUsuarioLoad();

                formEditUsuario.ShowDialog();

                dataGridPacientes.Update();

            }
        }

        private void btnExcluirPaciente_Click(object sender, EventArgs e)
        {
            int indexLine = dataGridPacientes.CurrentRow == null ? -1 : dataGridPacientes.CurrentRow.Index;
            try
            {
                codigoID = dataGridPacientes[0, indexLine].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro..." + ex.Message);
            }
            if (indexLine >= 0)
            {
                FormExcluir formExcluir = new FormExcluir
                {
                    id = codigoID
                };

                formExcluir.ShowDialog();

            }

        }
    }
}
