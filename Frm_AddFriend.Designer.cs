namespace MyQQ
{
    partial class Frm_AddFriend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AddFriend));
            this.pictureBox_Close = new System.Windows.Forms.PictureBox();
            this.pictureBox_Min = new System.Windows.Forms.PictureBox();
            this.tabControl_Search = new System.Windows.Forms.TabControl();
            this.tabPage_BaseSearch = new System.Windows.Forms.TabPage();
            this.panel_BasicCondition = new System.Windows.Forms.Panel();
            this.panel_BaseResult = new System.Windows.Forms.Panel();
            this.dataGridView_BasicResult = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NickName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.groupBox_BaseCondition = new System.Windows.Forms.GroupBox();
            this.textBox_NickName = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_SearchType = new System.Windows.Forms.Panel();
            this.radioButton_DetailSearch = new System.Windows.Forms.RadioButton();
            this.radioButton_All = new System.Windows.Forms.RadioButton();
            this.label_BaseCondition = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabPage_AdvanceSearch = new System.Windows.Forms.TabPage();
            this.panel_AdvancedCondition = new System.Windows.Forms.Panel();
            this.panel_AdvancedResult = new System.Windows.Forms.Panel();
            this.dataGridView_AdvancedResult = new System.Windows.Forms.DataGridView();
            this.label_AdvancedSearch = new System.Windows.Forms.Label();
            this.pictureBox_Search = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_Sex = new System.Windows.Forms.ComboBox();
            this.comboBox_Age = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_AdvanceCondition = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button_Back = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_Search = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Min)).BeginInit();
            this.tabControl_Search.SuspendLayout();
            this.tabPage_BaseSearch.SuspendLayout();
            this.panel_BasicCondition.SuspendLayout();
            this.panel_BaseResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BasicResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.groupBox_BaseCondition.SuspendLayout();
            this.panel_SearchType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabPage_AdvanceSearch.SuspendLayout();
            this.panel_AdvancedCondition.SuspendLayout();
            this.panel_AdvancedResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AdvancedResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Search)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Close
            // 
            this.pictureBox_Close.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Close.Location = new System.Drawing.Point(470, 0);
            this.pictureBox_Close.Name = "pictureBox_Close";
            this.pictureBox_Close.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_Close.TabIndex = 1;
            this.pictureBox_Close.TabStop = false;
            this.pictureBox_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // pictureBox_Min
            // 
            this.pictureBox_Min.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Min.Location = new System.Drawing.Point(439, 0);
            this.pictureBox_Min.Name = "pictureBox_Min";
            this.pictureBox_Min.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_Min.TabIndex = 2;
            this.pictureBox_Min.TabStop = false;
            this.pictureBox_Min.Click += new System.EventHandler(this.pictureBox_Min_Click);
            // 
            // tabControl_Search
            // 
            this.tabControl_Search.Controls.Add(this.tabPage_BaseSearch);
            this.tabControl_Search.Controls.Add(this.tabPage_AdvanceSearch);
            this.tabControl_Search.Location = new System.Drawing.Point(125, 28);
            this.tabControl_Search.Name = "tabControl_Search";
            this.tabControl_Search.SelectedIndex = 0;
            this.tabControl_Search.Size = new System.Drawing.Size(377, 266);
            this.tabControl_Search.TabIndex = 0;
            // 
            // tabPage_BaseSearch
            // 
            this.tabPage_BaseSearch.Controls.Add(this.panel_BasicCondition);
            this.tabPage_BaseSearch.Location = new System.Drawing.Point(4, 22);
            this.tabPage_BaseSearch.Name = "tabPage_BaseSearch";
            this.tabPage_BaseSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_BaseSearch.Size = new System.Drawing.Size(369, 240);
            this.tabPage_BaseSearch.TabIndex = 0;
            this.tabPage_BaseSearch.Text = "基本查找";
            this.tabPage_BaseSearch.UseVisualStyleBackColor = true;
            // 
            // panel_BasicCondition
            // 
            this.panel_BasicCondition.Controls.Add(this.panel_BaseResult);
            this.panel_BasicCondition.Controls.Add(this.groupBox_BaseCondition);
            this.panel_BasicCondition.Controls.Add(this.panel_SearchType);
            this.panel_BasicCondition.Controls.Add(this.label_BaseCondition);
            this.panel_BasicCondition.Controls.Add(this.pictureBox3);
            this.panel_BasicCondition.Location = new System.Drawing.Point(3, 3);
            this.panel_BasicCondition.Name = "panel_BasicCondition";
            this.panel_BasicCondition.Size = new System.Drawing.Size(363, 234);
            this.panel_BasicCondition.TabIndex = 0;
            // 
            // panel_BaseResult
            // 
            this.panel_BaseResult.Controls.Add(this.dataGridView_BasicResult);
            this.panel_BaseResult.Controls.Add(this.label5);
            this.panel_BaseResult.Controls.Add(this.pictureBox5);
            this.panel_BaseResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_BaseResult.Location = new System.Drawing.Point(0, 0);
            this.panel_BaseResult.Name = "panel_BaseResult";
            this.panel_BaseResult.Size = new System.Drawing.Size(363, 234);
            this.panel_BaseResult.TabIndex = 6;
            this.panel_BaseResult.Visible = false;
            // 
            // dataGridView_BasicResult
            // 
            this.dataGridView_BasicResult.AllowUserToAddRows = false;
            this.dataGridView_BasicResult.AllowUserToDeleteRows = false;
            this.dataGridView_BasicResult.AllowUserToResizeColumns = false;
            this.dataGridView_BasicResult.AllowUserToResizeRows = false;
            this.dataGridView_BasicResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_BasicResult.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_BasicResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_BasicResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_BasicResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.NickName,
            this.Age,
            this.Sex});
            this.dataGridView_BasicResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_BasicResult.GridColor = System.Drawing.Color.White;
            this.dataGridView_BasicResult.Location = new System.Drawing.Point(0, 65);
            this.dataGridView_BasicResult.MultiSelect = false;
            this.dataGridView_BasicResult.Name = "dataGridView_BasicResult";
            this.dataGridView_BasicResult.ReadOnly = true;
            this.dataGridView_BasicResult.RowHeadersVisible = false;
            this.dataGridView_BasicResult.RowTemplate.Height = 23;
            this.dataGridView_BasicResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_BasicResult.Size = new System.Drawing.Size(363, 169);
            this.dataGridView_BasicResult.TabIndex = 6;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "MyQQ帐号";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // NickName
            // 
            this.NickName.DataPropertyName = "NickName";
            this.NickName.HeaderText = "昵称";
            this.NickName.Name = "NickName";
            this.NickName.ReadOnly = true;
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "年龄";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // Sex
            // 
            this.Sex.DataPropertyName = "Sex";
            this.Sex.HeaderText = "性别";
            this.Sex.Name = "Sex";
            this.Sex.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "以下是MyQQ为您找到的结果";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::MyQQ.Properties.Resources.search;
            this.pictureBox5.Location = new System.Drawing.Point(83, 22);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(17, 18);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // groupBox_BaseCondition
            // 
            this.groupBox_BaseCondition.Controls.Add(this.textBox_NickName);
            this.groupBox_BaseCondition.Controls.Add(this.textBox_ID);
            this.groupBox_BaseCondition.Controls.Add(this.label3);
            this.groupBox_BaseCondition.Controls.Add(this.label2);
            this.groupBox_BaseCondition.Location = new System.Drawing.Point(26, 112);
            this.groupBox_BaseCondition.Name = "groupBox_BaseCondition";
            this.groupBox_BaseCondition.Size = new System.Drawing.Size(306, 100);
            this.groupBox_BaseCondition.TabIndex = 5;
            this.groupBox_BaseCondition.TabStop = false;
            this.groupBox_BaseCondition.Text = "精确查找条件";
            this.groupBox_BaseCondition.Visible = false;
            // 
            // textBox_NickName
            // 
            this.textBox_NickName.Location = new System.Drawing.Point(106, 60);
            this.textBox_NickName.Name = "textBox_NickName";
            this.textBox_NickName.Size = new System.Drawing.Size(146, 21);
            this.textBox_NickName.TabIndex = 3;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(106, 33);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(146, 21);
            this.textBox_ID.TabIndex = 2;
            this.textBox_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ID_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "对方昵称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "对方账号：";
            // 
            // panel_SearchType
            // 
            this.panel_SearchType.Controls.Add(this.radioButton_DetailSearch);
            this.panel_SearchType.Controls.Add(this.radioButton_All);
            this.panel_SearchType.Location = new System.Drawing.Point(81, 44);
            this.panel_SearchType.Name = "panel_SearchType";
            this.panel_SearchType.Size = new System.Drawing.Size(197, 51);
            this.panel_SearchType.TabIndex = 4;
            // 
            // radioButton_DetailSearch
            // 
            this.radioButton_DetailSearch.AutoSize = true;
            this.radioButton_DetailSearch.Location = new System.Drawing.Point(10, 28);
            this.radioButton_DetailSearch.Name = "radioButton_DetailSearch";
            this.radioButton_DetailSearch.Size = new System.Drawing.Size(71, 16);
            this.radioButton_DetailSearch.TabIndex = 1;
            this.radioButton_DetailSearch.Text = "精确查找";
            this.radioButton_DetailSearch.UseVisualStyleBackColor = true;
            this.radioButton_DetailSearch.CheckedChanged += new System.EventHandler(this.radioButton_DetailSearch_CheckedChanged);
            // 
            // radioButton_All
            // 
            this.radioButton_All.AutoSize = true;
            this.radioButton_All.Checked = true;
            this.radioButton_All.Location = new System.Drawing.Point(10, 6);
            this.radioButton_All.Name = "radioButton_All";
            this.radioButton_All.Size = new System.Drawing.Size(83, 16);
            this.radioButton_All.TabIndex = 0;
            this.radioButton_All.TabStop = true;
            this.radioButton_All.Text = "查找所有人";
            this.radioButton_All.UseVisualStyleBackColor = true;
            // 
            // label_BaseCondition
            // 
            this.label_BaseCondition.AutoSize = true;
            this.label_BaseCondition.Location = new System.Drawing.Point(81, 21);
            this.label_BaseCondition.Name = "label_BaseCondition";
            this.label_BaseCondition.Size = new System.Drawing.Size(173, 12);
            this.label_BaseCondition.TabIndex = 3;
            this.label_BaseCondition.Text = "可以设置精确查询条件查找好友";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MyQQ.Properties.Resources.search;
            this.pictureBox3.Location = new System.Drawing.Point(40, 18);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(17, 18);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // tabPage_AdvanceSearch
            // 
            this.tabPage_AdvanceSearch.Controls.Add(this.panel_AdvancedCondition);
            this.tabPage_AdvanceSearch.Location = new System.Drawing.Point(4, 22);
            this.tabPage_AdvanceSearch.Name = "tabPage_AdvanceSearch";
            this.tabPage_AdvanceSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_AdvanceSearch.Size = new System.Drawing.Size(369, 240);
            this.tabPage_AdvanceSearch.TabIndex = 1;
            this.tabPage_AdvanceSearch.Text = "高级查找";
            this.tabPage_AdvanceSearch.UseVisualStyleBackColor = true;
            // 
            // panel_AdvancedCondition
            // 
            this.panel_AdvancedCondition.Controls.Add(this.panel_AdvancedResult);
            this.panel_AdvancedCondition.Controls.Add(this.groupBox2);
            this.panel_AdvancedCondition.Controls.Add(this.label_AdvanceCondition);
            this.panel_AdvancedCondition.Controls.Add(this.pictureBox4);
            this.panel_AdvancedCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_AdvancedCondition.Location = new System.Drawing.Point(3, 3);
            this.panel_AdvancedCondition.Name = "panel_AdvancedCondition";
            this.panel_AdvancedCondition.Size = new System.Drawing.Size(363, 234);
            this.panel_AdvancedCondition.TabIndex = 1;
            // 
            // panel_AdvancedResult
            // 
            this.panel_AdvancedResult.Controls.Add(this.dataGridView_AdvancedResult);
            this.panel_AdvancedResult.Controls.Add(this.label_AdvancedSearch);
            this.panel_AdvancedResult.Controls.Add(this.pictureBox_Search);
            this.panel_AdvancedResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_AdvancedResult.Location = new System.Drawing.Point(0, 0);
            this.panel_AdvancedResult.Name = "panel_AdvancedResult";
            this.panel_AdvancedResult.Size = new System.Drawing.Size(363, 234);
            this.panel_AdvancedResult.TabIndex = 2;
            this.panel_AdvancedResult.Visible = false;
            // 
            // dataGridView_AdvancedResult
            // 
            this.dataGridView_AdvancedResult.AllowUserToAddRows = false;
            this.dataGridView_AdvancedResult.AllowUserToDeleteRows = false;
            this.dataGridView_AdvancedResult.AllowUserToResizeColumns = false;
            this.dataGridView_AdvancedResult.AllowUserToResizeRows = false;
            this.dataGridView_AdvancedResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_AdvancedResult.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_AdvancedResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_AdvancedResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AdvancedResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView_AdvancedResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_AdvancedResult.GridColor = System.Drawing.Color.White;
            this.dataGridView_AdvancedResult.Location = new System.Drawing.Point(0, 65);
            this.dataGridView_AdvancedResult.MultiSelect = false;
            this.dataGridView_AdvancedResult.Name = "dataGridView_AdvancedResult";
            this.dataGridView_AdvancedResult.ReadOnly = true;
            this.dataGridView_AdvancedResult.RowHeadersVisible = false;
            this.dataGridView_AdvancedResult.RowTemplate.Height = 23;
            this.dataGridView_AdvancedResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_AdvancedResult.Size = new System.Drawing.Size(363, 169);
            this.dataGridView_AdvancedResult.TabIndex = 6;
            // 
            // label_AdvancedSearch
            // 
            this.label_AdvancedSearch.AutoSize = true;
            this.label_AdvancedSearch.Location = new System.Drawing.Point(113, 20);
            this.label_AdvancedSearch.Name = "label_AdvancedSearch";
            this.label_AdvancedSearch.Size = new System.Drawing.Size(149, 12);
            this.label_AdvancedSearch.TabIndex = 5;
            this.label_AdvancedSearch.Text = "以下是MyQQ为您找到的结果";
            // 
            // pictureBox_Search
            // 
            this.pictureBox_Search.Image = global::MyQQ.Properties.Resources.search;
            this.pictureBox_Search.Location = new System.Drawing.Point(82, 17);
            this.pictureBox_Search.Name = "pictureBox_Search";
            this.pictureBox_Search.Size = new System.Drawing.Size(17, 18);
            this.pictureBox_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Search.TabIndex = 4;
            this.pictureBox_Search.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox_Sex);
            this.groupBox2.Controls.Add(this.comboBox_Age);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(53, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 120);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "基本条件";
            // 
            // comboBox_Sex
            // 
            this.comboBox_Sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Sex.FormattingEnabled = true;
            this.comboBox_Sex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comboBox_Sex.Location = new System.Drawing.Point(68, 61);
            this.comboBox_Sex.Name = "comboBox_Sex";
            this.comboBox_Sex.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Sex.TabIndex = 3;
            // 
            // comboBox_Age
            // 
            this.comboBox_Age.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Age.FormattingEnabled = true;
            this.comboBox_Age.Items.AddRange(new object[] {
            "不限",
            "0～10岁",
            "10～20岁",
            "20～30岁",
            "30～40岁",
            "40～50岁",
            "50岁以上"});
            this.comboBox_Age.Location = new System.Drawing.Point(68, 27);
            this.comboBox_Age.Name = "comboBox_Age";
            this.comboBox_Age.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Age.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "性别：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "年龄：";
            // 
            // label_AdvanceCondition
            // 
            this.label_AdvanceCondition.AutoSize = true;
            this.label_AdvanceCondition.Location = new System.Drawing.Point(94, 23);
            this.label_AdvanceCondition.Name = "label_AdvanceCondition";
            this.label_AdvanceCondition.Size = new System.Drawing.Size(161, 12);
            this.label_AdvanceCondition.TabIndex = 4;
            this.label_AdvanceCondition.Text = "可以通过年龄或性别进行查找";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::MyQQ.Properties.Resources.search;
            this.pictureBox4.Location = new System.Drawing.Point(53, 17);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(17, 18);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(250, 299);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(75, 23);
            this.button_Back.TabIndex = 4;
            this.button_Back.Text = "上一步";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Visible = false;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(331, 299);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 5;
            this.button_Add.Text = "加为好友";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Visible = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(412, 299);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(75, 23);
            this.button_Close.TabIndex = 6;
            this.button_Close.Text = "关闭";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(333, 299);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(71, 23);
            this.button_Search.TabIndex = 3;
            this.button_Search.Text = "查找";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "MyQQ帐号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NickName";
            this.dataGridViewTextBoxColumn2.HeaderText = "昵称";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Age";
            this.dataGridViewTextBoxColumn3.HeaderText = "年龄";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Sex";
            this.dataGridViewTextBoxColumn4.HeaderText = "性别";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Frm_AddFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyQQ.Properties.Resources.searchback;
            this.ClientSize = new System.Drawing.Size(499, 329);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.tabControl_Search);
            this.Controls.Add(this.pictureBox_Min);
            this.Controls.Add(this.pictureBox_Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_AddFriend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查找/添加好友";
            this.Load += new System.EventHandler(this.Frm_AddFriend_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_AddFriend_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Min)).EndInit();
            this.tabControl_Search.ResumeLayout(false);
            this.tabPage_BaseSearch.ResumeLayout(false);
            this.panel_BasicCondition.ResumeLayout(false);
            this.panel_BasicCondition.PerformLayout();
            this.panel_BaseResult.ResumeLayout(false);
            this.panel_BaseResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BasicResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.groupBox_BaseCondition.ResumeLayout(false);
            this.groupBox_BaseCondition.PerformLayout();
            this.panel_SearchType.ResumeLayout(false);
            this.panel_SearchType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabPage_AdvanceSearch.ResumeLayout(false);
            this.panel_AdvancedCondition.ResumeLayout(false);
            this.panel_AdvancedCondition.PerformLayout();
            this.panel_AdvancedResult.ResumeLayout(false);
            this.panel_AdvancedResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AdvancedResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Search)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Close;
        private System.Windows.Forms.PictureBox pictureBox_Min;
        private System.Windows.Forms.TabControl tabControl_Search;
        private System.Windows.Forms.TabPage tabPage_BaseSearch;
        private System.Windows.Forms.TabPage tabPage_AdvanceSearch;
        private System.Windows.Forms.Panel panel_BasicCondition;
        private System.Windows.Forms.Panel panel_BaseResult;
        private System.Windows.Forms.DataGridView dataGridView_BasicResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.GroupBox groupBox_BaseCondition;
        private System.Windows.Forms.TextBox textBox_NickName;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_SearchType;
        private System.Windows.Forms.RadioButton radioButton_DetailSearch;
        private System.Windows.Forms.RadioButton radioButton_All;
        private System.Windows.Forms.Label label_BaseCondition;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel_AdvancedCondition;
        private System.Windows.Forms.Panel panel_AdvancedResult;
        private System.Windows.Forms.DataGridView dataGridView_AdvancedResult;
        private System.Windows.Forms.Label label_AdvancedSearch;
        private System.Windows.Forms.PictureBox pictureBox_Search;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox_Sex;
        private System.Windows.Forms.ComboBox comboBox_Age;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_AdvanceCondition;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NickName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}