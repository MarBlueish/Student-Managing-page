using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GestAlunos
{
    public partial class EliminaT : Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            txt_id.Text= Request.QueryString["ID"];
            string connetionString;
            SqlConnection con;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\GestAlunos\App_Data\bd_06.mdf;Integrated Security=True";
            con = new SqlConnection(connetionString);
            con.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql;

            if (int.TryParse(Request.QueryString["ID"], out int id))
            {
                
                sql = $"SELECT * FROM T_turma WHERE id = {id}";
                command = new SqlCommand(sql, con);

                con.Open(); 

                dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    txt_turma.Text = dataReader.GetValue(1).ToString();
                } 
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
            sql = "delete T_turma where id=" + txt_id.Text;
            command = new SqlCommand(sql, con);
            adapter.DeleteCommand = new SqlCommand(sql, con);
            adapter.DeleteCommand.ExecuteNonQuery();

            command.Dispose();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Dados", "alert('Turma eliminada com sucesso');window.location = 'Turmas.aspx';", true);


        }
    }
}