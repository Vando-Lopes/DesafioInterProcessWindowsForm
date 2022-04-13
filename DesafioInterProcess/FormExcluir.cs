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
    public partial class FormExcluir : Form
    {
        public FormExcluir()
        {
            InitializeComponent();
        }
        SqlConnection conexao;
        SqlDataAdapter dataAdapter;
        SqlCommand comando;
        string strSQL;
        
        public string id;
        private void btnSimExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Server=DESKTOP-EMHTR96 ;Database=BD_clinica ;User Id=vando2 ;Password=1234;");
                strSQL = "DELETE FROM USUARIO WHERE ID = @id";
                comando = new SqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@id", id);
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

        private void btnNaoExcluir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
