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
        SqlConnection connect
          = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rizwan Moosa Saya\Documents\blooddonation.mdf;Integrated Security=True;Connect Timeout=30");
        // SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);

        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;

        public int Numdonors { get; private set; }
        public int Numdonations { get; private set; }
        public int used { get; private set; }
        public List<KeyValuePair<string, decimal>> TopbloodList { get; private set; }
        public List<KeyValuePair<string, decimal>> lowstockList { get; private set; }
        public int unused { get; set; }
        public int expired { get; set; }
        public decimal Totalqauntity { get; set; }
        private void Getinventorynumbers()
        {
            if ((connect.State != ConnectionState.Open))
            {
                try
                {
                    using (var command = new SqlCommand())
                    {
                        connect.Open();
                        command.Connection = connect;
                        //Get Total Number of Customers
                        command.CommandText = "select count(distinct donorid) from blooddonations where donationdate between  @fromDate and @toDate";
                        command.Parameters.AddWithValue("@fromDate", startDate);
                        command.Parameters.AddWithValue("@toDate", endDate);
                        Numdonors = (int)command.ExecuteScalar();


                        //Get Total Number of Orders
                        command.CommandText = "select count(donationid) from blooddonations where donationdate between  @fromDate and @toDate";
                        
                        Numdonations = (int)command.ExecuteScalar();

                        //Get Total Number of Orders
                        command.CommandText = "select sum(quantity) from blooddonations " +
                                                "where donationdate between  @fromDate and @toDate";

                        object result = command.ExecuteScalar();
                        Totalqauntity = result != DBNull.Value ? Convert.ToDecimal(result) : 0;


                        //Get Total Number of Orders
                        command.CommandText = "select count(donationid) from blooddonations " +
                                                "where donationdate between  @fromDate and @toDate " +
                                                "and currstatus='used'";
                        used = (int)command.ExecuteScalar();

                        //Get Total Number of Orders
                        command.CommandText = "select count(donationid) from blooddonations " +
                                                "where donationdate between  @fromDate and @toDate "+
                                                "and currstatus='unused'";
                        unused = (int)command.ExecuteScalar();

                        //Get Total Number of Orders
                        command.CommandText = "select count(donationid) from blooddonations " +
                                                "where donationdate between  @fromDate and @toDate "+
                                                "and currstatus='expired'";
                        expired = (int)command.ExecuteScalar();
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
        }

        private void GetProductAnalisys()
        {
            TopbloodList = new List<KeyValuePair<string, decimal>>();
            lowstockList = new List<KeyValuePair<string, decimal>>();
            try
            {
                
                    using (var command = new SqlCommand())
                    {    
                        connect.Open();
                        SqlDataReader reader;
                        command.Connection = connect;
                        //Get Top 5 products
                        command.CommandText = "select top 5 bloodgroup, sum(quantity) as TotalQuantity " +
                        "from blooddonations " +
                        "join donors on donors.donorid=blooddonations.donorid " +
                        "where donationdate between @fromDate and @toDate " +
                        "group by bloodgroup " +
                        "order by TotalQuantity desc ";
                        command.Parameters.AddWithValue("@fromDate", startDate);
                        command.Parameters.AddWithValue("@toDate", endDate);
                        reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                        string bloodGroup = reader["bloodgroup"].ToString();
                        decimal totalQuantity = reader.GetDecimal(reader.GetOrdinal("TotalQuantity"));
                        TopbloodList.Add(new KeyValuePair<string, decimal>(bloodGroup, totalQuantity));
                        }
                        reader.Close();

                    //Get Understock
                    command.CommandText = "select threshold.bloodgroup, sum(quantity) as TotalQuantity " +
                        "from blooddonations " +
                        "join donors on donors.donorid=blooddonations.donorid " +
                        "join threshold on donors.bloodgroup=threshold.bloodgroup " +
                        "where donationdate between @fromDate and @toDate " +
                        "group by threshold.bloodgroup " +
                        "having sum(quantity)< 40 ";
                       ;
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string bloodGroup = reader["bloodgroup"].ToString();
                        decimal totalQuantity = reader.GetDecimal(reader.GetOrdinal("TotalQuantity"));
                        lowstockList.Add(new KeyValuePair<string, decimal>(bloodGroup, totalQuantity));
                    }
                    reader.Close();
                    }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex,
              "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }
    
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
        public bool LoadData(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day,
                endDate.Hour, endDate.Minute, 59);
            if (startDate != this.startDate || endDate != this.endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                this.numberDays = (endDate - startDate).Days;

                Getinventorynumbers();
                GetProductAnalisys();
                return true;
            }
            return false;
        }
    }
}
