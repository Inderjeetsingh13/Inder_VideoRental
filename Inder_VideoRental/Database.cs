using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Inder_VideoRental
{
    abstract class getDetails{
        // this is the method of the abstract class that is used to insert delete update command in to the database 
        public virtual void runQuery() {
               
        }

    }
    class Database: getDetails
    {

        //global declaration of the object of the all classes that are used to create the connection between the local classes and the connection 
        // sqlconnection class this class is used to create the connection between  the both classes
        SqlConnection connection;
        
        // ConectionString is used create the connection between 
        String connection_String = "Data Source=DESKTOP-UAABCCS\\SQLEXPRESS;Initial Catalog=Video_Rental_Inder;Integrated Security=True";
        
        // command that are used to insert delete command
        SqlCommand command;

        // datareader is used to read the data 
        SqlDataReader Datareader;


        // user define method that is used to get the record from the table with the help of Select Query 
        //with the help of select query we can get the record from all the table with the relevant query or clauses by using  the sqldatareader class
        public DataTable Srch(String qry)
        {
            DataTable tbl = new DataTable();


            connection = new SqlConnection(connection_String);

            connection.Open();

            command = new SqlCommand(qry, connection);

            Datareader = command.ExecuteReader();

            tbl.Load(Datareader);

            connection.Close();

            return tbl;
        }
        public int countRentVideo(String id) {
            String cmd = "";
            cmd = "select * from R_Rent where V_Id='" +id + "' and V_Return='Rent'";
            DataTable tblRecord = new DataTable();
            tblRecord = Srch(cmd);
            return tblRecord.Rows.Count;

        }

        public int countRentCustomer(String id)
        {
            String cmd = "";
            cmd = "select * from R_Rent where C_Id='" + id + "' and V_Return='Rent'";
            DataTable tblRecord = new DataTable();
            tblRecord = Srch(cmd);
            return tblRecord.Rows.Count;

        }

        public int VideoCost(String old_Date,int cost) {
            DateTime Current_date = DateTime.Now;

            //convert the old date from string to Date fromat
            DateTime Old_date = Convert.ToDateTime(old_Date.ToString());


            //get the difference in the days fromat
            String diff = (Current_date - Old_date).TotalDays.ToString();


            // calculate the round off value 
            Double Days = Math.Round(Convert.ToDouble(diff));

            
            // return the total cost of the Video
            int price = 0;
            price = cost * Convert.ToInt32(Days);

            return price;
        }


        public int TopViewedMovie() {

            int countVideo = 0, countID = 0;
            DataTable tbl = new DataTable();
            DataTable tbl1 = new DataTable();

            String query = "select * from V_Video ";
            tbl = Srch(query);
            for (int y = 0; y < tbl.Rows.Count; y++)
            {
                String query1 = "select * from R_Rent where V_Id='" + tbl.Rows[y]["ID"].ToString() + "'";
                tbl1 = Srch(query1);
                if (tbl1.Rows.Count > 0)
                {
                    if (tbl1.Rows.Count > countVideo)
                    {
                        countVideo = tbl1.Rows.Count;
                        countID = Convert.ToInt32(tbl.Rows[y]["id"].ToString());
                    }
                }


            }
            return countID;

        }


        public int TopCustomer() {


            int countVideo = 0, countID = 0;
            DataTable tbl = new DataTable();
            DataTable tbl1 = new DataTable();

            String query = "select * from C_Customer";
            tbl = Srch(query);
            for (int y = 0; y < tbl.Rows.Count; y++)
            {
                String query1 = "select * from R_Rent where C_Id='" + tbl.Rows[y]["Id"].ToString() + "'";
                tbl1 = Srch(query1);
                if (tbl1.Rows.Count > 0)
                {
                    if (tbl1.Rows.Count > countVideo)
                    {
                        countVideo = tbl1.Rows.Count;
                        countID = Convert.ToInt32(tbl.Rows[y]["Id"].ToString());
                        
                    }
                }


            }
            return countID;

        }

        // this is method declaration with working 
        public void runQuery(String qry) {

            // this method is used to insert , delete update the record  
            connection = new SqlConnection(connection_String);
            connection.Open();
            command = new SqlCommand(qry, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        // this method is used to calucalute the cost of the movie if the movie is older than 5 year then the charges will be 2 DOllar otherwise charges will be 5 dollar
        public int cost(int Year) {
            int cost = 0;


            try
            {
                //dislay the cost of the price of the video after adding the year of the video
                DateTime Curent_date = DateTime.Now;

                int Current_year = Curent_date.Year;

                int Current_diff = Current_year - Convert.ToInt32(Year);
                // MessageBox.Show(diff.ToString());
                if (Current_diff >= 5)
                {
                    cost= 2;
                }
                else if (Current_diff >= 0 && Current_diff < 5)
                {
                    cost = 5;
                }
            }
            catch (Exception ex)
            {

            }
            return cost;
        }


    }
}
