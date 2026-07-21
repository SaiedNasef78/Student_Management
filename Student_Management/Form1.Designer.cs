namespace Student_Management
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.text_Gender = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.text_Grade = new System.Windows.Forms.TextBox();
            this.text_Name = new System.Windows.Forms.TextBox();
            this.text_Email = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.text_Phone = new System.Windows.Forms.TextBox();
            this.text_ID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.CB_Grade = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.MST_PhoneInfo = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.text_NameInfo = new System.Windows.Forms.TextBox();
            this.text_EmailInfo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.MST_ID = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Grade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.btn_Refresh);
            this.groupBox1.Controls.Add(this.text_Gender);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.text_Grade);
            this.groupBox1.Controls.Add(this.text_Name);
            this.groupBox1.Controls.Add(this.text_Email);
            this.groupBox1.Controls.Add(this.textID);
            this.groupBox1.Controls.Add(this.text_Phone);
            this.groupBox1.Controls.Add(this.text_ID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(730, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(658, 347);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ID Card";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Transparent;
            this.btn_Refresh.BackgroundImage = global::Student_Management.Properties.Resources.icons8_sync_64;
            this.btn_Refresh.Location = new System.Drawing.Point(549, 266);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(68, 64);
            this.btn_Refresh.TabIndex = 10;
            this.btn_Refresh.Text = "button1";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // text_Gender
            // 
            this.text_Gender.Location = new System.Drawing.Point(306, 280);
            this.text_Gender.Multiline = true;
            this.text_Gender.Name = "text_Gender";
            this.text_Gender.ReadOnly = true;
            this.text_Gender.Size = new System.Drawing.Size(129, 36);
            this.text_Gender.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(239, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 33);
            this.label10.TabIndex = 8;
            this.label10.Text = "Gender : ";
            // 
            // text_Grade
            // 
            this.text_Grade.Location = new System.Drawing.Point(306, 228);
            this.text_Grade.Multiline = true;
            this.text_Grade.Name = "text_Grade";
            this.text_Grade.ReadOnly = true;
            this.text_Grade.Size = new System.Drawing.Size(129, 36);
            this.text_Grade.TabIndex = 7;
            // 
            // text_Name
            // 
            this.text_Name.Location = new System.Drawing.Point(306, 72);
            this.text_Name.Multiline = true;
            this.text_Name.Name = "text_Name";
            this.text_Name.ReadOnly = true;
            this.text_Name.Size = new System.Drawing.Size(325, 36);
            this.text_Name.TabIndex = 6;
            // 
            // text_Email
            // 
            this.text_Email.Location = new System.Drawing.Point(306, 124);
            this.text_Email.Multiline = true;
            this.text_Email.Name = "text_Email";
            this.text_Email.ReadOnly = true;
            this.text_Email.Size = new System.Drawing.Size(325, 36);
            this.text_Email.TabIndex = 6;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(296, 20);
            this.textID.Multiline = true;
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(120, 36);
            this.textID.TabIndex = 5;
            // 
            // text_Phone
            // 
            this.text_Phone.Location = new System.Drawing.Point(306, 176);
            this.text_Phone.Multiline = true;
            this.text_Phone.Name = "text_Phone";
            this.text_Phone.ReadOnly = true;
            this.text_Phone.Size = new System.Drawing.Size(325, 36);
            this.text_Phone.TabIndex = 6;
            // 
            // text_ID
            // 
            this.text_ID.Location = new System.Drawing.Point(296, 20);
            this.text_ID.Multiline = true;
            this.text_ID.Name = "text_ID";
            this.text_ID.ReadOnly = true;
            this.text_ID.Size = new System.Drawing.Size(120, 36);
            this.text_ID.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(242, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 33);
            this.label7.TabIndex = 4;
            this.label7.Text = "Grade : ";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(239, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 33);
            this.label9.TabIndex = 1;
            this.label9.Text = " Name : ";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(242, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 33);
            this.label6.TabIndex = 3;
            this.label6.Text = "Phone : ";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(244, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 33);
            this.label5.TabIndex = 2;
            this.label5.Text = "Email : ";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(253, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = " ID : ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(239, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = " Name : ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = " ID : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Student_Management.Properties.Resources.Icon_Anonmous;
            this.pictureBox1.Location = new System.Drawing.Point(16, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1387, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "                                                                                 " +
    "                Student Managment";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.maskedTextBox1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(708, 284);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student Info";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.CB_Grade);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.MST_PhoneInfo);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.text_NameInfo);
            this.groupBox3.Controls.Add(this.text_EmailInfo);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.MST_ID);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.menuStrip1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(703, 283);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Student Info";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rb_Female);
            this.groupBox4.Controls.Add(this.rb_Male);
            this.groupBox4.Location = new System.Drawing.Point(472, 46);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(230, 79);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Gender";
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.Location = new System.Drawing.Point(128, 44);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(86, 24);
            this.rb_Female.TabIndex = 1;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Female";
            this.rb_Female.UseVisualStyleBackColor = true;
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.Location = new System.Drawing.Point(28, 44);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(65, 24);
            this.rb_Male.TabIndex = 0;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Male";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // CB_Grade
            // 
            this.CB_Grade.BackColor = System.Drawing.Color.White;
            this.CB_Grade.FormattingEnabled = true;
            this.CB_Grade.Items.AddRange(new object[] {
            "Low",
            "Middle",
            "High"});
            this.CB_Grade.Location = new System.Drawing.Point(78, 223);
            this.CB_Grade.Name = "CB_Grade";
            this.CB_Grade.Size = new System.Drawing.Size(150, 28);
            this.CB_Grade.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(5, 229);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 33);
            this.label16.TabIndex = 15;
            this.label16.Text = "Grade : ";
            // 
            // MST_PhoneInfo
            // 
            this.MST_PhoneInfo.Location = new System.Drawing.Point(73, 175);
            this.MST_PhoneInfo.Mask = "(999) 000-0000";
            this.MST_PhoneInfo.Name = "MST_PhoneInfo";
            this.MST_PhoneInfo.Size = new System.Drawing.Size(320, 26);
            this.MST_PhoneInfo.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(0, 181);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 33);
            this.label15.TabIndex = 13;
            this.label15.Text = "Phone : ";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(5, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 33);
            this.label12.TabIndex = 10;
            this.label12.Text = "Email : ";
            // 
            // text_NameInfo
            // 
            this.text_NameInfo.Location = new System.Drawing.Point(68, 69);
            this.text_NameInfo.Multiline = true;
            this.text_NameInfo.Name = "text_NameInfo";
            this.text_NameInfo.Size = new System.Drawing.Size(325, 36);
            this.text_NameInfo.TabIndex = 9;
            // 
            // text_EmailInfo
            // 
            this.text_EmailInfo.Location = new System.Drawing.Point(68, 127);
            this.text_EmailInfo.Multiline = true;
            this.text_EmailInfo.Name = "text_EmailInfo";
            this.text_EmailInfo.Size = new System.Drawing.Size(325, 36);
            this.text_EmailInfo.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(0, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 33);
            this.label13.TabIndex = 7;
            this.label13.Text = " Name : ";
            // 
            // MST_ID
            // 
            this.MST_ID.Location = new System.Drawing.Point(68, 27);
            this.MST_ID.Mask = "00000";
            this.MST_ID.Name = "MST_ID";
            this.MST_ID.Size = new System.Drawing.Size(58, 26);
            this.MST_ID.TabIndex = 2;
            this.MST_ID.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MST_ID_MaskInputRejected);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 33);
            this.label14.TabIndex = 1;
            this.label14.Text = " ID : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 69);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(325, 36);
            this.textBox1.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(0, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 33);
            this.label11.TabIndex = 7;
            this.label11.Text = " Name : ";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(68, 27);
            this.maskedTextBox1.Mask = "00000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(58, 26);
            this.maskedTextBox1.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 33);
            this.label8.TabIndex = 1;
            this.label8.Text = " ID : ";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Window;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.col_Name,
            this.Email,
            this.Phone,
            this.Grade,
            this.Gender});
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(12, 445);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1367, 283);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 80;
            // 
            // col_Name
            // 
            this.col_Name.Text = "Name";
            this.col_Name.Width = 150;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 250;
            // 
            // Phone
            // 
            this.Phone.Text = "Phone";
            this.Phone.Width = 100;
            // 
            // Grade
            // 
            this.Grade.Text = "Grade";
            // 
            // Gender
            // 
            this.Gender.Text = "Gender";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Icon Gir.png");
            this.imageList1.Images.SetKeyName(1, "Boy.png");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Boy.png");
            this.imageList2.Images.SetKeyName(1, "Girl.png");
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.BackgroundImage = global::Student_Management.Properties.Resources.icons8_add_94;
            this.btnAdd.Location = new System.Drawing.Point(179, 340);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 99);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.White;
            this.btn_Delete.BackgroundImage = global::Student_Management.Properties.Resources.icons8_remove_100;
            this.btn_Delete.Location = new System.Drawing.Point(330, 340);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(107, 99);
            this.btn_Delete.TabIndex = 13;
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.BackColor = System.Drawing.Color.White;
            this.btn_Print.BackgroundImage = global::Student_Management.Properties.Resources.icons8_print_94;
            this.btn_Print.Location = new System.Drawing.Point(34, 345);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(99, 94);
            this.btn_Print.TabIndex = 11;
            this.btn_Print.UseVisualStyleBackColor = false;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(3, 22);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(697, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1389, 759);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Student Managment";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_Phone;
        private System.Windows.Forms.TextBox text_ID;
        private System.Windows.Forms.TextBox text_Gender;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox text_Grade;
        private System.Windows.Forms.TextBox text_Name;
        private System.Windows.Forms.TextBox text_Email;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox MST_PhoneInfo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox text_NameInfo;
        private System.Windows.Forms.TextBox text_EmailInfo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox MST_ID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CB_Grade;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader col_Name;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.ColumnHeader Grade;
        private System.Windows.Forms.ColumnHeader Gender;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

