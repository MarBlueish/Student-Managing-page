using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace GestAlunos
{
    public partial class Listagem : Page
    {


        protected void Lista_dados()
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

            command = new SqlCommand(sql, con);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + " - " + dataReader.GetValue(2) + " - " + dataReader.GetValue(3) + " - " + dataReader.GetValue(4) + " - " + dataReader.GetValue(8) + " - " + dataReader.GetValue(10) + "</br>";

            }
            Response.Write(Output);
            dataReader.Close();
            con.Close();
        }
    }
}