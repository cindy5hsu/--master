using ISpan.Utility;
using Project_Store.infra.Extensions;
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
    public partial class CrreatSubjectCategoryForm : Form
    {
        public CrreatSubjectCategoryForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string categoryName = categoryNameTextBox.Text;

            // ToInt可以將字串轉換成int,若轉換失敗,傳回預設值 -1
            int displayOrder = displayOrderTextBox.Text.ToInt(-1);

            string sql = @"INSERT INTO SubjectCategoryName
(CategoryName, DisplayOrder)
VALUES
(@CategoryName, @DisplayOrder)";

            var parameters = new SqlParameterBuilder()
                .AddNVarchar("CategoryName", 50, categoryName)
                .AddInt("DisplayOrder", displayOrder)
                .Build();

            new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

            // MessageBox.Show("記錄已新增");
            this.DialogResult = DialogResult.OK;
        }
    }
}
