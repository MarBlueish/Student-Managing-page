using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GestAlunos
{
    public partial class Eliminar : Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection con;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\GestAlunos\App_Data\bd_06.mdf;Integrated Security=True";
            con = new SqlConnection(connetionString);
            con.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = " ";
            sql = "Select * from T_genero";
            string x;
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
            Response.Write(Output);
            dataReader.Close();
            con.Close();

        }

        protected void b_eliminar_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection con;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\GestAlunos\App_Data\bd_06.mdf;Integrated Security=True";
            con = new SqlConnection(connetionString);
            con.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";
            sql = "delete t_aluno where id=" + txt_numero.Text;
            command = new SqlCommand(sql, con);
            adapter.DeleteCommand = new SqlCommand(sql, con);
            adapter.DeleteCommand.ExecuteNonQuery();

            command.Dispose();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Dados", "alert('Dados eliminados com sucesso');window.location = 'Listagem.aspx';", true);


        }
    }
}