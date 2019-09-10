using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inder_VideoRental
{
    public partial class Form1 : Form
    {
        // creating the object of the class that is used to insert the record
        Database Instance_Object = new Database();
        int v_btn=0, C_btn=0, R_btn = 0,VCost=5;
        public Form1()
        {
            InitializeComponent();
         
        }
        public void empty() {
            V_title.Text = "";
            V_Ratting.Text = "";
            V_Year.Text = "";
            V_Copies.Text = "";
            V_Cost.Text = "";
            V_Plot.Text = "";
            V_Genre.Text = "";


            C_Name.Text = "";
            C_Mobile.Text = "";
            C_Address.Text = "";


            C_UniqueID.Text = "";
            V_UniqueID.Text = "";
            V_Issue.Text = "";


            R_UniqueId.Text = "";

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Wel Come to Video Rental System \n Designed and Developed by Inder");

        }

        private void V_Add_Click(object sender, EventArgs e)
        {
            String cmd = "";
            //command to insert the record in the file from text box to database  
            cmd = "insert into V_Video(V_Title,V_Ratting,V_Year,V_Cost,V_Copies,V_Plot,V_Genre) values ('"+V_title.Text.ToString()+"','"+V_Ratting.Text.ToString()+"','"+V_Year.Text.ToString()+"',"+Convert.ToInt32(V_Cost.Text.ToString())+",'"+V_Copies.Text.ToString()+"','"+V_Plot.Text.ToString()+"','"+V_Genre.Text.ToString()+"')";
            Instance_Object.runQuery(cmd);
            //after inserting the record in the table the message box is used to display the confirmation
            MessageBox.Show("Video Record is saved");
            empty();
        }

        private void V_Delete_Click(object sender, EventArgs e)
        {
            // this condition is used to check the video id from the V_UniqueID text box and then check it from 
            //if the V_Unique Video box is empty then the Error message will be genreate that is used to display the on clicking on the delete button
            if (V_UniqueID.Text.ToString().Equals(""))
            {
                MessageBox.Show("You must have to select the Video First then you can be Able to Delete the Video ");
            }
            else {
                // this query is used to delete the record the Video from the database if it is enter wrong and the video is only deleted if the video has not given on rent to the registered customer
                int count = Instance_Object.countRentVideo(V_UniqueID.Text.ToString());
                if (count > 0)
                {
                    MessageBox.Show("Video is Booked so we canot delete it ");
                }
                else
                {
                   String cmd = "";
                    cmd = "Delete from V_Video where ID=" + Convert.ToInt32(V_UniqueID.Text.ToString()) + "";
                    Instance_Object.runQuery(cmd);
                    MessageBox.Show("Video is Deleted ");
                    empty();
                }
            }


        }

        private void V_Update_Click(object sender, EventArgs e)
        {
            // this code is used to Update the record of the Video while CLicking on the Update button 
            if (V_UniqueID.Text.ToString().Equals(""))
            {
                MessageBox.Show("You must have to select the Video First then you can be Able to Update the Video ");
            }
            else
            {
                // this query is used to delete the record the Video from the database if it is enter wrong and the video is only deleted if the video has not given on rent to the registered customer
                String cmd = "";
                cmd = "update  V_Video set V_Tittle='"+V_title.Text.ToString()+"', V_Ratting='"+V_Ratting.Text.ToString()+"',V_Year='"+V_Year.Text.ToString()+"',V_Cost="+Convert.ToInt32(V_Cost.Text.ToString())+",V_Copies='"+V_Copies.Text.ToString()+"',V_Plot='"+V_Plot.Text.ToString()+"',V_Genre='"+V_Genre.Text.ToString()+"' where id=" + Convert.ToInt32(V_UniqueID.Text.ToString()) + "";
                Instance_Object.runQuery(cmd);
                MessageBox.Show("Video is Updated ");
                empty();
            }
        }

        private void C_Add_Click(object sender, EventArgs e)
        {
            // this code of block is used to add the record in the database after clicking on the add button of the customer portal that is used to insert  the record
            // if all  the textboxes are filled then you can save the record 
            if (C_Name.Text.ToString().Equals("") && C_Mobile.Text.ToString().Equals("") && C_Address.Text.ToString().Equals(""))
            {
                MessageBox.Show("Please fill the all details of the customer to registered in the Firm");
            }
            else
            {
                /// this command is used to insert  the record in the table
                String cmd = "";
                cmd = "Insert into C_Customer (C_Name,C_Phone,C_Address) values('"+C_Name.Text.ToString()+"','"+C_Mobile.Text.ToString()+"','"+C_Address.Text.ToString()+"')";
                Instance_Object.runQuery(cmd);
                // confirmation message that is used to print the confirmation in front of the customer
                    MessageBox.Show("Customer is Registered in  the Firm");
                empty();
            }
        }

        private void C_Delete_Click(object sender, EventArgs e)
        {
            // if we want to delete the record from the portal the recrod of the customer then we must firstly select the record from the Database area /
            // only then we can delete the record 
            if (C_UniqueID.Text.ToString().Equals(""))
            {
                MessageBox.Show("Please Select the Customer First from the Data base Portal to Delete ");
            }
            else
            {
                //this command  is used to delete the rrecord from the portal 
                int count = Instance_Object.countRentVideo(C_UniqueID.Text.ToString());
                if (count > 0)
                {
                    MessageBox.Show("Video is Booked so we canot delete it ");
                }
                else
                {
                    String cmd = "";
                    cmd = "delete from C_Customer where Id=" + Convert.ToInt32(C_UniqueID.Text.ToString()) + "";
                    Instance_Object.runQuery(cmd);
                    MessageBox.Show("Customer Record is deleted from the portal");
                    empty();
                }
            }


        }

        private void C_Update_Click(object sender, EventArgs e)
        {
            // if we want to Update the record from the portal the recrod of the customer then we must firstly select the record from the Database area /
            // only then we can update the record 
            if (C_UniqueID.Text.ToString().Equals(""))
            {
                MessageBox.Show("Please Select the Customer First from the Data base Portal to Update ");
            }
            else
            {
                //this command  is used to delete the rrecord from the portal 
                String cmd = "";
                cmd = "update C_Customer set C_Name='"+C_Name.Text.ToString()+"',C_Phone='"+C_Mobile.Text.ToString()+"',C_Address='"+C_Address.Text.ToString()+"' where Id=" + Convert.ToInt32(C_UniqueID.Text.ToString()) + "";
                Instance_Object.runQuery(cmd);
                MessageBox.Show("Customer Record is Updated from the portal");
                empty();
            }

        }

        private void R_Issue_Click(object sender, EventArgs e)
        {
            //this if condition is used to issue an movie on rent if the movie is avlaible on rent 
            if (C_UniqueID.Text.ToString().Equals("") && V_UniqueID.Text.ToString().Equals(""))
            {
                MessageBox.Show("First Select the record from the Database Grid to Issue a movie on Rent");
            }
            else {
                if (Instance_Object.countRentVideo(V_UniqueID.Text.ToString()) == Convert.ToInt32(V_Copies.Text.ToString()))
                {
                    MessageBox.Show("All videos are Booked by the Customer");
                }
                else if (Instance_Object.countRentCustomer(C_UniqueID.Text.ToString()) == 2)
                {
                    MessageBox.Show("Customer You already Have 2 video on rent So you can't get more ");
                }
                else
                {
                    String cmd = "";
                    cmd = "insert into R_Rent(C_Id,V_Id,V_Issue,V_Return) values (" + Convert.ToInt32(C_UniqueID.Text.ToString()) + "," + Convert.ToInt32(V_UniqueID.Text.ToString()) + ",'" + V_Issue.Text.ToString() + "','Rent')";
                    Instance_Object.runQuery(cmd);
                    MessageBox.Show("Video is Issued on rent to the Member");
                    empty();
                }
            }
        }

        private void R_Delete_Click(object sender, EventArgs e)
        {
            // for delete the record from the Database of the Rental movie then we can use this code

            if (R_UniqueId.Text.ToString().Equals(""))
            {

                MessageBox.Show("You must have to select  the rental video to delete the record from the rental database area");
            }
            else {
                String cmd = "";
                cmd = "delete from R_Rent where Id="+Convert.ToInt32(R_UniqueId.Text.ToString())+"";
                Instance_Object.runQuery(cmd);
                MessageBox.Show("Rental Video Record is deleted from the Database ");
                empty();
            }

        }

        private void R_Return_Click(object sender, EventArgs e)
        {
            // when the Customer want to return his video then we have to selec the recrd from the rent record and then return the video after that the portal will automatically calculate the charges 
            if (R_UniqueId.Text.ToString().Equals(""))
            {
                MessageBox.Show("You must have to select  the rental video to delete the record from the rental database area");
            }
            else
            {
                String cmd = "";
                cmd = "Update R_Rent set C_Id="+Convert.ToInt32(C_UniqueID.Text.ToString())+", V_Id="+Convert.ToInt32(V_UniqueID.Text.ToString())+", V_Issue='"+V_Issue.Text.ToString()+"', V_Return='"+V_Return.Text.ToString()+"' where R_Id=" + Convert.ToInt32(R_UniqueId.Text.ToString()) + "";
                Instance_Object.runQuery(cmd);

                int VideoCharges = Instance_Object.VideoCost(V_Issue.Text.ToString(), VCost);
                MessageBox.Show("Rental Video  is Return to the Firm  and your total charges is=$"+VideoCharges);
                empty();


            }
        }

        private void V_Year_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // this block is used to  calculate the charges of the movie if the difference is more than 5 year then the charges is 2 other wise 5 dollar 
                int cost = Instance_Object.cost(Convert.ToInt32(V_Year.Text.ToString()));
                V_Cost.Text = cost.ToString();
            }
            catch (Exception ex) {
                    
            }

        }

        private void VideoDetails_Click(object sender, EventArgs e)
        {
            //this code is used to get the record of the video from the table of the video to display in the database Datagrid view to view by thw user 
            String query = "select * from V_Video";
            //datatable is a class that is used to get the record from the table and display  in the datagrid view
            DataTable tblRecord = new DataTable();
            //pass the query to the database class and then it will return the record in the format of the table to pass to the datatable 
            tblRecord = Instance_Object.Srch(query);
            //after getting the record from the datatable the whole record will pass to the database 
            Database.DataSource = tblRecord;
            //empty();
            v_btn = 1;
        }

        private void TopViewed_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Best Top Ranked Movie is =" + Instance_Object.TopViewedMovie());
        }

        private void TopRattingCustomer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Best Top Ranked Movie is =" + Instance_Object.TopCustomer());
        }

        private void V_Plot_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomerDetails_Click(object sender, EventArgs e)
        {
            // get the data from the database customer record table and pass to the data grid view 
            String query = "select * from C_Customer";
            DataTable tblRecord = new DataTable();
            tblRecord = Instance_Object.Srch(query);
            Database.DataSource = tblRecord;
            //empty();
            C_btn = 1;
        }

        private void RentalVideos_Click(object sender, EventArgs e)
        {
            //get  the record from the table and display in the rental record from the table
            String query = "select * from R_Rent";
            DataTable tblRecord = new DataTable();
            tblRecord = Instance_Object.Srch(query);
            Database.DataSource = tblRecord;
            //empty();
            R_btn = 1;
        }
        
        private void Database_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (v_btn == 1) {
                V_UniqueID.Text = Database.CurrentRow.Cells[0].Value.ToString();
                V_title.Text = Database.CurrentRow.Cells[1].Value.ToString();
                V_Ratting.Text = Database.CurrentRow.Cells[2].Value.ToString();
                V_Year.Text = Database.CurrentRow.Cells[3].Value.ToString();
                V_Cost.Text = Database.CurrentRow.Cells[4].Value.ToString();
                VCost = Convert.ToInt32(V_Cost.Text.ToString());
                V_Copies.Text= Database.CurrentRow.Cells[5].Value.ToString();
                V_Plot.Text = Database.CurrentRow.Cells[6].Value.ToString();
                V_Genre.Text = Database.CurrentRow.Cells[7].Value.ToString();
                v_btn = 0;
            }


             if (C_btn == 1) {
                C_UniqueID.Text = Database.CurrentRow.Cells[0].Value.ToString();
                C_Name.Text = Database.CurrentRow.Cells[1].Value.ToString();
                C_Mobile.Text = Database.CurrentRow.Cells[2].Value.ToString();
                C_Address.Text = Database.CurrentRow.Cells[3].Value.ToString();
                C_btn = 0;
            }

            if (R_btn==1) {
                R_UniqueId.Text= Database.CurrentRow.Cells[0].Value.ToString();
                C_UniqueID.Text = Database.CurrentRow.Cells[1].Value.ToString();
                V_UniqueID.Text = Database.CurrentRow.Cells[2].Value.ToString();
                V_Issue.Text= Database.CurrentRow.Cells[3].Value.ToString();
                R_btn = 0;
            }


        }
    }
}
