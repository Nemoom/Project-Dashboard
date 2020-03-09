namespace FEC_Project_Dashboard
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_AMI = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_ELA = new System.Windows.Forms.Panel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_GI = new System.Windows.Forms.Panel();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_FP = new System.Windows.Forms.Panel();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_PILT = new System.Windows.Forms.Panel();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_Others = new System.Windows.Forms.Panel();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_ManualSorting = new System.Windows.Forms.Panel();
            this.panel_Paint = new System.Windows.Forms.Panel();
            this.panel_ItemDemo = new System.Windows.Forms.Panel();
            this.txt_Team_ProjectNameDemo = new System.Windows.Forms.TextBox();
            this.ComboBox_TeamDemo = new System.Windows.Forms.ComboBox();
            this.ComboBox_StatusDemo = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Sort = new System.Windows.Forms.Button();
            this.btn_Import = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel_Finished = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel_AMI.SuspendLayout();
            this.panel_ELA.SuspendLayout();
            this.panel_GI.SuspendLayout();
            this.panel_FP.SuspendLayout();
            this.panel_PILT.SuspendLayout();
            this.panel_Others.SuspendLayout();
            this.panel_ManualSorting.SuspendLayout();
            this.panel_Paint.SuspendLayout();
            this.panel_ItemDemo.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel_Finished.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel_ManualSorting, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel_Finished, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1422, 763);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 3);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1365, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "FEC项目管理看板";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel2.Controls.Add(this.panel_AMI, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel_ELA, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel_GI, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel_FP, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel_PILT, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel_Others, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(437, 131);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(685, 608);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel_AMI
            // 
            this.panel_AMI.Controls.Add(this.listBox1);
            this.panel_AMI.Controls.Add(this.label2);
            this.panel_AMI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_AMI.Location = new System.Drawing.Point(4, 4);
            this.panel_AMI.Name = "panel_AMI";
            this.panel_AMI.Size = new System.Drawing.Size(220, 296);
            this.panel_AMI.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(0, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(220, 267);
            this.listBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "AMI";
            // 
            // panel_ELA
            // 
            this.panel_ELA.Controls.Add(this.listBox2);
            this.panel_ELA.Controls.Add(this.label3);
            this.panel_ELA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ELA.Location = new System.Drawing.Point(231, 4);
            this.panel_ELA.Name = "panel_ELA";
            this.panel_ELA.Size = new System.Drawing.Size(221, 296);
            this.panel_ELA.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 29;
            this.listBox2.Location = new System.Drawing.Point(0, 29);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(221, 267);
            this.listBox2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "ELA";
            // 
            // panel_GI
            // 
            this.panel_GI.Controls.Add(this.listBox3);
            this.panel_GI.Controls.Add(this.label4);
            this.panel_GI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_GI.Location = new System.Drawing.Point(459, 4);
            this.panel_GI.Name = "panel_GI";
            this.panel_GI.Size = new System.Drawing.Size(222, 296);
            this.panel_GI.TabIndex = 2;
            // 
            // listBox3
            // 
            this.listBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 29;
            this.listBox3.Location = new System.Drawing.Point(0, 29);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(222, 267);
            this.listBox3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "GI";
            // 
            // panel_FP
            // 
            this.panel_FP.Controls.Add(this.listBox4);
            this.panel_FP.Controls.Add(this.label5);
            this.panel_FP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_FP.Location = new System.Drawing.Point(4, 307);
            this.panel_FP.Name = "panel_FP";
            this.panel_FP.Size = new System.Drawing.Size(220, 297);
            this.panel_FP.TabIndex = 3;
            // 
            // listBox4
            // 
            this.listBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 29;
            this.listBox4.Location = new System.Drawing.Point(0, 29);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(220, 268);
            this.listBox4.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "FP";
            // 
            // panel_PILT
            // 
            this.panel_PILT.Controls.Add(this.listBox5);
            this.panel_PILT.Controls.Add(this.label6);
            this.panel_PILT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_PILT.Location = new System.Drawing.Point(231, 307);
            this.panel_PILT.Name = "panel_PILT";
            this.panel_PILT.Size = new System.Drawing.Size(221, 297);
            this.panel_PILT.TabIndex = 4;
            // 
            // listBox5
            // 
            this.listBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 29;
            this.listBox5.Location = new System.Drawing.Point(0, 29);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(221, 268);
            this.listBox5.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "PI and LT";
            // 
            // panel_Others
            // 
            this.panel_Others.Controls.Add(this.listBox6);
            this.panel_Others.Controls.Add(this.label7);
            this.panel_Others.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Others.Location = new System.Drawing.Point(459, 307);
            this.panel_Others.Name = "panel_Others";
            this.panel_Others.Size = new System.Drawing.Size(222, 297);
            this.panel_Others.TabIndex = 5;
            // 
            // listBox6
            // 
            this.listBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox6.FormattingEnabled = true;
            this.listBox6.ItemHeight = 29;
            this.listBox6.Location = new System.Drawing.Point(0, 29);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(222, 268);
            this.listBox6.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Others";
            // 
            // panel_ManualSorting
            // 
            this.panel_ManualSorting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_ManualSorting.Controls.Add(this.panel2);
            this.panel_ManualSorting.Controls.Add(this.tableLayoutPanel3);
            this.panel_ManualSorting.Controls.Add(this.label8);
            this.panel_ManualSorting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ManualSorting.Location = new System.Drawing.Point(23, 131);
            this.panel_ManualSorting.Name = "panel_ManualSorting";
            this.panel_ManualSorting.Size = new System.Drawing.Size(408, 608);
            this.panel_ManualSorting.TabIndex = 2;
            // 
            // panel_Paint
            // 
            this.panel_Paint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Paint.BackgroundImage")));
            this.panel_Paint.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Paint.Controls.Add(this.panel_ItemDemo);
            this.panel_Paint.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Paint.Location = new System.Drawing.Point(0, 0);
            this.panel_Paint.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panel_Paint.Name = "panel_Paint";
            this.panel_Paint.Size = new System.Drawing.Size(385, 816);
            this.panel_Paint.TabIndex = 3;
            // 
            // panel_ItemDemo
            // 
            this.panel_ItemDemo.Controls.Add(this.txt_Team_ProjectNameDemo);
            this.panel_ItemDemo.Controls.Add(this.ComboBox_TeamDemo);
            this.panel_ItemDemo.Controls.Add(this.ComboBox_StatusDemo);
            this.panel_ItemDemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.panel_ItemDemo.Location = new System.Drawing.Point(28, 3);
            this.panel_ItemDemo.Name = "panel_ItemDemo";
            this.panel_ItemDemo.Size = new System.Drawing.Size(350, 36);
            this.panel_ItemDemo.TabIndex = 0;
            this.panel_ItemDemo.Visible = false;
            // 
            // txt_Team_ProjectNameDemo
            // 
            this.txt_Team_ProjectNameDemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Team_ProjectNameDemo.Location = new System.Drawing.Point(0, 0);
            this.txt_Team_ProjectNameDemo.Name = "txt_Team_ProjectNameDemo";
            this.txt_Team_ProjectNameDemo.Size = new System.Drawing.Size(172, 34);
            this.txt_Team_ProjectNameDemo.TabIndex = 3;
            // 
            // ComboBox_TeamDemo
            // 
            this.ComboBox_TeamDemo.Dock = System.Windows.Forms.DockStyle.Right;
            this.ComboBox_TeamDemo.FormattingEnabled = true;
            this.ComboBox_TeamDemo.Items.AddRange(new object[] {
            "AMI",
            "ELA",
            "GI",
            "FP",
            "PI and LT",
            "Others"});
            this.ComboBox_TeamDemo.Location = new System.Drawing.Point(172, 0);
            this.ComboBox_TeamDemo.Name = "ComboBox_TeamDemo";
            this.ComboBox_TeamDemo.Size = new System.Drawing.Size(88, 37);
            this.ComboBox_TeamDemo.TabIndex = 2;
            // 
            // ComboBox_StatusDemo
            // 
            this.ComboBox_StatusDemo.Dock = System.Windows.Forms.DockStyle.Right;
            this.ComboBox_StatusDemo.FormattingEnabled = true;
            this.ComboBox_StatusDemo.Items.AddRange(new object[] {
            "进行中",
            "未启动",
            "已完成"});
            this.ComboBox_StatusDemo.Location = new System.Drawing.Point(260, 0);
            this.ComboBox_StatusDemo.Name = "ComboBox_StatusDemo";
            this.ComboBox_StatusDemo.Size = new System.Drawing.Size(90, 37);
            this.ComboBox_StatusDemo.Sorted = true;
            this.ComboBox_StatusDemo.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btn_Sort, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btn_Import, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btn_Delete, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_Add, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 481);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(406, 125);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // btn_Sort
            // 
            this.btn_Sort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sort.Location = new System.Drawing.Point(206, 65);
            this.btn_Sort.Name = "btn_Sort";
            this.btn_Sort.Size = new System.Drawing.Size(197, 57);
            this.btn_Sort.TabIndex = 3;
            this.btn_Sort.Text = "排 序";
            this.btn_Sort.UseVisualStyleBackColor = true;
            this.btn_Sort.Click += new System.EventHandler(this.Btn_Sort_Click);
            // 
            // btn_Import
            // 
            this.btn_Import.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Import.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Import.Location = new System.Drawing.Point(3, 65);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(197, 57);
            this.btn_Import.TabIndex = 2;
            this.btn_Import.Text = "导 入";
            this.btn_Import.UseVisualStyleBackColor = true;
            this.btn_Import.Click += new System.EventHandler(this.Btn_Import_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(206, 3);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(197, 56);
            this.btn_Delete.TabIndex = 1;
            this.btn_Delete.Text = "删 除";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(3, 3);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(197, 56);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "新 增";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 29);
            this.label8.TabIndex = 1;
            this.label8.Text = "项目列表";
            // 
            // panel_Finished
            // 
            this.panel_Finished.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Finished.Controls.Add(this.panel1);
            this.panel_Finished.Controls.Add(this.label9);
            this.panel_Finished.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Finished.Location = new System.Drawing.Point(1128, 131);
            this.panel_Finished.Name = "panel_Finished";
            this.panel_Finished.Size = new System.Drawing.Size(270, 608);
            this.panel_Finished.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 577);
            this.panel1.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 29);
            this.label9.TabIndex = 1;
            this.label9.Text = "已完成项目";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.panel_Paint);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 452);
            this.panel2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1422, 763);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "Form1";
            this.Text = "FEC Project Dashboard";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel_AMI.ResumeLayout(false);
            this.panel_AMI.PerformLayout();
            this.panel_ELA.ResumeLayout(false);
            this.panel_ELA.PerformLayout();
            this.panel_GI.ResumeLayout(false);
            this.panel_GI.PerformLayout();
            this.panel_FP.ResumeLayout(false);
            this.panel_FP.PerformLayout();
            this.panel_PILT.ResumeLayout(false);
            this.panel_PILT.PerformLayout();
            this.panel_Others.ResumeLayout(false);
            this.panel_Others.PerformLayout();
            this.panel_ManualSorting.ResumeLayout(false);
            this.panel_ManualSorting.PerformLayout();
            this.panel_Paint.ResumeLayout(false);
            this.panel_ItemDemo.ResumeLayout(false);
            this.panel_ItemDemo.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel_Finished.ResumeLayout(false);
            this.panel_Finished.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel_AMI;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_ELA;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_GI;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel_FP;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel_PILT;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel_Others;
        private System.Windows.Forms.ListBox listBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel_ManualSorting;
        private System.Windows.Forms.Panel panel_Finished;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel_Paint;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btn_Sort;
        private System.Windows.Forms.Button btn_Import;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_ItemDemo;
        private System.Windows.Forms.ComboBox ComboBox_StatusDemo;
        private System.Windows.Forms.ComboBox ComboBox_TeamDemo;
        private System.Windows.Forms.TextBox txt_Team_ProjectNameDemo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel2;
    }
}

