namespace WindowsFormsApp3.Forms
{
    partial class FormDietPlanSelection
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label103 = new System.Windows.Forms.Label();
            this.label101 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.planIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breakfastDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lunchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dinnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dietPlanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dB_PROJECTDataSet = new WindowsFormsApp3.DB_PROJECTDataSet();
            this.dietPlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_PROJECTDataSet1 = new WindowsFormsApp3.DB_PROJECTDataSet1();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.dietPlanTableAdapter = new WindowsFormsApp3.DB_PROJECTDataSetTableAdapters.DietPlanTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietPlanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PROJECTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietPlanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PROJECTDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::WindowsFormsApp3.Properties.Resources.filter;
            this.pictureBox2.Location = new System.Drawing.Point(883, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 67);
            this.pictureBox2.TabIndex = 176;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp3.Properties.Resources.Filter_Search;
            this.pictureBox1.Location = new System.Drawing.Point(509, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 106);
            this.pictureBox1.TabIndex = 175;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(57, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 174;
            this.label2.Text = "Nutrition";
            // 
            // comboBox5
            // 
            this.comboBox5.BackColor = System.Drawing.Color.SandyBrown;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "High carb",
            "High protein",
            "High fat",
            "High fibre"});
            this.comboBox5.Location = new System.Drawing.Point(195, 215);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(332, 24);
            this.comboBox5.TabIndex = 173;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(57, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 172;
            this.label1.Text = "Type";
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.Color.SandyBrown;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Vegan",
            "Vegetarian",
            "Flexitarian",
            "Pescatarian"});
            this.comboBox4.Location = new System.Drawing.Point(195, 185);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(332, 24);
            this.comboBox4.TabIndex = 171;
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.BackColor = System.Drawing.Color.Transparent;
            this.label103.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label103.ForeColor = System.Drawing.Color.Black;
            this.label103.Location = new System.Drawing.Point(56, 162);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(58, 17);
            this.label103.TabIndex = 170;
            this.label103.Text = "Purpose";
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.BackColor = System.Drawing.Color.Transparent;
            this.label101.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label101.ForeColor = System.Drawing.Color.Black;
            this.label101.Location = new System.Drawing.Point(56, 127);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(68, 17);
            this.label101.TabIndex = 169;
            this.label101.Text = "Category ";
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.SandyBrown;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Weight loss",
            "Muscle gain",
            "Maintenance"});
            this.comboBox3.Location = new System.Drawing.Point(194, 155);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(332, 24);
            this.comboBox3.TabIndex = 168;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.SandyBrown;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Your Plans",
            "Plans created by other users",
            "Plans created by trainers"});
            this.comboBox1.Location = new System.Drawing.Point(194, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(333, 24);
            this.comboBox1.TabIndex = 167;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chocolate;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(599, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 39);
            this.button1.TabIndex = 179;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            this.guna2DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.guna2DataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.guna2DataGridView1.ColumnHeadersHeight = 34;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.planIDDataGridViewTextBoxColumn,
            this.planNameDataGridViewTextBoxColumn,
            this.breakfastDataGridViewTextBoxColumn,
            this.lunchDataGridViewTextBoxColumn,
            this.dinnerDataGridViewTextBoxColumn});
            this.guna2DataGridView1.DataSource = this.dietPlanBindingSource1;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle15;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.guna2DataGridView1.Location = new System.Drawing.Point(29, 269);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 24;
            this.guna2DataGridView1.Size = new System.Drawing.Size(1495, 553);
            this.guna2DataGridView1.TabIndex = 180;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 34;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // planIDDataGridViewTextBoxColumn
            // 
            this.planIDDataGridViewTextBoxColumn.DataPropertyName = "PlanID";
            this.planIDDataGridViewTextBoxColumn.HeaderText = "PlanID";
            this.planIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.planIDDataGridViewTextBoxColumn.Name = "planIDDataGridViewTextBoxColumn";
            this.planIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // planNameDataGridViewTextBoxColumn
            // 
            this.planNameDataGridViewTextBoxColumn.DataPropertyName = "PlanName";
            this.planNameDataGridViewTextBoxColumn.HeaderText = "PlanName";
            this.planNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.planNameDataGridViewTextBoxColumn.Name = "planNameDataGridViewTextBoxColumn";
            this.planNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // breakfastDataGridViewTextBoxColumn
            // 
            this.breakfastDataGridViewTextBoxColumn.DataPropertyName = "Breakfast";
            this.breakfastDataGridViewTextBoxColumn.HeaderText = "Breakfast";
            this.breakfastDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.breakfastDataGridViewTextBoxColumn.Name = "breakfastDataGridViewTextBoxColumn";
            this.breakfastDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lunchDataGridViewTextBoxColumn
            // 
            this.lunchDataGridViewTextBoxColumn.DataPropertyName = "Lunch";
            this.lunchDataGridViewTextBoxColumn.HeaderText = "Lunch";
            this.lunchDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lunchDataGridViewTextBoxColumn.Name = "lunchDataGridViewTextBoxColumn";
            this.lunchDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dinnerDataGridViewTextBoxColumn
            // 
            this.dinnerDataGridViewTextBoxColumn.DataPropertyName = "Dinner";
            this.dinnerDataGridViewTextBoxColumn.HeaderText = "Dinner";
            this.dinnerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dinnerDataGridViewTextBoxColumn.Name = "dinnerDataGridViewTextBoxColumn";
            this.dinnerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dietPlanBindingSource1
            // 
            this.dietPlanBindingSource1.DataMember = "DietPlan";
            this.dietPlanBindingSource1.DataSource = this.dB_PROJECTDataSet;
            // 
            // dB_PROJECTDataSet
            // 
            this.dB_PROJECTDataSet.DataSetName = "DB_PROJECTDataSet";
            this.dB_PROJECTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dietPlanBindingSource
            // 
            this.dietPlanBindingSource.DataMember = "DietPlan";
            this.dietPlanBindingSource.DataSource = this.dB_PROJECTDataSet1;
            // 
            // dB_PROJECTDataSet1
            // 
            this.dB_PROJECTDataSet1.DataSetName = "DB_PROJECTDataSet1";
            this.dB_PROJECTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Chocolate;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(819, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(273, 39);
            this.button2.TabIndex = 181;
            this.button2.Text = "Breakfast Claories Less than 500";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Chocolate;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(1293, 162);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(212, 39);
            this.button3.TabIndex = 182;
            this.button3.Text = "Total Carbs Less than 300";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(85, 856);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(245, 25);
            this.label7.TabIndex = 183;
            this.label7.Text = "Plan ID you want to adopt: ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SandyBrown;
            this.textBox1.Location = new System.Drawing.Point(367, 860);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(313, 22);
            this.textBox1.TabIndex = 184;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Chocolate;
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(771, 852);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 39);
            this.button4.TabIndex = 185;
            this.button4.Text = "Adopt";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dietPlanTableAdapter
            // 
            this.dietPlanTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Chocolate;
            this.button5.Location = new System.Drawing.Point(599, 187);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 45);
            this.button5.TabIndex = 199;
            this.button5.Text = "Clear Filters";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FormDietPlanSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.childform_bg_image;
            this.ClientSize = new System.Drawing.Size(1614, 906);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label103);
            this.Controls.Add(this.label101);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox1);
            this.Name = "FormDietPlanSelection";
            this.Text = "FormDietPlanSelection";
            this.Load += new System.EventHandler(this.FormDietPlanSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietPlanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PROJECTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietPlanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PROJECTDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private DB_PROJECTDataSet1 dB_PROJECTDataSet1;
        private System.Windows.Forms.BindingSource dietPlanBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn planIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn breakfastDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lunchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dinnerDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private DB_PROJECTDataSet dB_PROJECTDataSet;
        private System.Windows.Forms.BindingSource dietPlanBindingSource1;
        private DB_PROJECTDataSetTableAdapters.DietPlanTableAdapter dietPlanTableAdapter;
        private System.Windows.Forms.Button button5;
    }
}