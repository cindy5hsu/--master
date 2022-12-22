using ISpan.Utility;
using Project_Store.infra.Extensions;
using Project_Store.models.ViewModels;
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
    public partial class CrreatTeacherForm : Form
    {
        public CrreatTeacherForm()
        {
            InitializeComponent();

            InitForm();
        }

        private void InitForm()
        {
            // 設定 categoryIdComboBox property
            categoryIdComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            var sql = "SELECT * FROM SubjectCategoryName ORDER BY DisplayOrder";
            var dbHelper = new SqlDbHelper("default");

            List<SubjectCategoryVM> categories = dbHelper.Select(sql, null)
                .AsEnumerable()
                .Select(row => ToCategoryVM(row))
                // .Prepend(new ProductCategoryVM { Id = 0, CategoryName = String.Empty })
                .ToList();

            this.categoryIdComboBox.DataSource = categories;

        }

        private SubjectCategoryVM ToCategoryVM(DataRow row)
        {
            return new SubjectCategoryVM
            {
                Id = row.Field<int>("Id"),
                CategoryName = row.Field<string>("CategoryName"),
                DisplayOrder = row.Field<int>("DisplayOrder")
            };
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {

            // 取得表單的各欄位值
            int categoryId = ((SubjectCategoryVM)this.categoryIdComboBox.SelectedItem).Id;
            string major_subject = productNameTextBox.Text;
            int price_per_hour = listPriceTextBox.Text.ToInt(-1); //如果没填牌價,傳回-1

            // 將它們繫結到ViewModel
            SubjectVM model = new SubjectVM
            {
                CategoryId = categoryId,
                Major_Subject = major_subject,
                Price_Per_Hour = price_per_hour
            };

            // 針對ViewModel進行欄位驗證
            string errorMsg = string.Empty;
            if (string.IsNullOrEmpty(model.Major_Subject)) errorMsg += "商品名稱必填\r\n";
            if (model.ListPrice < 0) errorMsg += "牌價必需輸入大於或等於零的整數\r\n";

            if (string.IsNullOrEmpty(errorMsg) == false)
            {
                //表示至少一欄有錯誤
                MessageBox.Show(errorMsg);
                return; // 不再向下執行
            }


            // 如果通過驗證,就新增記錄
            string sql = @"INSERT INTO Data_Teacher
                        (CategoryId,Major_Subject, Price_Per_Hour)
                        VALUES
                       (@CategoryId,@Major_Subject, @Price_Per_Hour)";

            var parameters = new SqlParameterBuilder()
                .AddInt("CategoryId", model.CategoryId)
                .AddNVarchar("Major_Subject", 50, model.Major_Subject)
                .AddInt("Price_Per_Hour", model.Price_Per_Hour)
                .Build();

            new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

            this.DialogResult = DialogResult.OK;
        }

        private void PriceperhourTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void categoryIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
  
}
