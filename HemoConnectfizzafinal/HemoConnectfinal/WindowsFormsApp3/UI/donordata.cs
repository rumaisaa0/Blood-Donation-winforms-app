using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;

namespace WindowsFormsApp3
{
    internal class donordata
    {
        //SqlConnection connect
        //   = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rizwan Moosa Saya\Documents\blooddonation.mdf;Integrated Security=True;Connect Timeout=30");
        SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);

        public int getbloodcount(string bloodtype) {
            int bcount=0;
            if ((connect.State != ConnectionState.Open) )
            {
                try
                { string query1;
                    connect.Open();
                    // TO CHECK IF THE USER IS EXISTING ALREADY
                    if(bloodtype=="total")
                        query1 = "select * from donors";
                    else
                    query1 = "select * from donors where bloodgroup=@btype";

                    using (SqlCommand cmd = new SqlCommand(query1, connect))
                    {
                        cmd.Parameters.AddWithValue("@btype", bloodtype);
                        SqlDataAdapter adapter1 = new SqlDataAdapter(cmd);
                        DataTable table1 = new DataTable();
                        adapter1.Fill(table1);
                       bcount=table1.Rows.Count;
                        

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex
                , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
            return bcount;
        }
        public int getstatus(int donorid,string status1)
        {
            int bcount = 0;
            if ((connect.State != ConnectionState.Open))
            {
                try
                {
                    string query1;
                    connect.Open();
                    // TO CHECK IF THE USER IS EXISTING ALREADY
                    if (donorid == 0)
                        query1 = "select * from blooddonations where currstatus = @currstatus";
                    else
                        query1 = "select * from blooddonations where donorid = @donorid AND currstatus =@currstatus";

                    using (SqlCommand cmd = new SqlCommand(query1, connect))
                    {
                        cmd.Parameters.AddWithValue("@donorid", donorid);
                        cmd.Parameters.AddWithValue("@currstatus", status1);

                        SqlDataAdapter adapter1 = new SqlDataAdapter(cmd);
                        DataTable table1 = new DataTable();
                        adapter1.Fill(table1);
                        bcount = table1.Rows.Count;


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex
                , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
            return bcount;
        }
        public int getgroupstatus(string bloodgroup, string status1)
        {
            int bcount = 0;
            if ((connect.State != ConnectionState.Open))
            {
                try
                {
                    string query1;
                    connect.Open();
                    // TO CHECK IF THE USER IS EXISTING ALREADY
                    if (bloodgroup == "total")
                        query1 = "select * from blooddonations where currstatus = @currstatus";
                    else
                        query1 = "select * from blooddonations left join donors on donors.donorid=blooddonations.donorid " +
                            "where bloodgroup=@bloodgroup AND currstatus =@currstatus";

                    using (SqlCommand cmd = new SqlCommand(query1, connect))
                    {
                        cmd.Parameters.AddWithValue("@bloodgroup", bloodgroup);
                        cmd.Parameters.AddWithValue("@currstatus", status1);

                        SqlDataAdapter adapter1 = new SqlDataAdapter(cmd);
                        DataTable table1 = new DataTable();
                        adapter1.Fill(table1);
                        bcount = table1.Rows.Count;


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex
                , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
            return bcount;
        }

    }
}
