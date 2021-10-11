using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AemtliPlan
{
    public partial class AemltliGenerator : Form
    {
        MemberDialog memberDialog = new MemberDialog();
        TaskDialog taskDialog = new TaskDialog();

        public AemltliGenerator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonMembers_Click(object sender, EventArgs e)
        {
            memberDialog.ShowDialog();
        }

        private void btnMangageTasks_Click(object sender, EventArgs e)
        {
            taskDialog.ShowDialog();
        }
    }
}
