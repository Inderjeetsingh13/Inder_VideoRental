namespace Inder_VideoRental
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label18 = new System.Windows.Forms.Label();
            this.V_Delete = new System.Windows.Forms.Button();
            this.V_Update = new System.Windows.Forms.Button();
            this.V_Add = new System.Windows.Forms.Button();
            this.V_Genre = new System.Windows.Forms.TextBox();
            this.V_Plot = new System.Windows.Forms.TextBox();
            this.V_Copies = new System.Windows.Forms.TextBox();
            this.V_Cost = new System.Windows.Forms.TextBox();
            this.V_Year = new System.Windows.Forms.TextBox();
            this.V_Ratting = new System.Windows.Forms.TextBox();
            this.V_title = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.C_Delete = new System.Windows.Forms.Button();
            this.C_Update = new System.Windows.Forms.Button();
            this.C_Add = new System.Windows.Forms.Button();
            this.C_Address = new System.Windows.Forms.TextBox();
            this.C_Mobile = new System.Windows.Forms.TextBox();
            this.C_Name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.V_UniqueID = new System.Windows.Forms.TextBox();
            this.C_UniqueID = new System.Windows.Forms.TextBox();
            this.V_Return = new System.Windows.Forms.DateTimePicker();
            this.V_Issue = new System.Windows.Forms.DateTimePicker();
            this.R_Delete = new System.Windows.Forms.Button();
            this.R_Return = new System.Windows.Forms.Button();
            this.R_Issue = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Database = new System.Windows.Forms.DataGridView();
            this.Setting = new System.Windows.Forms.GroupBox();
            this.TopRattingCustomer = new System.Windows.Forms.Button();
            this.TopViewed = new System.Windows.Forms.Button();
            this.RentalVideos = new System.Windows.Forms.Button();
            this.CustomerDetails = new System.Windows.Forms.Button();
            this.VideoDetails = new System.Windows.Forms.Button();
            this.R_UniqueId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Database)).BeginInit();
            this.Setting.SuspendLayout();
            this.SuspendLayout();
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(82, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(116, 24);
            this.label18.TabIndex = 82;
            this.label18.Text = "Movie Area";
            // 
            // V_Delete
            // 
            this.V_Delete.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V_Delete.ForeColor = System.Drawing.Color.Black;
            this.V_Delete.Location = new System.Drawing.Point(196, 325);
            this.V_Delete.Name = "V_Delete";
            this.V_Delete.Size = new System.Drawing.Size(85, 32);
            this.V_Delete.TabIndex = 81;
            this.V_Delete.Text = "Delete";
            this.V_Delete.UseVisualStyleBackColor = true;
            this.V_Delete.Click += new System.EventHandler(this.V_Delete_Click);
            // 
            // V_Update
            // 
            this.V_Update.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V_Update.ForeColor = System.Drawing.Color.Black;
            this.V_Update.Location = new System.Drawing.Point(105, 325);
            this.V_Update.Name = "V_Update";
            this.V_Update.Size = new System.Drawing.Size(85, 32);
            this.V_Update.TabIndex = 80;
            this.V_Update.Text = "Update";
            this.V_Update.UseVisualStyleBackColor = true;
            this.V_Update.Click += new System.EventHandler(this.V_Update_Click);
            // 
            // V_Add
            // 
            this.V_Add.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V_Add.ForeColor = System.Drawing.Color.Black;
            this.V_Add.Location = new System.Drawing.Point(14, 325);
            this.V_Add.Name = "V_Add";
            this.V_Add.Size = new System.Drawing.Size(85, 32);
            this.V_Add.TabIndex = 79;
            this.V_Add.Text = "Add";
            this.V_Add.UseVisualStyleBackColor = true;
            this.V_Add.Click += new System.EventHandler(this.V_Add_Click);
            // 
            // V_Genre
            // 
            this.V_Genre.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V_Genre.Location = new System.Drawing.Point(132, 269);
            this.V_Genre.Name = "V_Genre";
            this.V_Genre.Size = new System.Drawing.Size(154, 32);
            this.V_Genre.TabIndex = 78;
            // 
            // V_Plot
            // 
            this.V_Plot.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V_Plot.Location = new System.Drawing.Point(132, 231);
            this.V_Plot.Name = "V_Plot";
            this.V_Plot.Size = new System.Drawing.Size(154, 32);
            this.V_Plot.TabIndex = 77;
            this.V_Plot.TextChanged += new System.EventHandler(this.V_Plot_TextChanged);
            // 
            // V_Copies
            // 
            this.V_Copies.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V_Copies.Location = new System.Drawing.Point(132, 195);
            this.V_Copies.Name = "V_Copies";
            this.V_Copies.Size = new System.Drawing.Size(154, 32);
            this.V_Copies.TabIndex = 76;
            // 
            // V_Cost
            // 
            this.V_Cost.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V_Cost.Location = new System.Drawing.Point(132, 159);
            this.V_Cost.Name = "V_Cost";
            this.V_Cost.ReadOnly = true;
            this.V_Cost.Size = new System.Drawing.Size(154, 32);
            this.V_Cost.TabIndex = 75;
            // 
            // V_Year
            // 
            this.V_Year.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V_Year.Location = new System.Drawing.Point(132, 121);
            this.V_Year.Name = "V_Year";
            this.V_Year.Size = new System.Drawing.Size(154, 32);
            this.V_Year.TabIndex = 74;
            this.V_Year.TextChanged += new System.EventHandler(this.V_Year_TextChanged);
            // 
            // V_Ratting
            // 
            this.V_Ratting.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V_Ratting.Location = new System.Drawing.Point(132, 83);
            this.V_Ratting.Name = "V_Ratting";
            this.V_Ratting.Size = new System.Drawing.Size(154, 32);
            this.V_Ratting.TabIndex = 73;
            // 
            // V_title
            // 
            this.V_title.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V_title.Location = new System.Drawing.Point(132, 45);
            this.V_title.Name = "V_title";
            this.V_title.Size = new System.Drawing.Size(154, 32);
            this.V_title.TabIndex = 72;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(31, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 24);
            this.label7.TabIndex = 71;
            this.label7.Text = "Genre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(31, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 24);
            this.label6.TabIndex = 70;
            this.label6.Text = "Plot";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(32, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 69;
            this.label5.Text = "Copies";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 68;
            this.label4.Text = "Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(31, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 67;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 66;
            this.label2.Text = "Ratting";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(31, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 24);
            this.label16.TabIndex = 65;
            this.label16.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(401, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 94;
            this.label1.Text = "Customer Area";
            // 
            // C_Delete
            // 
            this.C_Delete.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_Delete.ForeColor = System.Drawing.Color.Black;
            this.C_Delete.Location = new System.Drawing.Point(356, 195);
            this.C_Delete.Name = "C_Delete";
            this.C_Delete.Size = new System.Drawing.Size(274, 37);
            this.C_Delete.TabIndex = 93;
            this.C_Delete.Text = "Delete";
            this.C_Delete.UseVisualStyleBackColor = true;
            this.C_Delete.Click += new System.EventHandler(this.C_Delete_Click);
            // 
            // C_Update
            // 
            this.C_Update.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_Update.ForeColor = System.Drawing.Color.Black;
            this.C_Update.Location = new System.Drawing.Point(476, 157);
            this.C_Update.Name = "C_Update";
            this.C_Update.Size = new System.Drawing.Size(154, 32);
            this.C_Update.TabIndex = 92;
            this.C_Update.Text = "Update";
            this.C_Update.UseVisualStyleBackColor = true;
            this.C_Update.Click += new System.EventHandler(this.C_Update_Click);
            // 
            // C_Add
            // 
            this.C_Add.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_Add.ForeColor = System.Drawing.Color.Black;
            this.C_Add.Location = new System.Drawing.Point(354, 157);
            this.C_Add.Name = "C_Add";
            this.C_Add.Size = new System.Drawing.Size(101, 32);
            this.C_Add.TabIndex = 89;
            this.C_Add.Text = "Add";
            this.C_Add.UseVisualStyleBackColor = true;
            this.C_Add.Click += new System.EventHandler(this.C_Add_Click);
            // 
            // C_Address
            // 
            this.C_Address.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_Address.Location = new System.Drawing.Point(476, 113);
            this.C_Address.Name = "C_Address";
            this.C_Address.Size = new System.Drawing.Size(154, 32);
            this.C_Address.TabIndex = 91;
            // 
            // C_Mobile
            // 
            this.C_Mobile.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_Mobile.Location = new System.Drawing.Point(476, 74);
            this.C_Mobile.Name = "C_Mobile";
            this.C_Mobile.Size = new System.Drawing.Size(154, 32);
            this.C_Mobile.TabIndex = 90;
            // 
            // C_Name
            // 
            this.C_Name.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_Name.Location = new System.Drawing.Point(476, 36);
            this.C_Name.Name = "C_Name";
            this.C_Name.Size = new System.Drawing.Size(154, 32);
            this.C_Name.TabIndex = 87;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(350, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 24);
            this.label8.TabIndex = 86;
            this.label8.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(350, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 24);
            this.label9.TabIndex = 85;
            this.label9.Text = "Phone No.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(343, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 24);
            this.label11.TabIndex = 83;
            this.label11.Text = "Full Name";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(709, 7);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(119, 24);
            this.label17.TabIndex = 106;
            this.label17.Text = "Rental Area";
            // 
            // V_UniqueID
            // 
            this.V_UniqueID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V_UniqueID.Location = new System.Drawing.Point(837, 71);
            this.V_UniqueID.Name = "V_UniqueID";
            this.V_UniqueID.Size = new System.Drawing.Size(154, 32);
            this.V_UniqueID.TabIndex = 105;
            // 
            // C_UniqueID
            // 
            this.C_UniqueID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_UniqueID.Location = new System.Drawing.Point(837, 33);
            this.C_UniqueID.Name = "C_UniqueID";
            this.C_UniqueID.Size = new System.Drawing.Size(154, 32);
            this.C_UniqueID.TabIndex = 104;
            // 
            // V_Return
            // 
            this.V_Return.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V_Return.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.V_Return.Location = new System.Drawing.Point(837, 152);
            this.V_Return.Name = "V_Return";
            this.V_Return.Size = new System.Drawing.Size(154, 32);
            this.V_Return.TabIndex = 103;
            // 
            // V_Issue
            // 
            this.V_Issue.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V_Issue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.V_Issue.Location = new System.Drawing.Point(837, 109);
            this.V_Issue.Name = "V_Issue";
            this.V_Issue.Size = new System.Drawing.Size(154, 32);
            this.V_Issue.TabIndex = 102;
            // 
            // R_Delete
            // 
            this.R_Delete.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_Delete.ForeColor = System.Drawing.Color.Black;
            this.R_Delete.Location = new System.Drawing.Point(715, 237);
            this.R_Delete.Name = "R_Delete";
            this.R_Delete.Size = new System.Drawing.Size(274, 37);
            this.R_Delete.TabIndex = 101;
            this.R_Delete.Text = "Delete";
            this.R_Delete.UseVisualStyleBackColor = true;
            this.R_Delete.Click += new System.EventHandler(this.R_Delete_Click);
            // 
            // R_Return
            // 
            this.R_Return.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_Return.ForeColor = System.Drawing.Color.Black;
            this.R_Return.Location = new System.Drawing.Point(835, 199);
            this.R_Return.Name = "R_Return";
            this.R_Return.Size = new System.Drawing.Size(154, 32);
            this.R_Return.TabIndex = 100;
            this.R_Return.Text = "Return";
            this.R_Return.UseVisualStyleBackColor = true;
            this.R_Return.Click += new System.EventHandler(this.R_Return_Click);
            // 
            // R_Issue
            // 
            this.R_Issue.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_Issue.ForeColor = System.Drawing.Color.Black;
            this.R_Issue.Location = new System.Drawing.Point(713, 199);
            this.R_Issue.Name = "R_Issue";
            this.R_Issue.Size = new System.Drawing.Size(101, 32);
            this.R_Issue.TabIndex = 99;
            this.R_Issue.Text = "Issue";
            this.R_Issue.UseVisualStyleBackColor = true;
            this.R_Issue.Click += new System.EventHandler(this.R_Issue_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(675, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 24);
            this.label12.TabIndex = 98;
            this.label12.Text = "Date of Return ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(673, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 24);
            this.label13.TabIndex = 97;
            this.label13.Text = "Date of Issue";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(673, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 24);
            this.label14.TabIndex = 96;
            this.label14.Text = "Movie ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(675, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 24);
            this.label15.TabIndex = 95;
            this.label15.Text = "Customer ID";
            // 
            // Database
            // 
            this.Database.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Database.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Database.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Database.Location = new System.Drawing.Point(354, 313);
            this.Database.Name = "Database";
            this.Database.Size = new System.Drawing.Size(693, 315);
            this.Database.TabIndex = 107;
            this.Database.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Database_CellClick);
            // 
            // Setting
            // 
            this.Setting.BackColor = System.Drawing.Color.Transparent;
            this.Setting.Controls.Add(this.TopRattingCustomer);
            this.Setting.Controls.Add(this.TopViewed);
            this.Setting.Controls.Add(this.RentalVideos);
            this.Setting.Controls.Add(this.CustomerDetails);
            this.Setting.Controls.Add(this.VideoDetails);
            this.Setting.Location = new System.Drawing.Point(14, 374);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(267, 230);
            this.Setting.TabIndex = 108;
            this.Setting.TabStop = false;
            this.Setting.Text = "Settings";
            // 
            // TopRattingCustomer
            // 
            this.TopRattingCustomer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopRattingCustomer.ForeColor = System.Drawing.Color.Black;
            this.TopRattingCustomer.Location = new System.Drawing.Point(6, 180);
            this.TopRattingCustomer.Name = "TopRattingCustomer";
            this.TopRattingCustomer.Size = new System.Drawing.Size(255, 28);
            this.TopRattingCustomer.TabIndex = 113;
            this.TopRattingCustomer.Text = "Top Ranking Customer";
            this.TopRattingCustomer.UseVisualStyleBackColor = true;
            this.TopRattingCustomer.Click += new System.EventHandler(this.TopRattingCustomer_Click);
            // 
            // TopViewed
            // 
            this.TopViewed.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopViewed.ForeColor = System.Drawing.Color.Black;
            this.TopViewed.Location = new System.Drawing.Point(6, 141);
            this.TopViewed.Name = "TopViewed";
            this.TopViewed.Size = new System.Drawing.Size(255, 28);
            this.TopViewed.TabIndex = 112;
            this.TopViewed.Text = "Top Viewed Movie";
            this.TopViewed.UseVisualStyleBackColor = true;
            this.TopViewed.Click += new System.EventHandler(this.TopViewed_Click);
            // 
            // RentalVideos
            // 
            this.RentalVideos.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentalVideos.ForeColor = System.Drawing.Color.Black;
            this.RentalVideos.Location = new System.Drawing.Point(6, 101);
            this.RentalVideos.Name = "RentalVideos";
            this.RentalVideos.Size = new System.Drawing.Size(255, 28);
            this.RentalVideos.TabIndex = 111;
            this.RentalVideos.Text = "Rental Record";
            this.RentalVideos.UseVisualStyleBackColor = true;
            this.RentalVideos.Click += new System.EventHandler(this.RentalVideos_Click);
            // 
            // CustomerDetails
            // 
            this.CustomerDetails.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerDetails.ForeColor = System.Drawing.Color.Black;
            this.CustomerDetails.Location = new System.Drawing.Point(6, 62);
            this.CustomerDetails.Name = "CustomerDetails";
            this.CustomerDetails.Size = new System.Drawing.Size(255, 28);
            this.CustomerDetails.TabIndex = 110;
            this.CustomerDetails.Text = " Customer Record";
            this.CustomerDetails.UseVisualStyleBackColor = true;
            this.CustomerDetails.Click += new System.EventHandler(this.CustomerDetails_Click);
            // 
            // VideoDetails
            // 
            this.VideoDetails.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoDetails.ForeColor = System.Drawing.Color.Black;
            this.VideoDetails.Location = new System.Drawing.Point(6, 19);
            this.VideoDetails.Name = "VideoDetails";
            this.VideoDetails.Size = new System.Drawing.Size(255, 28);
            this.VideoDetails.TabIndex = 109;
            this.VideoDetails.Text = "Get the Video Record";
            this.VideoDetails.UseVisualStyleBackColor = true;
            this.VideoDetails.Click += new System.EventHandler(this.VideoDetails_Click);
            // 
            // R_UniqueId
            // 
            this.R_UniqueId.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_UniqueId.Location = new System.Drawing.Point(537, 239);
            this.R_UniqueId.Name = "R_UniqueId";
            this.R_UniqueId.Size = new System.Drawing.Size(154, 32);
            this.R_UniqueId.TabIndex = 109;
            this.R_UniqueId.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1059, 640);
            this.Controls.Add(this.R_UniqueId);
            this.Controls.Add(this.Setting);
            this.Controls.Add(this.Database);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.V_UniqueID);
            this.Controls.Add(this.C_UniqueID);
            this.Controls.Add(this.V_Return);
            this.Controls.Add(this.V_Issue);
            this.Controls.Add(this.R_Delete);
            this.Controls.Add(this.R_Return);
            this.Controls.Add(this.R_Issue);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.C_Delete);
            this.Controls.Add(this.C_Update);
            this.Controls.Add(this.C_Add);
            this.Controls.Add(this.C_Address);
            this.Controls.Add(this.C_Mobile);
            this.Controls.Add(this.C_Name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.V_Delete);
            this.Controls.Add(this.V_Update);
            this.Controls.Add(this.V_Add);
            this.Controls.Add(this.V_Genre);
            this.Controls.Add(this.V_Plot);
            this.Controls.Add(this.V_Copies);
            this.Controls.Add(this.V_Cost);
            this.Controls.Add(this.V_Year);
            this.Controls.Add(this.V_Ratting);
            this.Controls.Add(this.V_title);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label16);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Database)).EndInit();
            this.Setting.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button V_Delete;
        private System.Windows.Forms.Button V_Update;
        private System.Windows.Forms.Button V_Add;
        private System.Windows.Forms.TextBox V_Genre;
        private System.Windows.Forms.TextBox V_Plot;
        private System.Windows.Forms.TextBox V_Copies;
        private System.Windows.Forms.TextBox V_Cost;
        private System.Windows.Forms.TextBox V_Year;
        private System.Windows.Forms.TextBox V_Ratting;
        private System.Windows.Forms.TextBox V_title;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button C_Delete;
        private System.Windows.Forms.Button C_Update;
        private System.Windows.Forms.Button C_Add;
        private System.Windows.Forms.TextBox C_Address;
        private System.Windows.Forms.TextBox C_Mobile;
        private System.Windows.Forms.TextBox C_Name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox V_UniqueID;
        private System.Windows.Forms.TextBox C_UniqueID;
        private System.Windows.Forms.DateTimePicker V_Return;
        private System.Windows.Forms.DateTimePicker V_Issue;
        private System.Windows.Forms.Button R_Delete;
        private System.Windows.Forms.Button R_Return;
        private System.Windows.Forms.Button R_Issue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView Database;
        private System.Windows.Forms.GroupBox Setting;
        private System.Windows.Forms.Button VideoDetails;
        private System.Windows.Forms.Button CustomerDetails;
        private System.Windows.Forms.Button RentalVideos;
        private System.Windows.Forms.Button TopViewed;
        private System.Windows.Forms.Button TopRattingCustomer;
        private System.Windows.Forms.TextBox R_UniqueId;
    }
}

