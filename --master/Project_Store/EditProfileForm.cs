using ISpan.Utility;
using Project_Store.models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Store
{
    public partial class EditProfileForm : Form
    {
        private int id;
        public EditProfileForm(int id)
        {
            InitializeComponent();
            this.id = id;
            InitForm();
        }

        private void EditProfileForm_Load(object sender, EventArgs e)
        {
            BindData(id);
        }
        public void BindData(int id)
        {
            string sql = "SELECT * FROM Employee WHERE Id=@Id";
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
            CategoryComboBox.SelectedItem = ((List<SubjectCategoryVM>)CategoryComboBox.DataSource)
                                                .FirstOrDefault(x => x.Id == model.CategoryId);

            NameTextBox.Text = model.FName;
            birthdate.Text = model.DateOfBirth.ToString();
            MajorTextBox.Text = model.Depertment;
            PhoneTextBox.Text = model.PhoneNo;
            mailTextBox.Text = model.gMail;
            
        }
        private SubjectVM ToSubjectVM(DataRow row)
        {
            return new SubjectVM
            {
                Id = row.Field<int>("Id"),
                FName = row.Field<string>("FName"),
                DateOfBirth = row.Field<DateTime>("DateOfBirth"),
                Gender = row.Field<string>("Gender"),
                gMail = row.Field<string>("gMail"),
                Depertment = row.Field<string>("Depertment"),
                PhoneNo = row.Field<string>("PhoneNo"),
                Major = row.Field<string>("Major"),
            };
        }
        private void InitForm()
        {
            // 設定 categoryIdComboBox property
            CategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            var sql = "SELECT * FROM SubjectCategoryName ORDER BY Id";
            var dbHelper = new SqlDbHelper("default");

            List<SubjectCategoryVM> categories = dbHelper.Select(sql, null)
                .AsEnumerable()
                .Select(row => ToCategoryVM(row))
                //.Prepend(new ProductCategoryVM { Id = 0, CategoryName = String.Empty })
                .ToList();

            this.CategoryComboBox.DataSource = categories;

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
        string photopath;
        byte[] binaryphoto;

        private void UPButton_Click_1(object sender, EventArgs e)
        {
            //string files = string.Empty;
            OpenFileDialog file = new OpenFileDialog();

            file.Filter = "jpg|*.jpg|Jpegs|*.Jpegs|png|*.png|GIf|*.Gif|Bitmaps |*.Bitmaps";
            file.Title = "Plase Select an Image";

            if (file.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(file.OpenFile());

                photopath = file.FileName;

                FileStream fs = new FileStream(photopath, FileMode.Open, FileAccess.Read);

                BinaryReader br = new BinaryReader(fs);
                binaryphoto = br.ReadBytes((int)fs.Length);
                fs.Close();

                textBox1.Text = file.SafeFileName;
            }
        }
       
        private void updateButton_Click_1(object sender, EventArgs e)
        {
            // 取得表單的各欄位值
            //int Id = ((SubjectCategoryVM)this.CategoryComboBox.SelectedItem).Id;
            string name = NameTextBox.Text;
            // string datefbirth= DOBComboBox.Text;
            string dateOfbirth = birthdate.Text;
            string gmail = mailTextBox.Text;
            string gender1;
            //int depertment = ((SubjectCategoryVM)this.CategoryComboBox.SelectedItem).Id;
           string depertment = CategoryComboBox.Text;
            string major = MajorTextBox.Text;
            string phoneNo = PhoneTextBox.Text;
            string image = textBox1.Text;
            if (radiobox1.Checked == true)
            {
                gender1 = "Male";

            }
            else
                gender1 = "Female";
            //int number_of_teacher = subjectNameTextBox.Text.Length;
            // int price_per_hour = listPriceTextBox.Text.ToInt(-1); //如果没填牌價,傳回-1

            // 將它們繫結到ViewModel
            SubjectVM model = new SubjectVM
            {
                Id = id,
                //Depertment = depertment,
                FName = name,
                gMail = gmail,
                Gender = gender1,
                DateOfBirth = Convert.ToDateTime(dateOfbirth),
                Major = major,
                Depertment = depertment,
                PhoneNo = phoneNo,
                Image = image,

            };

            //針對ViewModel進行欄位驗證
            //string errorMsg = string.Empty;
            //if (string.IsNullOrEmpty(model.Major_Subject)) errorMsg += "商品名稱必填\r\n";
            //if (model.Price_Per_Hour < 0) errorMsg += "牌價必需輸入大於或等於零的整數\r\n";

            //if (string.IsNullOrEmpty(errorMsg) == false)
            //{
            //    //表示至少一欄有錯誤
            //    MessageBox.Show(errorMsg);
            //    return; // 不再向下執行
            //}

            //update record
            string sql = @"UPDATE Employee
			SET   FName=@FName
      ,DateOfBirth=@DateOfBirth
      ,Gender=@Gender
      ,gMail=@gMail
      ,Depertment=@Depertment
      ,Major=@Major
      ,PhoneNo=@PhoneNo
      ,Image=@Image
			WHERE Id=@Id";

            var parameters = new SqlParameterBuilder()
                 .AddInt("Id", model.Id)
                .AddNVarchar("FName", 50, model.FName)
                .AddDateTime("DateOfBirth", model.DateOfBirth)
                .AddNVarchar("Gender", 50, model.Gender)
                .AddNVarchar("gMail", 50, model.gMail)
                .AddNVarchar("Depertment", 50, model.Depertment)
                .AddNVarchar("Major", 50, model.Major)
                .AddNVarchar("PhoneNo", 50, model.PhoneNo)
                .AddNVarchar("Image", 50, model.Image)
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

            string sql = @"DELETE FROM Employee WHERE Id=@Id";

            var parameters = new SqlParameterBuilder()
                .AddInt("Id", this.id)
                .Build();

            new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

            this.DialogResult = DialogResult.OK;
        }
     
    }
}
