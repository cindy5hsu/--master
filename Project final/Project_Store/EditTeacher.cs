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
    public partial class EditTeacher : Form
    {
        private int id;
        public EditTeacher(int id)
        {
            InitializeComponent();
          
            InitForm();
            this.id = id;
        }
        private void EditTeacher_Load_1(object sender, EventArgs e)
        {
            BindData(id);
        }

        public void BindData(int Id)
        {
            string sql = "SELECT * FROM Data_Teacher WHERE Id=@Id";
            var parameters = new SqlParameterBuilder()
                .AddInt("Id", id)
                .Build();

            DataTable data = new SqlDbHelper("default").Select(sql, parameters);

            if (data.Rows.Count == 0)
            {
                MessageBox.Show("抱歉, 找不到要編輯的記錄");
                this.DialogResult = DialogResult.Abort;

                this.Close();
                return;
            }
            // 將找到的一筆記錄由DataTable 轉換到 ProductVM
            SubjectVM model = ToSubjectVM(data.Rows[0]);

            // 再將 viewModel值繫結到各控制項
            categoryIdComboBox.SelectedItem = ((List<SubjectCategoryVM>)categoryIdComboBox.DataSource)
                                                .FirstOrDefault(x => x.Id == model.CategoryId);

            subjectNameTextBox.Text = model.Major_Subject;
            listPriceTextBox.Text = model.Price_Per_Hour.ToString();
        }
        private SubjectVM ToSubjectVM(DataRow row)
        {
            return new SubjectVM
            {
                Id = row.Field<int>("Id"),
                Major_Subject = row.Field<string>("Major_Subject"),
                CategoryId = row.Field<int>("CategoryId"),
                Price_Per_Hour = row.Field<int>("Price_Per_Hour")
            };
        }
        private void InitForm()
        {
            // 設定 categoryIdComboBox property
            categoryIdComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            var sql = "SELECT * FROM SubjectCategoryName ORDER BY Id";
            var dbHelper = new SqlDbHelper("default");

            List<SubjectCategoryVM> categories = dbHelper.Select(sql, null)
                .AsEnumerable()
                .Select(row => ToCategoryVM(row))
                //.Prepend(new ProductCategoryVM { Id = 0, CategoryName = String.Empty })
                .ToList();

            this.categoryIdComboBox.DataSource = categories;

        }

        private SubjectCategoryVM ToCategoryVM(DataRow row)
        {
            return new SubjectCategoryVM
            {
                Id = row.Field<int>("Id"),
                CategoryName = row.Field<string>("CategoryName"),
                DisplayOrder = row.Field<int>("DisplayOrder"),
                //Major_Subject = row.Field<string>("Major_Subject"),
                //CategoryId = row.Field<int>("CategoryId"),
                //Price_Per_Hour = row.Field<int>("Price_Per_Hour"),
            };
        }


        //private void updateButton_Click(object sender, EventArgs e)
        //{

        //}


        private void updateButton_Click_1(object sender, EventArgs e)
        {
            // 取得表單的各欄位值
            int categoryId = ((SubjectCategoryVM)this.categoryIdComboBox.SelectedItem).Id;
            string major_subject = subjectNameTextBox.Text;
            //int number_of_teacher = subjectNameTextBox.Text.Length;
            int price_per_hour = listPriceTextBox.Text.ToInt(-1); //如果没填牌價,傳回-1

            // 將它們繫結到ViewModel
            SubjectVM model = new SubjectVM
            {
                CategoryId = categoryId,
                Major_Subject = major_subject,
                //number_of_teacher = number_of_teacher,
                Price_Per_Hour = price_per_hour
            };

            //針對ViewModel進行欄位驗證
            string errorMsg = string.Empty;
            if (string.IsNullOrEmpty(model.Major_Subject)) errorMsg += "商品名稱必填\r\n";
            if (model.Price_Per_Hour < 0) errorMsg += "牌價必需輸入大於或等於零的整數\r\n";

            if (string.IsNullOrEmpty(errorMsg) == false)
            {
                //表示至少一欄有錯誤
                MessageBox.Show(errorMsg);
                return; // 不再向下執行
            }

            //update record
            string sql = @"UPDATE Data_Teacher
			SET CategoryId=@CategoryId, Major_Subject=@Major_Subject, Price_Per_Hour=@Price_Per_Hour
			WHERE Id=@Id";

            var parameters = new SqlParameterBuilder()
                .AddInt("CategoryId", model.CategoryId)
                .AddNVarchar("Major_Subject", 50, major_subject)
                .AddInt("Price_Per_Hour", price_per_hour)
                .AddInt("Id", this.id)
                .Build();

            new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

            this.DialogResult = DialogResult.OK;
        }

        private void deleteButton_Click_1(object sender, EventArgs e)
        {
            if (MessageBox
           .Show("您真的要刪除嗎?",
                   "刪除記錄",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            string sql = @"DELETE FROM Data_Teacher WHERE Id=@Id";

            var parameters = new SqlParameterBuilder()
                .AddInt("Id", this.id)
                .Build();

            new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

            this.DialogResult = DialogResult.OK;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

        }
    }
}
