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
using System.Globalization;

namespace DesafioInterProcess
{
    
    public partial class FormEditUsuario : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        string strSQL;
        public FormEditUsuario()
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
        private void btnEditPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Server=DESKTOP-EMHTR96 ;Database=BD_clinica ;User Id=vando2 ;Password=1234;");
               
                strSQL = "UPDATE USUARIO SET nome = @nome, data_nascimento = @data_nascimento, cpf = @cpf, sexo = @sexo WHERE id = @id" + " " +
                    "UPDATE ENDERECO SET rua = @rua, sigla_estado = @sigla_estado, bairro = @bairro, cep = @cep, numero_casa = @numero_casa WHERE id = @endereco_id";
                comando = new SqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@id", txtId.Text);
                comando.Parameters.AddWithValue("@nome", txtNome.Text);
                comando.Parameters.AddWithValue("@data_nascimento", DateTime.ParseExact(txtDataNascimento.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture));
                comando.Parameters.AddWithValue("@cpf", maskedTextBoxEditCpf.Text.Replace(",","").Replace("-",""));
                comando.Parameters.AddWithValue("@sexo", comboBoxSexo.Text);
                comando.Parameters.AddWithValue("@endereco_id", enderecoID);
                comando.Parameters.AddWithValue("@rua", txtRua.Text);
                comando.Parameters.AddWithValue("@sigla_estado", txtEstado.Text);
                comando.Parameters.AddWithValue("@bairro", txtBairro.Text);
                comando.Parameters.AddWithValue("@cep", txtCep.Text);
                comando.Parameters.AddWithValue("@numero_casa", txtNumero.Text);


                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
                this.Close();
            }
        }
        public void FormEditUsuarioLoad()

        {
            txtId.Text = codigoID;

            txtNome.Text = nome;

            txtDataNascimento.Text = dataNascimento.Substring(0,10);

            maskedTextBoxEditCpf.Text = cpf;

            comboBoxSexo.Text = sexo;

            txtRua.Text = rua;

            txtEstado.Text = estado;

            txtBairro.Text = bairro;

            txtCep.Text = cep;

            txtNumero.Text = numero;

        }

    }
}
