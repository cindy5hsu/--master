using ISpan.Utility;
using Project_Store.models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Store
{
    public partial class TeacherForm : Form
    {
        private SubjectIndexVM[] products = null;
        public TeacherForm()
        {
            InitializeComponent();
            InitForm();

            // 顯示商品記錄
            DisplayProducts();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
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
                .Prepend(new SubjectCategoryVM { Id = 0, CategoryName = String.Empty })
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


        private void DisplayProducts()
        {
            string sql = @"SELECT P.Id, P.Major_Subject, P.Price_Per_Hour, C.CategoryName
FROM Data_Teacher P
INNER JOIN SubjectCategoryName C ON P.CategoryId = C.Id";

            #region 加入 where 
            SqlParameter[] parameters = new SqlParameter[] { };

            //取得篩選值
            int categoryId = ((SubjectCategoryVM)categoryIdComboBox.SelectedItem).Id;

            if (categoryId > 0)
            {
                sql += " WHERE CategoryId=@CategoryId";
                parameters = new SqlParameterBuilder()
                    .AddInt("CategoryId", categoryId)
                    .Build();
            }
            #endregion

            // 加入排序子句
            sql += " ORDER BY C.DisplayOrder, P.Major_Subject";
            var dbHelper = new SqlDbHelper("default");
            // 存放在field裡, 稍後在 grid CellClick事件會需要再度用到它
            products = dbHelper.Select(sql, parameters)
                .AsEnumerable()
                .Select(row => ParseToIndexVM(row))
                .ToArray();
            
            BindData(products);


        }
        private void BindData(SubjectIndexVM[] data)
        {
            dataGridView1.DataSource = data;
        }

        private SubjectIndexVM ParseToIndexVM(DataRow row)
        {
            return new SubjectIndexVM
            {
                Id = row.Field<int>("Id"),
                CategoryName = row.Field<string>("CategoryName"),
                Major_Subject = row.Field<string>("Major_Subject"),
                Price_Per_Hour = row.Field<int>("Price_Per_Hour"),
            };
        }

     

        private void addNewButton_Click_1(object sender, EventArgs e)
        {
            var frm = new CrreatTeacherForm();
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                DisplayProducts();
            }
        }

        private void searchButton_Click_1(object sender, EventArgs e)
        {
            DisplayProducts();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndx = e.RowIndex;

            if (rowIndx < 0) return;

            SubjectIndexVM row = this.products[rowIndx]; // 使用者點到的那一筆記錄

            int id = row.Id; // 使用者點到的那一筆記錄的id值

            // 把 id 傳給編輯表單的建構函數
            var frm = new EditTeacher(id);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                DisplayProducts();
            }
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {

        }

        private void categoryIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
