using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EyalonFinalProject
{
    public partial class ViewPageForm : Form
    {
        DBConnection dbc = new DBConnection();
        int pageID = -1;
        public ViewPageForm(int pageID, string pageName, string pageData)
        {
            InitializeComponent();
            this.pageID = pageID;

        }

        private void ViewPageForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
