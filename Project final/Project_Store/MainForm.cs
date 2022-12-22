using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Store
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.IsMdiContainer = true;
        }

        private void 編輯課程資訊ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new TeacherForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 科目類別分類ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new SubjectCategoryForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 使用者賬號ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new UsersForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 登出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("您確定要登出嗎?",
                "登出",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
