using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeBankAccount
{
    public partial class Form1 : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbUserName.Text) || 
                string.IsNullOrEmpty(tbPassword.Text) ||
                string.IsNullOrEmpty(tbAccountName.Text) ||
                string.IsNullOrEmpty(tbInstitutionNumber.Text) ||
                string.IsNullOrEmpty(tbTransitNumber.Text))
            {
                MessageBox.Show("Nhập đủ thông tin vào đã");
            }

            //Generate random bank account number
        }

        
    }
}
