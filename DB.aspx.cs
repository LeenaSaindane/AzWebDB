using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


namespace AzWebDB
{
    public partial class DB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)

            {

                //DisplayRecord();
                string connStr = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;

                SqlConnection con = new SqlConnection(connStr);

                SqlDataAdapter Adp = new SqlDataAdapter("select ename from dbo.emp where empno=1001", con);

                DataTable Dt = new DataTable();

                Adp.Fill(Dt);

                gvEmp.DataSource = Dt;

                gvEmp.DataBind();

                con.Close();



            }

        }

      
    }
}