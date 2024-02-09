using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GestAlunos
{
    public partial class Editar : Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            txt_numero.Text = Request.QueryString["id"];
            string connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\GestAlunos\App_Data\bd_06.mdf;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connetionString))
            {
                con.Open();

                SqlCommand command;
                SqlDataReader dataReader;
                String sql, x;
                sql = "Select * from T_genero";
                command = new SqlCommand(sql, con);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    x = dataReader.GetValue(0) + "";
                    dd_genero.Items.Add(new ListItem((string)dataReader.GetValue(1), x));
                }
                dataReader.Close();

                sql = "Select * from T_turma";
                command = new SqlCommand(sql, con);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    x = dataReader.GetValue(0) + "";
                    dd_turma.Items.Add(new ListItem((string)dataReader.GetValue(1), x));
                }

                dataReader.Close();
                sql = "SELECT * FROM T_aluno WHERE numero='" + txt_numero.Text + "'";
                command = new SqlCommand(sql, con);
                dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    txt_nome.Text = dataReader.GetValue(1).ToString();
                    txt_email.Text = dataReader.GetValue(2).ToString();
                    txt_data_nasc.Text = dataReader.GetValue(3).ToString();
                    txt_morada.Text = dataReader.GetValue(4).ToString();
                    dd_genero.SelectedValue = dataReader.GetValue(5).ToString();
                    dd_turma.SelectedValue = dataReader.GetValue(6).ToString();
                }

                dataReader.Close();

                con.Close();
            }
        }

        protected void b_alterar_Click(object sender, EventArgs e)
        {
            string connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\GestAlunos\App_Data\bd_06.mdf;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connetionString))
            {
                con.Open();

                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();
                String sql = "";

                sql = "UPDATE T_Aluno SET nome='" + txt_nome.Text + "', email='" + txt_email.Text + "', data_nasc='" + txt_data_nasc.Text + "', morada='" + txt_morada.Text + "', genero_id=" + dd_genero.SelectedValue + ", turma_id=" + dd_turma.SelectedValue + " WHERE numero=" + txt_numero.Text;
                command = new SqlCommand(sql, con);
                adapter.InsertCommand = new SqlCommand(sql, con);
                adapter.InsertCommand.ExecuteNonQuery();

                command.Dispose();
                con.Close();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Dados", "alert('Dados alterados com sucesso');window.location = 'Listagem.aspx';", true);
            }
        }
    }
}