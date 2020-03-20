using System;
using System.Windows.Forms;

namespace SomerenUI
{
    partial class SomerenUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SomerenUI));
            this.img_Dashboard = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beveragesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_Dashboard = new System.Windows.Forms.Panel();
            this.lbl_Dashboard = new System.Windows.Forms.Label();
            this.pnl_Students = new System.Windows.Forms.Panel();
            this.listViewStudents = new System.Windows.Forms.ListView();
            this.studentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentDOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Students = new System.Windows.Forms.Label();
            this.pnl_Lecturers = new System.Windows.Forms.Panel();
            this.listViewTeachers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_Teachers = new System.Windows.Forms.Label();
            this.pnl_Room = new System.Windows.Forms.Panel();
            this.listViewRooms = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnl_Rooms = new System.Windows.Forms.Label();
            this.pnl_Beverage = new System.Windows.Forms.Panel();
            this.btn_UpdateDatabase = new System.Windows.Forms.Button();
            this.listViewBeverages = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pnl_Beverages = new System.Windows.Forms.Label();
            this.pnl_Register = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.listViewRegisterB = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewRegister = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pnl_Registers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img_Dashboard)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pnl_Dashboard.SuspendLayout();
            this.pnl_Students.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_Lecturers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnl_Room.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnl_Beverage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pnl_Register.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // img_Dashboard
            // 
            this.img_Dashboard.Location = new System.Drawing.Point(836, 0);
            this.img_Dashboard.Margin = new System.Windows.Forms.Padding(4);
            this.img_Dashboard.Name = "img_Dashboard";
            this.img_Dashboard.Size = new System.Drawing.Size(415, 332);
            this.img_Dashboard.TabIndex = 0;
            this.img_Dashboard.TabStop = false;
            this.img_Dashboard.Click += new System.EventHandler(this.img_Dashboard_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.lecturersToolStripMenuItem,
            this.activitiesToolStripMenuItem,
            this.roomsToolStripMenuItem,
            this.beveragesToolStripMenuItem,
            this.registerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1283, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem1,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.dashboardToolStripMenuItem.Text = "Application";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // dashboardToolStripMenuItem1
            // 
            this.dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            this.dashboardToolStripMenuItem1.Size = new System.Drawing.Size(165, 26);
            this.dashboardToolStripMenuItem1.Text = "Dashboard";
            this.dashboardToolStripMenuItem1.Click += new System.EventHandler(this.dashboardToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.studentsToolStripMenuItem.Text = "Students";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // lecturersToolStripMenuItem
            // 
            this.lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            this.lecturersToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.lecturersToolStripMenuItem.Text = "Lecturers";
            this.lecturersToolStripMenuItem.Click += new System.EventHandler(this.LecturersToolStripMenuItem_Click);
            // 
            // activitiesToolStripMenuItem
            // 
            this.activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            this.activitiesToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.activitiesToolStripMenuItem.Text = "Activities";
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.roomsToolStripMenuItem.Text = "Rooms";
            this.roomsToolStripMenuItem.Click += new System.EventHandler(this.RoomsToolStripMenuItem_Click);
            // 
            // beveragesToolStripMenuItem
            // 
            this.beveragesToolStripMenuItem.Name = "beveragesToolStripMenuItem";
            this.beveragesToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.beveragesToolStripMenuItem.Text = "Beverages";
            this.beveragesToolStripMenuItem.Click += new System.EventHandler(this.BeveragesToolStripMenuItem_Click);
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.RegisterToolStripMenuItem_Click);
            // 
            // pnl_Dashboard
            // 
            this.pnl_Dashboard.Controls.Add(this.lbl_Dashboard);
            this.pnl_Dashboard.Controls.Add(this.img_Dashboard);
            this.pnl_Dashboard.Location = new System.Drawing.Point(16, 33);
            this.pnl_Dashboard.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Dashboard.Name = "pnl_Dashboard";
            this.pnl_Dashboard.Size = new System.Drawing.Size(1251, 574);
            this.pnl_Dashboard.TabIndex = 2;
            // 
            // lbl_Dashboard
            // 
            this.lbl_Dashboard.AutoSize = true;
            this.lbl_Dashboard.Location = new System.Drawing.Point(17, 16);
            this.lbl_Dashboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Dashboard.Name = "lbl_Dashboard";
            this.lbl_Dashboard.Size = new System.Drawing.Size(243, 17);
            this.lbl_Dashboard.TabIndex = 1;
            this.lbl_Dashboard.Text = "Welcome to the Someren Application!";
            this.lbl_Dashboard.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnl_Students
            // 
            this.pnl_Students.Controls.Add(this.listViewStudents);
            this.pnl_Students.Controls.Add(this.pictureBox1);
            this.pnl_Students.Controls.Add(this.lbl_Students);
            this.pnl_Students.Location = new System.Drawing.Point(16, 30);
            this.pnl_Students.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Students.Name = "pnl_Students";
            this.pnl_Students.Size = new System.Drawing.Size(1251, 574);
            this.pnl_Students.TabIndex = 4;
            // 
            // listViewStudents
            // 
            this.listViewStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.studentID,
            this.studentName,
            this.studentDOB});
            this.listViewStudents.HideSelection = false;
            this.listViewStudents.Location = new System.Drawing.Point(21, 52);
            this.listViewStudents.Margin = new System.Windows.Forms.Padding(4);
            this.listViewStudents.Name = "listViewStudents";
            this.listViewStudents.Size = new System.Drawing.Size(1020, 377);
            this.listViewStudents.TabIndex = 5;
            this.listViewStudents.UseCompatibleStateImageBehavior = false;
            // 
            // studentID
            // 
            this.studentID.Text = "ID";
            // 
            // studentName
            // 
            this.studentName.Text = "Name";
            // 
            // studentDOB
            // 
            this.studentDOB.Text = "Date of Birth";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1073, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 151);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Students
            // 
            this.lbl_Students.AutoSize = true;
            this.lbl_Students.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Students.Location = new System.Drawing.Point(13, 12);
            this.lbl_Students.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Students.Name = "lbl_Students";
            this.lbl_Students.Size = new System.Drawing.Size(129, 33);
            this.lbl_Students.TabIndex = 3;
            this.lbl_Students.Text = "Students";
            // 
            // pnl_Lecturers
            // 
            this.pnl_Lecturers.AccessibleName = "";
            this.pnl_Lecturers.Controls.Add(this.listViewTeachers);
            this.pnl_Lecturers.Controls.Add(this.pictureBox2);
            this.pnl_Lecturers.Controls.Add(this.lbl_Teachers);
            this.pnl_Lecturers.Location = new System.Drawing.Point(16, 30);
            this.pnl_Lecturers.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Lecturers.Name = "pnl_Lecturers";
            this.pnl_Lecturers.Size = new System.Drawing.Size(1251, 574);
            this.pnl_Lecturers.TabIndex = 6;
            // 
            // listViewTeachers
            // 
            this.listViewTeachers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewTeachers.HideSelection = false;
            this.listViewTeachers.Location = new System.Drawing.Point(21, 52);
            this.listViewTeachers.Margin = new System.Windows.Forms.Padding(4);
            this.listViewTeachers.Name = "listViewTeachers";
            this.listViewTeachers.Size = new System.Drawing.Size(1020, 377);
            this.listViewTeachers.TabIndex = 5;
            this.listViewTeachers.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date of Birth";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(1073, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(173, 151);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_Teachers
            // 
            this.lbl_Teachers.AutoSize = true;
            this.lbl_Teachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Teachers.Location = new System.Drawing.Point(13, 12);
            this.lbl_Teachers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Teachers.Name = "lbl_Teachers";
            this.lbl_Teachers.Size = new System.Drawing.Size(137, 33);
            this.lbl_Teachers.TabIndex = 3;
            this.lbl_Teachers.Text = "Lecturers";
            // 
            // pnl_Room
            // 
            this.pnl_Room.AccessibleName = "";
            this.pnl_Room.Controls.Add(this.listViewRooms);
            this.pnl_Room.Controls.Add(this.pictureBox3);
            this.pnl_Room.Controls.Add(this.pnl_Rooms);
            this.pnl_Room.Location = new System.Drawing.Point(16, 30);
            this.pnl_Room.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Room.Name = "pnl_Room";
            this.pnl_Room.Size = new System.Drawing.Size(1251, 574);
            this.pnl_Room.TabIndex = 7;
            this.pnl_Room.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_Room_Paint);
            // 
            // listViewRooms
            // 
            this.listViewRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewRooms.HideSelection = false;
            this.listViewRooms.Location = new System.Drawing.Point(21, 52);
            this.listViewRooms.Margin = new System.Windows.Forms.Padding(4);
            this.listViewRooms.Name = "listViewRooms";
            this.listViewRooms.Size = new System.Drawing.Size(1020, 377);
            this.listViewRooms.TabIndex = 5;
            this.listViewRooms.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Date of Birth";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(1073, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(173, 151);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pnl_Rooms
            // 
            this.pnl_Rooms.AutoSize = true;
            this.pnl_Rooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Rooms.Location = new System.Drawing.Point(13, 12);
            this.pnl_Rooms.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pnl_Rooms.Name = "pnl_Rooms";
            this.pnl_Rooms.Size = new System.Drawing.Size(108, 33);
            this.pnl_Rooms.TabIndex = 3;
            this.pnl_Rooms.Text = "Rooms";
            this.pnl_Rooms.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // pnl_Beverage
            // 
            this.pnl_Beverage.AccessibleName = "";
            this.pnl_Beverage.Controls.Add(this.btn_UpdateDatabase);
            this.pnl_Beverage.Controls.Add(this.listViewBeverages);
            this.pnl_Beverage.Controls.Add(this.pictureBox4);
            this.pnl_Beverage.Controls.Add(this.pnl_Beverages);
            this.pnl_Beverage.Location = new System.Drawing.Point(12, 30);
            this.pnl_Beverage.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Beverage.Name = "pnl_Beverage";
            this.pnl_Beverage.Size = new System.Drawing.Size(1251, 574);
            this.pnl_Beverage.TabIndex = 8;
            // 
            // btn_UpdateDatabase
            // 
            this.btn_UpdateDatabase.Location = new System.Drawing.Point(415, 479);
            this.btn_UpdateDatabase.Margin = new System.Windows.Forms.Padding(4);
            this.btn_UpdateDatabase.Name = "btn_UpdateDatabase";
            this.btn_UpdateDatabase.Size = new System.Drawing.Size(391, 47);
            this.btn_UpdateDatabase.TabIndex = 6;
            this.btn_UpdateDatabase.Text = "Update Database";
            this.btn_UpdateDatabase.UseVisualStyleBackColor = true;
            this.btn_UpdateDatabase.Click += new System.EventHandler(this.btn_UpdateDatabase_Click);
            // 
            // listViewBeverages
            // 
            this.listViewBeverages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listViewBeverages.HideSelection = false;
            this.listViewBeverages.Location = new System.Drawing.Point(21, 52);
            this.listViewBeverages.Margin = new System.Windows.Forms.Padding(4);
            this.listViewBeverages.Name = "listViewBeverages";
            this.listViewBeverages.Size = new System.Drawing.Size(996, 377);
            this.listViewBeverages.TabIndex = 5;
            this.listViewBeverages.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ID";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Name";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Date of Birth";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox4.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.InitialImage")));
            this.pictureBox4.Location = new System.Drawing.Point(1073, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(173, 151);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pnl_Beverages
            // 
            this.pnl_Beverages.AutoSize = true;
            this.pnl_Beverages.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Beverages.Location = new System.Drawing.Point(13, 12);
            this.pnl_Beverages.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pnl_Beverages.Name = "pnl_Beverages";
            this.pnl_Beverages.Size = new System.Drawing.Size(154, 33);
            this.pnl_Beverages.TabIndex = 3;
            this.pnl_Beverages.Text = "Beverages";
            // 
            // pnl_Register
            // 
            this.pnl_Register.AccessibleName = "";
            this.pnl_Register.Controls.Add(this.btnRegister);
            this.pnl_Register.Controls.Add(this.listViewRegisterB);
            this.pnl_Register.Controls.Add(this.listViewRegister);
            this.pnl_Register.Controls.Add(this.pictureBox5);
            this.pnl_Register.Controls.Add(this.pnl_Registers);
            this.pnl_Register.Location = new System.Drawing.Point(11, 29);
            this.pnl_Register.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Register.Name = "pnl_Register";
            this.pnl_Register.Size = new System.Drawing.Size(1251, 574);
            this.pnl_Register.TabIndex = 9;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(403, 480);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(291, 74);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Pay";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // listViewRegisterB
            // 
            this.listViewRegisterB.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.listViewRegisterB.HideSelection = false;
            this.listViewRegisterB.Location = new System.Drawing.Point(21, 79);
            this.listViewRegisterB.Margin = new System.Windows.Forms.Padding(4);
            this.listViewRegisterB.Name = "listViewRegisterB";
            this.listViewRegisterB.Size = new System.Drawing.Size(500, 377);
            this.listViewRegisterB.TabIndex = 6;
            this.listViewRegisterB.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "ID";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Name";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Date of Birth";
            // 
            // listViewRegister
            // 
            this.listViewRegister.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.listViewRegister.HideSelection = false;
            this.listViewRegister.Location = new System.Drawing.Point(551, 79);
            this.listViewRegister.Margin = new System.Windows.Forms.Padding(4);
            this.listViewRegister.MultiSelect = false;
            this.listViewRegister.Name = "listViewRegister";
            this.listViewRegister.Size = new System.Drawing.Size(514, 377);
            this.listViewRegister.TabIndex = 5;
            this.listViewRegister.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "ID";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Name";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Date of Birth";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox5.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.InitialImage")));
            this.pictureBox5.Location = new System.Drawing.Point(1073, 0);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(173, 151);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // pnl_Registers
            // 
            this.pnl_Registers.AutoSize = true;
            this.pnl_Registers.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Registers.Location = new System.Drawing.Point(13, 12);
            this.pnl_Registers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pnl_Registers.Name = "pnl_Registers";
            this.pnl_Registers.Size = new System.Drawing.Size(124, 33);
            this.pnl_Registers.TabIndex = 3;
            this.pnl_Registers.Text = "Register";
            // 
            // SomerenUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 622);
            this.Controls.Add(this.pnl_Register);
            this.Controls.Add(this.pnl_Beverage);
            this.Controls.Add(this.pnl_Room);
            this.Controls.Add(this.pnl_Lecturers);
            this.Controls.Add(this.pnl_Students);
            this.Controls.Add(this.pnl_Dashboard);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SomerenUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "SomerenApp";
            this.Load += new System.EventHandler(this.SomerenUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_Dashboard)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_Dashboard.ResumeLayout(false);
            this.pnl_Dashboard.PerformLayout();
            this.pnl_Students.ResumeLayout(false);
            this.pnl_Students.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_Lecturers.ResumeLayout(false);
            this.pnl_Lecturers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnl_Room.ResumeLayout(false);
            this.pnl_Room.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnl_Beverage.ResumeLayout(false);
            this.pnl_Beverage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pnl_Register.ResumeLayout(false);
            this.pnl_Register.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       /* private void Pnl_Students_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }*/

        #endregion

        private System.Windows.Forms.PictureBox img_Dashboard;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_Dashboard;
        private System.Windows.Forms.Label lbl_Dashboard;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_Students;
        private System.Windows.Forms.Label lbl_Students;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.ColumnHeader studentID;
        private System.Windows.Forms.ColumnHeader studentName;
        private System.Windows.Forms.ColumnHeader studentDOB;
        private System.Windows.Forms.Panel pnl_Lecturers;
        private System.Windows.Forms.ListView listViewTeachers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_Teachers;
        private Panel pnl_Room;
        private ListView listViewRooms;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private PictureBox pictureBox3;
        private Label pnl_Rooms;
        private ToolStripMenuItem beveragesToolStripMenuItem;
        private Panel pnl_Beverage;
        private ListView listViewBeverages;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private PictureBox pictureBox4;
        private Label pnl_Beverages;
        private Button btn_UpdateDatabase;
        private ToolStripMenuItem registerToolStripMenuItem;
        private Panel pnl_Register;
        private Button btnRegister;
        private ListView listViewRegisterB;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ListView listViewRegister;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private PictureBox pictureBox5;
        private Label pnl_Registers;
    }
}

