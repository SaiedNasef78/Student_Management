using Student_Management.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           

        }



        private void RefreshItem()
        {



          

            MST_ID.Clear();
            text_NameInfo.Clear();
            text_EmailInfo.Clear();
            MST_PhoneInfo.Clear();
            CB_Grade.SelectedIndex = -1;


            rb_Male.Checked = false;
            rb_Female.Checked = false;

            MST_ID.Focus();


        }

        private void AddDataToListview()
        {

            ListViewItem item = new ListViewItem(MST_ID.Text);


            if (rb_Male.Checked)
            {
                item.ImageIndex = 1;


            }
            else
            {
                item.ImageIndex = 0;


            }
            item.SubItems.Add(text_NameInfo.Text.Trim());
            item.SubItems.Add(text_EmailInfo.Text.Trim());
            item.SubItems.Add(MST_PhoneInfo.Text.Trim());
            item.SubItems.Add(CB_Grade.Text);
            if (rb_Male.Checked)
            {

                item.SubItems.Add(rb_Male.Text);

            }
            else
            {

                item.SubItems.Add(rb_Female.Text);

            }

            listView1.Items.Add(item);





        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MST_ID.Text) || string.IsNullOrEmpty(MST_PhoneInfo.Text) || string.IsNullOrEmpty(text_EmailInfo.Text) ||
                string.IsNullOrEmpty(text_NameInfo.Text) || string.IsNullOrEmpty(CB_Grade.Text))
                return;


            AddDataToListview();
            RefreshItem();



        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {

                if (!(MessageBox.Show("Are you sure? ", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes))
                {
                    return;


                }

                listView1.SelectedItems[0].Remove();
            }
            else
            {
                MessageBox.Show("Please Select a student from the list first");
            }
        }

        private void AddlistViewitemToIdCard()
        {



            if (listView1.Items.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];

                textID.Text = item.Text;

                text_Name.Text = item.SubItems[1].Text;
                text_Email.Text = item.SubItems[2].Text;
                text_Phone.Text = item.SubItems[3].Text;
                text_Gender.Text = item.SubItems[4].Text;
                text_Grade.Text = item.SubItems[5].Text;


                if (item.ImageIndex == 0)

                    pictureBox1.Image = Resources.Icon_Gir;

                else
                    pictureBox1.Image = Resources.Boy;


            }





        }
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        
       {
               
            AddlistViewitemToIdCard();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() => MST_ID.Focus()));

        }

        private void btn_Print_Click(object sender, EventArgs e)
        {

            //initialization to cnstructor frmPrintIDCard
            frmPrintCard frm = new frmPrintCard(textID.Text, text_Name.Text, text_Email.Text, text_Phone.Text, text_Gender.Text, text_Grade.Text,pictureBox1);
            frm.Show();

        }
        private void RefreshIDCard()
        {


            textID.Clear();


              text_Name.Clear();
              text_Email.Clear();
            text_Phone.Clear();
            text_Gender.Clear();
            text_Grade.Clear();
            pictureBox1.Image = Resources.Icon_Anonmous;





        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            RefreshIDCard();

        }

        private void MST_ID_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}