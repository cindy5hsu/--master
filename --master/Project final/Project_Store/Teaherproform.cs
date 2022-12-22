using ISpan.Utility;
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
   
    public partial class Teaherproform : Form
    {
        DataTable subjuct;
        public Teaherproform()
        {
            InitializeComponent();

            DisplaySubjectCatetories();
        }
        private void DisplaySubjectCatetories()
        {
            string sql = @"SELECT [Id]
      ,[FName]
      ,DateOfBirth
      ,Gender
      ,gMail
      ,Depertment
      ,Major
      ,PhoneNo
      ,[Photo] FROM Employee ORDER BY [Id]";

            subjuct = new SqlDbHelper("default").Select(sql, null);

            BindData(subjuct);
        }

        private void BindData(DataTable model)
        {
            dataGridView1.DataSource = model;
        }

        private void addnewButton_Click(object sender, EventArgs e)
        {
            var frm = new CrreatTeacherForm();
            // frm.Show();
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                DisplaySubjectCatetories();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndx = e.RowIndex;

            if (rowIndx < 0) return;

            DataRow row = this.subjuct.Rows[rowIndx]; // 使用者點到的那一筆記錄
            int id = row.Field<int>("Id"); // 使用者點到的那一筆記錄的id值

            // 把 id 傳給編輯表單的建構函數
            var frm = new EditSubjectCategoryForm(id);
            // frm.Show();
            // DialogResult result = frm.ShowDialog();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                DisplaySubjectCatetories();
            }
        }
    }
}
