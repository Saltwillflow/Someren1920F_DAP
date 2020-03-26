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
            this.revenueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_Dashboard = new System.Windows.Forms.Panel();
            this.lbl_Dashboard = new System.Windows.Forms.Label();
            this.pnl_Revenue = new System.Windows.Forms.Panel();
            this.monthCalendarEndDate = new System.Windows.Forms.MonthCalendar();
            this.monthCalendarStartDate = new System.Windows.Forms.MonthCalendar();
            this.listViewRevenue = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_Guidance = new System.Windows.Forms.Panel();
            this.pnlGuidanceAdd = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewTeachersToGuidance = new System.Windows.Forms.ListView();
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGuidanceAdd = new System.Windows.Forms.Button();
            this.pnlGuidanceDelete = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.listViewGuidance = new System.Windows.Forms.ListView();
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnGuidanceDelete = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnl_Register = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.listViewRegisterB = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewRegister = new System.Windows.Forms.ListView();
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pnl_Registers = new System.Windows.Forms.Label();
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.fileSystemWatcher2 = new System.IO.FileSystemWatcher();
            this.pnl_Schedule = new System.Windows.Forms.Panel();
            this.listViewSchedule = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img_Dashboard)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pnl_Dashboard.SuspendLayout();
            this.pnl_Revenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.pnl_Guidance.SuspendLayout();
            this.pnlGuidanceAdd.SuspendLayout();
            this.pnlGuidanceDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.pnl_Register.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.pnl_Students.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_Lecturers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnl_Room.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnl_Beverage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).BeginInit();
            this.pnl_Schedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // img_Dashboard
            // 
            this.img_Dashboard.Location = new System.Drawing.Point(627, 0);
            this.img_Dashboard.Name = "img_Dashboard";
            this.img_Dashboard.Size = new System.Drawing.Size(311, 270);
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
            this.revenueToolStripMenuItem,
            this.registerToolStripMenuItem,
            this.toolStripMenuItem1,
            this.ScheduleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(962, 24);
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
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.dashboardToolStripMenuItem.Text = "Application";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // dashboardToolStripMenuItem1
            // 
            this.dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            this.dashboardToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.dashboardToolStripMenuItem1.Text = "Dashboard";
            this.dashboardToolStripMenuItem1.Click += new System.EventHandler(this.dashboardToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(128, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.studentsToolStripMenuItem.Text = "Students";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // lecturersToolStripMenuItem
            // 
            this.lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            this.lecturersToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.lecturersToolStripMenuItem.Text = "Lecturers";
            this.lecturersToolStripMenuItem.Click += new System.EventHandler(this.LecturersToolStripMenuItem_Click);
            // 
            // activitiesToolStripMenuItem
            // 
            this.activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            this.activitiesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.activitiesToolStripMenuItem.Text = "Activities";
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.roomsToolStripMenuItem.Text = "Rooms";
            this.roomsToolStripMenuItem.Click += new System.EventHandler(this.RoomsToolStripMenuItem_Click);
            // 
            // beveragesToolStripMenuItem
            // 
            this.beveragesToolStripMenuItem.Name = "beveragesToolStripMenuItem";
            this.beveragesToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.beveragesToolStripMenuItem.Text = "Beverages";
            this.beveragesToolStripMenuItem.Click += new System.EventHandler(this.BeveragesToolStripMenuItem_Click);
            // 
            // revenueToolStripMenuItem
            // 
            this.revenueToolStripMenuItem.Name = "revenueToolStripMenuItem";
            this.revenueToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.revenueToolStripMenuItem.Text = "Revenue";
            this.revenueToolStripMenuItem.Click += new System.EventHandler(this.revenueToolStripMenuItem_Click);
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(69, 20);
            this.toolStripMenuItem1.Text = "Guidance";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItem2.Text = "Add";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItem3.Text = "Delete";
            // 
            // ScheduleToolStripMenuItem
            // 
            this.ScheduleToolStripMenuItem.Name = "ScheduleToolStripMenuItem";
            this.ScheduleToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ScheduleToolStripMenuItem.Text = "Schedule";
            this.ScheduleToolStripMenuItem.Click += new System.EventHandler(this.ScheduleToolStripMenuItem_Click);
            // 
            // pnl_Dashboard
            // 
            this.pnl_Dashboard.Controls.Add(this.lbl_Dashboard);
            this.pnl_Dashboard.Controls.Add(this.img_Dashboard);
            this.pnl_Dashboard.Location = new System.Drawing.Point(0, 46);
            this.pnl_Dashboard.Name = "pnl_Dashboard";
            this.pnl_Dashboard.Size = new System.Drawing.Size(938, 421);
            this.pnl_Dashboard.TabIndex = 2;
            // 
            // lbl_Dashboard
            // 
            this.lbl_Dashboard.AutoSize = true;
            this.lbl_Dashboard.Location = new System.Drawing.Point(13, 13);
            this.lbl_Dashboard.Name = "lbl_Dashboard";
            this.lbl_Dashboard.Size = new System.Drawing.Size(185, 13);
            this.lbl_Dashboard.TabIndex = 1;
            this.lbl_Dashboard.Text = "Welcome to the Someren Application!";
            // 
            // pnl_Revenue
            // 
            this.pnl_Revenue.AccessibleName = "";
            this.pnl_Revenue.Controls.Add(this.monthCalendarEndDate);
            this.pnl_Revenue.Controls.Add(this.monthCalendarStartDate);
            this.pnl_Revenue.Controls.Add(this.listViewRevenue);
            this.pnl_Revenue.Controls.Add(this.pictureBox5);
            this.pnl_Revenue.Controls.Add(this.label2);
            this.pnl_Revenue.Location = new System.Drawing.Point(0, 34);
            this.pnl_Revenue.Name = "pnl_Revenue";
            this.pnl_Revenue.Size = new System.Drawing.Size(938, 432);
            this.pnl_Revenue.TabIndex = 9;
            // 
            // monthCalendarEndDate
            // 
            this.monthCalendarEndDate.Location = new System.Drawing.Point(595, 111);
            this.monthCalendarEndDate.Name = "monthCalendarEndDate";
            this.monthCalendarEndDate.TabIndex = 7;
            // 
            // monthCalendarStartDate
            // 
            this.monthCalendarStartDate.Location = new System.Drawing.Point(406, 111);
            this.monthCalendarStartDate.Name = "monthCalendarStartDate";
            this.monthCalendarStartDate.TabIndex = 6;
            // 
            // listViewRevenue
            // 
            this.listViewRevenue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.listViewRevenue.HideSelection = false;
            this.listViewRevenue.Location = new System.Drawing.Point(16, 42);
            this.listViewRevenue.Name = "listViewRevenue";
            this.listViewRevenue.Size = new System.Drawing.Size(766, 307);
            this.listViewRevenue.TabIndex = 5;
            this.listViewRevenue.UseCompatibleStateImageBehavior = false;
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
            // pictureBox5
            // 
            this.pictureBox5.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox5.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.InitialImage")));
            this.pictureBox5.Location = new System.Drawing.Point(805, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(130, 123);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Revenue";
            // 
            // pnl_Guidance
            // 
            this.pnl_Guidance.AccessibleName = "";
            this.pnl_Guidance.Controls.Add(this.pnlGuidanceAdd);
            this.pnl_Guidance.Controls.Add(this.pnlGuidanceDelete);
            this.pnl_Guidance.Controls.Add(this.pictureBox9);
            this.pnl_Guidance.Controls.Add(this.label4);
            this.pnl_Guidance.Location = new System.Drawing.Point(0, 37);
            this.pnl_Guidance.Name = "pnl_Guidance";
            this.pnl_Guidance.Size = new System.Drawing.Size(934, 398);
            this.pnl_Guidance.TabIndex = 10;
            // 
            // pnlGuidanceAdd
            // 
            this.pnlGuidanceAdd.Controls.Add(this.label3);
            this.pnlGuidanceAdd.Controls.Add(this.label1);
            this.pnlGuidanceAdd.Controls.Add(this.listViewTeachersToGuidance);
            this.pnlGuidanceAdd.Controls.Add(this.btnGuidanceAdd);
            this.pnlGuidanceAdd.Location = new System.Drawing.Point(0, 0);
            this.pnlGuidanceAdd.Margin = new System.Windows.Forms.Padding(2);
            this.pnlGuidanceAdd.Name = "pnlGuidanceAdd";
            this.pnlGuidanceAdd.Size = new System.Drawing.Size(800, 472);
            this.pnlGuidanceAdd.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Select one or multiple lecturers to add to guidance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Add guidance";
            // 
            // listViewTeachersToGuidance
            // 
            this.listViewTeachersToGuidance.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21});
            this.listViewTeachersToGuidance.HideSelection = false;
            this.listViewTeachersToGuidance.Location = new System.Drawing.Point(22, 61);
            this.listViewTeachersToGuidance.Name = "listViewTeachersToGuidance";
            this.listViewTeachersToGuidance.Size = new System.Drawing.Size(300, 288);
            this.listViewTeachersToGuidance.TabIndex = 9;
            this.listViewTeachersToGuidance.UseCompatibleStateImageBehavior = false;
            this.listViewTeachersToGuidance.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListViewTeachersToGuidance_ColumnClick);
            this.listViewTeachersToGuidance.SelectedIndexChanged += new System.EventHandler(this.ListViewTeachersToGuidance_SelectedIndexChanged);
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "ID";
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Name";
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Date of Birth";
            // 
            // btnGuidanceAdd
            // 
            this.btnGuidanceAdd.Location = new System.Drawing.Point(382, 301);
            this.btnGuidanceAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuidanceAdd.Name = "btnGuidanceAdd";
            this.btnGuidanceAdd.Size = new System.Drawing.Size(170, 47);
            this.btnGuidanceAdd.TabIndex = 7;
            this.btnGuidanceAdd.Text = "Add Guidance";
            this.btnGuidanceAdd.UseVisualStyleBackColor = true;
            this.btnGuidanceAdd.Click += new System.EventHandler(this.BtnGuidanceAdd_Click);
            // 
            // pnlGuidanceDelete
            // 
            this.pnlGuidanceDelete.Controls.Add(this.label5);
            this.pnlGuidanceDelete.Controls.Add(this.listViewGuidance);
            this.pnlGuidanceDelete.Controls.Add(this.BtnGuidanceDelete);
            this.pnlGuidanceDelete.Location = new System.Drawing.Point(0, 0);
            this.pnlGuidanceDelete.Margin = new System.Windows.Forms.Padding(2);
            this.pnlGuidanceDelete.Name = "pnlGuidanceDelete";
            this.pnlGuidanceDelete.Size = new System.Drawing.Size(792, 456);
            this.pnlGuidanceDelete.TabIndex = 11;
            this.pnlGuidanceDelete.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGuidanceDelete_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Delete guidance";
            // 
            // listViewGuidance
            // 
            this.listViewGuidance.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader24});
            this.listViewGuidance.HideSelection = false;
            this.listViewGuidance.Location = new System.Drawing.Point(16, 64);
            this.listViewGuidance.Name = "listViewGuidance";
            this.listViewGuidance.Size = new System.Drawing.Size(266, 288);
            this.listViewGuidance.TabIndex = 6;
            this.listViewGuidance.UseCompatibleStateImageBehavior = false;
            this.listViewGuidance.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListViewGuidance_ColumnClick);
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "ID";
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "Name";
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "Date of Birth";
            // 
            // BtnGuidanceDelete
            // 
            this.BtnGuidanceDelete.Location = new System.Drawing.Point(350, 304);
            this.BtnGuidanceDelete.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuidanceDelete.Name = "BtnGuidanceDelete";
            this.BtnGuidanceDelete.Size = new System.Drawing.Size(116, 48);
            this.BtnGuidanceDelete.TabIndex = 9;
            this.BtnGuidanceDelete.Text = "Delete Guidance";
            this.BtnGuidanceDelete.UseVisualStyleBackColor = true;
            this.BtnGuidanceDelete.Click += new System.EventHandler(this.BtnGuidanceDelete_Click_1);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox9.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox9.InitialImage")));
            this.pictureBox9.Location = new System.Drawing.Point(805, 0);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(130, 123);
            this.pictureBox9.TabIndex = 0;
            this.pictureBox9.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Guidance";
            // 
            // pnl_Register
            // 
            this.pnl_Register.AccessibleName = "";
            this.pnl_Register.Controls.Add(this.btnRegister);
            this.pnl_Register.Controls.Add(this.listViewRegisterB);
            this.pnl_Register.Controls.Add(this.listViewRegister);
            this.pnl_Register.Controls.Add(this.pictureBox6);
            this.pnl_Register.Controls.Add(this.pnl_Registers);
            this.pnl_Register.Location = new System.Drawing.Point(3, 49);
            this.pnl_Register.Name = "pnl_Register";
            this.pnl_Register.Size = new System.Drawing.Size(938, 439);
            this.pnl_Register.TabIndex = 9;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(817, 227);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(111, 37);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Pay";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click_1);
            // 
            // listViewRegisterB
            // 
            this.listViewRegisterB.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.listViewRegisterB.HideSelection = false;
            this.listViewRegisterB.Location = new System.Drawing.Point(16, 64);
            this.listViewRegisterB.Name = "listViewRegisterB";
            this.listViewRegisterB.Size = new System.Drawing.Size(376, 307);
            this.listViewRegisterB.TabIndex = 6;
            this.listViewRegisterB.UseCompatibleStateImageBehavior = false;
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
            // listViewRegister
            // 
            this.listViewRegister.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18});
            this.listViewRegister.HideSelection = false;
            this.listViewRegister.Location = new System.Drawing.Point(413, 64);
            this.listViewRegister.MultiSelect = false;
            this.listViewRegister.Name = "listViewRegister";
            this.listViewRegister.Size = new System.Drawing.Size(386, 307);
            this.listViewRegister.TabIndex = 5;
            this.listViewRegister.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "ID";
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Name";
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Date of Birth";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox6.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.InitialImage")));
            this.pictureBox6.Location = new System.Drawing.Point(805, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(130, 123);
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // pnl_Registers
            // 
            this.pnl_Registers.AutoSize = true;
            this.pnl_Registers.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Registers.Location = new System.Drawing.Point(10, 10);
            this.pnl_Registers.Name = "pnl_Registers";
            this.pnl_Registers.Size = new System.Drawing.Size(104, 29);
            this.pnl_Registers.TabIndex = 3;
            this.pnl_Registers.Text = "Register";
            // 
            // pnl_Students
            // 
            this.pnl_Students.Controls.Add(this.listViewStudents);
            this.pnl_Students.Controls.Add(this.pictureBox1);
            this.pnl_Students.Controls.Add(this.lbl_Students);
            this.pnl_Students.Location = new System.Drawing.Point(0, 42);
            this.pnl_Students.Name = "pnl_Students";
            this.pnl_Students.Size = new System.Drawing.Size(938, 457);
            this.pnl_Students.TabIndex = 4;
            // 
            // listViewStudents
            // 
            this.listViewStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.studentID,
            this.studentName,
            this.studentDOB});
            this.listViewStudents.HideSelection = false;
            this.listViewStudents.Location = new System.Drawing.Point(16, 42);
            this.listViewStudents.Name = "listViewStudents";
            this.listViewStudents.Size = new System.Drawing.Size(766, 307);
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
            this.pictureBox1.Location = new System.Drawing.Point(805, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 123);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Students
            // 
            this.lbl_Students.AutoSize = true;
            this.lbl_Students.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Students.Location = new System.Drawing.Point(10, 10);
            this.lbl_Students.Name = "lbl_Students";
            this.lbl_Students.Size = new System.Drawing.Size(107, 29);
            this.lbl_Students.TabIndex = 3;
            this.lbl_Students.Text = "Students";
            // 
            // pnl_Lecturers
            // 
            this.pnl_Lecturers.AccessibleName = "";
            this.pnl_Lecturers.Controls.Add(this.listViewTeachers);
            this.pnl_Lecturers.Controls.Add(this.pictureBox2);
            this.pnl_Lecturers.Controls.Add(this.lbl_Teachers);
            this.pnl_Lecturers.Location = new System.Drawing.Point(3, 46);
            this.pnl_Lecturers.Name = "pnl_Lecturers";
            this.pnl_Lecturers.Size = new System.Drawing.Size(938, 442);
            this.pnl_Lecturers.TabIndex = 6;
            // 
            // listViewTeachers
            // 
            this.listViewTeachers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewTeachers.HideSelection = false;
            this.listViewTeachers.Location = new System.Drawing.Point(16, 42);
            this.listViewTeachers.Name = "listViewTeachers";
            this.listViewTeachers.Size = new System.Drawing.Size(766, 307);
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
            this.pictureBox2.Location = new System.Drawing.Point(805, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 123);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_Teachers
            // 
            this.lbl_Teachers.AutoSize = true;
            this.lbl_Teachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Teachers.Location = new System.Drawing.Point(10, 10);
            this.lbl_Teachers.Name = "lbl_Teachers";
            this.lbl_Teachers.Size = new System.Drawing.Size(113, 29);
            this.lbl_Teachers.TabIndex = 3;
            this.lbl_Teachers.Text = "Lecturers";
            // 
            // pnl_Room
            // 
            this.pnl_Room.AccessibleName = "";
            this.pnl_Room.Controls.Add(this.listViewRooms);
            this.pnl_Room.Controls.Add(this.pictureBox3);
            this.pnl_Room.Controls.Add(this.pnl_Rooms);
            this.pnl_Room.Location = new System.Drawing.Point(3, 42);
            this.pnl_Room.Name = "pnl_Room";
            this.pnl_Room.Size = new System.Drawing.Size(938, 448);
            this.pnl_Room.TabIndex = 7;
            // 
            // listViewRooms
            // 
            this.listViewRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewRooms.HideSelection = false;
            this.listViewRooms.Location = new System.Drawing.Point(16, 42);
            this.listViewRooms.Name = "listViewRooms";
            this.listViewRooms.Size = new System.Drawing.Size(766, 307);
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
            this.pictureBox3.Location = new System.Drawing.Point(805, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(130, 123);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pnl_Rooms
            // 
            this.pnl_Rooms.AutoSize = true;
            this.pnl_Rooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Rooms.Location = new System.Drawing.Point(10, 10);
            this.pnl_Rooms.Name = "pnl_Rooms";
            this.pnl_Rooms.Size = new System.Drawing.Size(90, 29);
            this.pnl_Rooms.TabIndex = 3;
            this.pnl_Rooms.Text = "Rooms";
            // 
            // pnl_Beverage
            // 
            this.pnl_Beverage.AccessibleName = "";
            this.pnl_Beverage.Controls.Add(this.btn_UpdateDatabase);
            this.pnl_Beverage.Controls.Add(this.listViewBeverages);
            this.pnl_Beverage.Controls.Add(this.pictureBox4);
            this.pnl_Beverage.Controls.Add(this.pnl_Beverages);
            this.pnl_Beverage.Location = new System.Drawing.Point(0, 46);
            this.pnl_Beverage.Name = "pnl_Beverage";
            this.pnl_Beverage.Size = new System.Drawing.Size(938, 448);
            this.pnl_Beverage.TabIndex = 8;
            // 
            // btn_UpdateDatabase
            // 
            this.btn_UpdateDatabase.Location = new System.Drawing.Point(311, 389);
            this.btn_UpdateDatabase.Name = "btn_UpdateDatabase";
            this.btn_UpdateDatabase.Size = new System.Drawing.Size(293, 38);
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
            this.listViewBeverages.Location = new System.Drawing.Point(16, 42);
            this.listViewBeverages.Name = "listViewBeverages";
            this.listViewBeverages.Size = new System.Drawing.Size(748, 307);
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
            this.pictureBox4.Location = new System.Drawing.Point(805, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(130, 123);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pnl_Beverages
            // 
            this.pnl_Beverages.AutoSize = true;
            this.pnl_Beverages.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Beverages.Location = new System.Drawing.Point(10, 10);
            this.pnl_Beverages.Name = "pnl_Beverages";
            this.pnl_Beverages.Size = new System.Drawing.Size(129, 29);
            this.pnl_Beverages.TabIndex = 3;
            this.pnl_Beverages.Text = "Beverages";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // fileSystemWatcher2
            // 
            this.fileSystemWatcher2.EnableRaisingEvents = true;
            this.fileSystemWatcher2.SynchronizingObject = this;
            // 
            // pnl_Schedule
            // 
            this.pnl_Schedule.Controls.Add(this.listViewSchedule);
            this.pnl_Schedule.Controls.Add(this.label6);
            this.pnl_Schedule.Location = new System.Drawing.Point(0, 33);
            this.pnl_Schedule.Name = "pnl_Schedule";
            this.pnl_Schedule.Size = new System.Drawing.Size(947, 457);
            this.pnl_Schedule.TabIndex = 6;
            // 
            // listViewSchedule
            // 
            this.listViewSchedule.HideSelection = false;
            this.listViewSchedule.Location = new System.Drawing.Point(22, 46);
            this.listViewSchedule.Name = "listViewSchedule";
            this.listViewSchedule.Size = new System.Drawing.Size(582, 304);
            this.listViewSchedule.TabIndex = 12;
            this.listViewSchedule.UseCompatibleStateImageBehavior = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Schedule";
            // 
            // SomerenUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 505);
            this.Controls.Add(this.pnl_Schedule);
            this.Controls.Add(this.pnl_Guidance);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnl_Students);
            this.Controls.Add(this.pnl_Dashboard);
            this.Controls.Add(this.pnl_Revenue);
            this.Controls.Add(this.pnl_Register);
            this.Controls.Add(this.pnl_Lecturers);
            this.Controls.Add(this.pnl_Beverage);
            this.Controls.Add(this.pnl_Room);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SomerenUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "SomerenApp";
            this.Load += new System.EventHandler(this.SomerenUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_Dashboard)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_Dashboard.ResumeLayout(false);
            this.pnl_Dashboard.PerformLayout();
            this.pnl_Revenue.ResumeLayout(false);
            this.pnl_Revenue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.pnl_Guidance.ResumeLayout(false);
            this.pnl_Guidance.PerformLayout();
            this.pnlGuidanceAdd.ResumeLayout(false);
            this.pnlGuidanceAdd.PerformLayout();
            this.pnlGuidanceDelete.ResumeLayout(false);
            this.pnlGuidanceDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.pnl_Register.ResumeLayout(false);
            this.pnl_Register.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).EndInit();
            this.pnl_Schedule.ResumeLayout(false);
            this.pnl_Schedule.PerformLayout();
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
        private Panel pnl_Revenue;
        private MonthCalendar monthCalendarEndDate;
        private MonthCalendar monthCalendarStartDate;
        private ListView listViewRevenue;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private PictureBox pictureBox5;
        private Label label2;
        private ToolStripMenuItem revenueToolStripMenuItem;
        private ToolStripMenuItem registerToolStripMenuItem;
        private Panel pnl_Register;
        private Button btnRegister;
        private ListView listViewRegisterB;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ListView listViewRegister;
        private ColumnHeader columnHeader16;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeader18;
        private PictureBox pictureBox6;
        private Label pnl_Registers;
        private ToolStripMenuItem ScheduleToolStripMenuItem;
        private Panel pnl_Guidance;
        private Button btnGuidanceAdd;
        private ListView listViewGuidance;
        private ColumnHeader columnHeader22;
        private ColumnHeader columnHeader23;
        private ColumnHeader columnHeader24;
        private PictureBox pictureBox9;
        private Label label4;
        private ListView listViewTeachersToGuidance;
        private ColumnHeader columnHeader19;
        private ColumnHeader columnHeader20;
        private ColumnHeader columnHeader21;
        private Panel pnlGuidanceAdd;
        private Label label3;
        private Label label1;
        private Panel pnlGuidanceDelete;
        private Label label5;
        private Button BtnGuidanceDelete;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.IO.FileSystemWatcher fileSystemWatcher2;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private Panel pnl_Schedule;
        private ListView listViewSchedule;
        private Label label6;
    }
}

