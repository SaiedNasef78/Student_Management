namespace Student_Management
{
    partial class frmPrintCard
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.text_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_Name = new System.Windows.Forms.TextBox();
            this.text_Email = new System.Windows.Forms.TextBox();
            this.text_Phone = new System.Windows.Forms.TextBox();
            this.text_Grade = new System.Windows.Forms.TextBox();
            this.text_Gender = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.text_Gender);
            this.groupBox1.Controls.Add(this.text_Grade);
            this.groupBox1.Controls.Add(this.text_Phone);
            this.groupBox1.Controls.Add(this.text_Email);
            this.groupBox1.Controls.Add(this.text_Name);
            this.groupBox1.Controls.Add(this.text_ID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 374);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ID Card";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(263, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(250, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email : ";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(250, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone : ";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(250, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Grade : ";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(250, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gender : ";
            // 
            // text_ID
            // 
            this.text_ID.Location = new System.Drawing.Point(329, 21);
            this.text_ID.Multiline = true;
            this.text_ID.Name = "text_ID";
            this.text_ID.Size = new System.Drawing.Size(129, 35);
            this.text_ID.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(250, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name : ";
            // 
            // text_Name
            // 
            this.text_Name.Location = new System.Drawing.Point(329, 123);
            this.text_Name.Multiline = true;
            this.text_Name.Name = "text_Name";
            this.text_Name.Size = new System.Drawing.Size(261, 35);
            this.text_Name.TabIndex = 7;
            // 
            // text_Email
            // 
            this.text_Email.Location = new System.Drawing.Point(329, 175);
            this.text_Email.Multiline = true;
            this.text_Email.Name = "text_Email";
            this.text_Email.Size = new System.Drawing.Size(369, 35);
            this.text_Email.TabIndex = 8;
            // 
            // text_Phone
            // 
            this.text_Phone.Location = new System.Drawing.Point(329, 223);
            this.text_Phone.Multiline = true;
            this.text_Phone.Name = "text_Phone";
            this.text_Phone.Size = new System.Drawing.Size(261, 39);
            this.text_Phone.TabIndex = 9;
            // 
            // text_Grade
            // 
            this.text_Grade.Location = new System.Drawing.Point(329, 279);
            this.text_Grade.Multiline = true;
            this.text_Grade.Name = "text_Grade";
            this.text_Grade.Size = new System.Drawing.Size(172, 35);
            this.text_Grade.TabIndex = 10;
            // 
            // text_Gender
            // 
            this.text_Gender.Location = new System.Drawing.Point(329, 72);
            this.text_Gender.Multiline = true;
            this.text_Gender.Name = "text_Gender";
            this.text_Gender.Size = new System.Drawing.Size(201, 35);
            this.text_Gender.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Student_Management.Properties.Resources.Icon_Anonmous;
            this.pictureBox1.Location = new System.Drawing.Point(6, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 339);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrintCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(715, 379);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmPrintCard";
            this.Text = "Print Id Card";
            this.Load += new System.EventHandler(this.frmPrintCard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_Gender;
        private System.Windows.Forms.TextBox text_Grade;
        private System.Windows.Forms.TextBox text_Phone;
        private System.Windows.Forms.TextBox text_Email;
        private System.Windows.Forms.TextBox text_Name;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}