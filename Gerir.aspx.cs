using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace GestAlunos
{
    public partial class Gerir : Page
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
            sql = "Select * from T_aluno, T_genero, T_turma where " + "genero_id = T_genero.id AND turma_id = T_turma.id";
            Output = Output + "<table border='1'> <tr><th>ID</th><th>Nome</th><th>E-mail</th>";
            Output = Output + "<th>Data Nasc.</th><th>Morada</th><th>Género</th><th>Turma</th></tr>";

            command = new SqlCommand(sql, con);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Output = Output +"<tr><td>"+dataReader.GetValue(0) + "</td><td>" + dataReader.GetValue(1) + "</td><td>" + dataReader.GetValue(2) + "</td><td>" + dataReader.GetValue(3) + "</td><td>" + dataReader.GetValue(4) + "</td><td>" + dataReader.GetValue(10) + "</td><td>" + dataReader.GetValue(8) + "</td><td>input type='button' Value='Editar'"+ "onclick=window.open('Edita2.aspx?id=" + dataReader.GetValue(0)+"')/>" + "&nbsp<input type='button' Value='Eliminar' onclick=window.open('Eliminar.aspx?id="+dataReader.GetValue(0)+"')/></td></tr>";

            }
            Response.Write(Output+"</table>");
            dataReader.Close();
            con.Close();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}




