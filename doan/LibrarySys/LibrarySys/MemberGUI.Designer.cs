namespace LibrarySys
{
    partial class MemberGUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberGUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.issueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBooksToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lb_username = new System.Windows.Forms.ToolStripLabel();
            this.tsbtnLogout = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlBangdulieusach = new System.Windows.Forms.Panel();
            this.pn_searchtittle = new System.Windows.Forms.Panel();
            this.txt_tktittle = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pn_searchauthor = new System.Windows.Forms.Panel();
            this.txt_tkauthor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pn_ISBN = new System.Windows.Forms.Panel();
            this.btnSearchTaiLieu = new System.Windows.Forms.Button();
            this.txt_tkISBN = new System.Windows.Forms.TextBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchISBNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seachTittleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblsachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doAnDataSet = new LibrarySys.DoAnDataSet();
            this.btnReload = new System.Windows.Forms.Button();
            this.lblTacgia = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbl_sachTableAdapter = new LibrarySys.DoAnDataSetTableAdapters.tbl_sachTableAdapter();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlBangdulieusach.SuspendLayout();
            this.pn_searchtittle.SuspendLayout();
            this.pn_searchauthor.SuspendLayout();
            this.pn_ISBN.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAnDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1482, 44);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.issueToolStripMenuItem,
            this.returnBooksToolStripMenuItem,
            this.returnBooksToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 44);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1482, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // issueToolStripMenuItem
            // 
            this.issueToolStripMenuItem.Name = "issueToolStripMenuItem";
            this.issueToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.issueToolStripMenuItem.Text = "IssueBooks";
            // 
            // returnBooksToolStripMenuItem
            // 
            this.returnBooksToolStripMenuItem.Name = "returnBooksToolStripMenuItem";
            this.returnBooksToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.returnBooksToolStripMenuItem.Text = "ReturnBooks";
            // 
            // returnBooksToolStripMenuItem1
            // 
            this.returnBooksToolStripMenuItem1.Name = "returnBooksToolStripMenuItem1";
            this.returnBooksToolStripMenuItem1.Size = new System.Drawing.Size(107, 24);
            this.returnBooksToolStripMenuItem1.Text = "SearchBooks";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.toolStripSeparator1,
            this.lb_username,
            this.tsbtnLogout});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1482, 44);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Showcard Gothic", 18F);
            this.toolStripLabel1.Image = global::LibrarySys.Properties.Resources.bookshelf_library_icon_150961;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(167, 41);
            this.toolStripLabel1.Text = "Library";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(541, 41);
            this.toolStripLabel2.Text = "                                                                                 " +
    "                                                    ";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 44);
            // 
            // lb_username
            // 
            this.lb_username.Image = global::LibrarySys.Properties.Resources._4105938_account_card_id_identification_identity_card_profile_user_profile_113929;
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(95, 41);
            this.lb_username.Text = "Username";
            // 
            // tsbtnLogout
            // 
            this.tsbtnLogout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnLogout.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnLogout.Image")));
            this.tsbtnLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnLogout.Name = "tsbtnLogout";
            this.tsbtnLogout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsbtnLogout.Size = new System.Drawing.Size(29, 41);
            this.tsbtnLogout.Text = "Log out";
            this.tsbtnLogout.Click += new System.EventHandler(this.tsbtnLogout_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 909);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibrarySys.Properties.Resources.motivation1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 490);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // pnlBangdulieusach
            // 
            this.pnlBangdulieusach.BackColor = System.Drawing.Color.Lavender;
            this.pnlBangdulieusach.Controls.Add(this.pn_searchtittle);
            this.pnlBangdulieusach.Controls.Add(this.pn_searchauthor);
            this.pnlBangdulieusach.Controls.Add(this.pn_ISBN);
            this.pnlBangdulieusach.Controls.Add(this.menuStrip2);
            this.pnlBangdulieusach.Controls.Add(this.dataGridView1);
            this.pnlBangdulieusach.Controls.Add(this.btnReload);
            this.pnlBangdulieusach.Controls.Add(this.lblTacgia);
            this.pnlBangdulieusach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBangdulieusach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlBangdulieusach.Location = new System.Drawing.Point(160, 44);
            this.pnlBangdulieusach.Name = "pnlBangdulieusach";
            this.pnlBangdulieusach.Size = new System.Drawing.Size(1322, 909);
            this.pnlBangdulieusach.TabIndex = 2;
            // 
            // pn_searchtittle
            // 
            this.pn_searchtittle.Controls.Add(this.txt_tktittle);
            this.pn_searchtittle.Controls.Add(this.button2);
            this.pn_searchtittle.Location = new System.Drawing.Point(18, 137);
            this.pn_searchtittle.Name = "pn_searchtittle";
            this.pn_searchtittle.Size = new System.Drawing.Size(564, 85);
            this.pn_searchtittle.TabIndex = 31;
            // 
            // txt_tktittle
            // 
            this.txt_tktittle.Location = new System.Drawing.Point(285, 37);
            this.txt_tktittle.Multiline = true;
            this.txt_tktittle.Name = "txt_tktittle";
            this.txt_tktittle.Size = new System.Drawing.Size(253, 41);
            this.txt_tktittle.TabIndex = 29;
            this.txt_tktittle.TextChanged += new System.EventHandler(this.txt_tktittle_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(49, 37);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 41);
            this.button2.TabIndex = 30;
            this.button2.Text = "Search Tittle";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // pn_searchauthor
            // 
            this.pn_searchauthor.Controls.Add(this.txt_tkauthor);
            this.pn_searchauthor.Controls.Add(this.button1);
            this.pn_searchauthor.Location = new System.Drawing.Point(18, 43);
            this.pn_searchauthor.Name = "pn_searchauthor";
            this.pn_searchauthor.Size = new System.Drawing.Size(564, 91);
            this.pn_searchauthor.TabIndex = 30;
            // 
            // txt_tkauthor
            // 
            this.txt_tkauthor.Location = new System.Drawing.Point(285, 41);
            this.txt_tkauthor.Multiline = true;
            this.txt_tkauthor.Name = "txt_tkauthor";
            this.txt_tkauthor.Size = new System.Drawing.Size(253, 41);
            this.txt_tkauthor.TabIndex = 27;
            this.txt_tkauthor.TextChanged += new System.EventHandler(this.txt_tkauthor_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(49, 41);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 41);
            this.button1.TabIndex = 28;
            this.button1.Text = "Search Author";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pn_ISBN
            // 
            this.pn_ISBN.Controls.Add(this.btnSearchTaiLieu);
            this.pn_ISBN.Controls.Add(this.txt_tkISBN);
            this.pn_ISBN.Location = new System.Drawing.Point(608, 137);
            this.pn_ISBN.Name = "pn_ISBN";
            this.pn_ISBN.Size = new System.Drawing.Size(544, 85);
            this.pn_ISBN.TabIndex = 31;
            // 
            // btnSearchTaiLieu
            // 
            this.btnSearchTaiLieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnSearchTaiLieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchTaiLieu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTaiLieu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearchTaiLieu.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchTaiLieu.Image")));
            this.btnSearchTaiLieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchTaiLieu.Location = new System.Drawing.Point(49, 39);
            this.btnSearchTaiLieu.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchTaiLieu.Name = "btnSearchTaiLieu";
            this.btnSearchTaiLieu.Size = new System.Drawing.Size(215, 41);
            this.btnSearchTaiLieu.TabIndex = 22;
            this.btnSearchTaiLieu.Text = "Search ISBN";
            this.btnSearchTaiLieu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchTaiLieu.UseVisualStyleBackColor = false;
            // 
            // txt_tkISBN
            // 
            this.txt_tkISBN.Location = new System.Drawing.Point(291, 37);
            this.txt_tkISBN.Multiline = true;
            this.txt_tkISBN.Name = "txt_tkISBN";
            this.txt_tkISBN.Size = new System.Drawing.Size(253, 41);
            this.txt_tkISBN.TabIndex = 20;
            this.txt_tkISBN.TextChanged += new System.EventHandler(this.txt_timkiem_TextChanged);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1322, 28);
            this.menuStrip2.TabIndex = 26;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchISBNToolStripMenuItem,
            this.seachTittleToolStripMenuItem,
            this.seaToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(107, 24);
            this.toolStripMenuItem3.Text = "SearchBooks";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // searchISBNToolStripMenuItem
            // 
            this.searchISBNToolStripMenuItem.Name = "searchISBNToolStripMenuItem";
            this.searchISBNToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.searchISBNToolStripMenuItem.Text = "Search ISBN";
            this.searchISBNToolStripMenuItem.Click += new System.EventHandler(this.searchISBNToolStripMenuItem_Click);
            // 
            // seachTittleToolStripMenuItem
            // 
            this.seachTittleToolStripMenuItem.Name = "seachTittleToolStripMenuItem";
            this.seachTittleToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.seachTittleToolStripMenuItem.Text = "Search Tittle";
            this.seachTittleToolStripMenuItem.Click += new System.EventHandler(this.seachTittleToolStripMenuItem_Click);
            // 
            // seaToolStripMenuItem
            // 
            this.seaToolStripMenuItem.Name = "seaToolStripMenuItem";
            this.seaToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.seaToolStripMenuItem.Text = "Search Author";
            this.seaToolStripMenuItem.Click += new System.EventHandler(this.seaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(95, 24);
            this.toolStripMenuItem1.Text = "IssueBooks";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(106, 24);
            this.toolStripMenuItem2.Text = "ReturnBooks";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dataGridView1.DataSource = this.tblsachBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1292, 445);
            this.dataGridView1.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ISBN";
            this.dataGridViewTextBoxColumn5.HeaderText = "ISBN";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Tittle";
            this.dataGridViewTextBoxColumn6.HeaderText = "Tittle";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Author";
            this.dataGridViewTextBoxColumn7.HeaderText = "Author";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Manufacturer";
            this.dataGridViewTextBoxColumn8.HeaderText = "Manufacturer";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // tblsachBindingSource
            // 
            this.tblsachBindingSource.DataMember = "tbl_sach";
            this.tblsachBindingSource.DataSource = this.doAnDataSet;
            // 
            // doAnDataSet
            // 
            this.doAnDataSet.DataSetName = "DoAnDataSet";
            this.doAnDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnReload
            // 
            this.btnReload.BackgroundImage = global::LibrarySys.Properties.Resources.settings_reload_update_icon_188616;
            this.btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReload.Location = new System.Drawing.Point(1238, 43);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(41, 39);
            this.btnReload.TabIndex = 10;
            this.btnReload.UseVisualStyleBackColor = true;
            // 
            // lblTacgia
            // 
            this.lblTacgia.AutoSize = true;
            this.lblTacgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTacgia.Location = new System.Drawing.Point(835, 69);
            this.lblTacgia.Name = "lblTacgia";
            this.lblTacgia.Size = new System.Drawing.Size(124, 29);
            this.lblTacgia.TabIndex = 1;
            this.lblTacgia.Text = "List Books";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // tbl_sachTableAdapter
            // 
            this.tbl_sachTableAdapter.ClearBeforeFill = true;
            // 
            // MemberGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 953);
            this.Controls.Add(this.pnlBangdulieusach);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MemberGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemberGUI";
            this.Load += new System.EventHandler(this.MemberGUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlBangdulieusach.ResumeLayout(false);
            this.pnlBangdulieusach.PerformLayout();
            this.pn_searchtittle.ResumeLayout(false);
            this.pn_searchtittle.PerformLayout();
            this.pn_searchauthor.ResumeLayout(false);
            this.pn_searchauthor.PerformLayout();
            this.pn_ISBN.ResumeLayout(false);
            this.pn_ISBN.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAnDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlBangdulieusach;
        private System.Windows.Forms.Label lblTacgia;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.DataGridView dataGridView1;
      
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
     
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripLabel lb_username;
        private System.Windows.Forms.ToolStripButton tsbtnLogout;
        private System.Windows.Forms.TextBox txt_tkISBN;
        private System.Windows.Forms.Button btnSearchTaiLieu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem issueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBooksToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private DoAnDataSet doAnDataSet;
        private System.Windows.Forms.BindingSource tblsachBindingSource;
        private DoAnDataSetTableAdapters.tbl_sachTableAdapter tbl_sachTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_tktittle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_tkauthor;
        private System.Windows.Forms.ToolStripMenuItem searchISBNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seachTittleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seaToolStripMenuItem;
        private System.Windows.Forms.Panel pn_searchtittle;
        private System.Windows.Forms.Panel pn_ISBN;
        private System.Windows.Forms.Panel pn_searchauthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}