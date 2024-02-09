using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GestAlunos
{
    public partial class Generos : Page
    {



        protected void Obter_dados()
        {
            string connetionString;
            SqlConnection con;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\GestAlunos\App_Data\bd_06.mdf;Integrated Security=True";
            con = new SqlConnection(connetionString);
            con.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = " ";
            sql = "select * from T_genero";

            Output = Output + "<table border='1'> <tr><th>ID</th><th>Genero</th><th>Ação</th>";
       

            command = new SqlCommand(sql, con);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Output = Output + "<tr><td>" + dataReader.GetValue(0) + "</td><td>" + dataReader.GetValue(1) + "</td></td><a href='EliminarG.aspx?id=" + dataReader.GetValue(0) + "' target='_self>Eliminar</a></td></tr>";

            }
            Response.Write(Output + "</table>");
            dataReader.Close();
            con.Close();
        }

        protected void b_inserir_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection con;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\GestAlunos\App_Data\bd_06.mdf;Integrated Security=True";
            con = new SqlConnection(connetionString);
            con.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";

            sql = "Insert into T_Genero(genero)" + "values ('" + txt_genero.Text + "')";
            command = new SqlCommand(sql, con);
            adapter.InsertCommand = new SqlCommand(sql, con);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Dados", "alert('Genero inserido com sucesso');window.location = 'Generos.aspx';", true);


        }
    }
}