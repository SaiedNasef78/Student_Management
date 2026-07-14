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
    public partial class 
        
        
        
        frmPrintCard : Form
    {
        public frmPrintCard(string _IDtext,string _Nametext,string _Emailtext,string _Phonetext,string _Gendertext,string _Gradetext,PictureBox picture)
        {
            InitializeComponent();
            text_ID.Text = _IDtext;
            text_Name.Text= _Nametext;
            text_Email.Text= _Emailtext;
            text_Phone.Text= _Phonetext;
            text_Gender.Text = _Gendertext;
            text_Grade.Text= _Gradetext;
            pictureBox1.Image = picture.Image;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmPrintCard_Load(object sender, EventArgs e)
        {

        }
    }
}
