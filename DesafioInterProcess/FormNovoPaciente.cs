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
    public partial class FormNovoPaciente : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        string strSQL;
        public FormNovoPaciente()
        {
            InitializeComponent();
        }
        

        private void btnAddPacienteClick(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Server=DESKTOP-EMHTR96 ;Database=BD_clinica ;User Id=vando2 ;Password=1234;");
                strSQL = "INSERT INTO USUARIO (nome, data_nascimento, cpf, sexo, is_active) VALUES (@nome, @data_nascimento, @cpf, @sexo, 1)" + 
                    "INSERT INTO ENDERECO (rua, sigla_estado, bairro, cep, numero_casa, usuario_id) VALUES (@rua, @sigla_estado, @bairro, @cep, @numero_casa, scope_identity())";
                comando = new SqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@nome", txtNome.Text);
                comando.Parameters.AddWithValue("@data_nascimento", DateTime.ParseExact(txtDataNascimento.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture));
                comando.Parameters.AddWithValue("@cpf", maskedTextBoxCpf.Text.Replace(",", "").Replace("-", ""));
                comando.Parameters.AddWithValue("@sexo", comboBoxSexo.Text);
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


    }
}
