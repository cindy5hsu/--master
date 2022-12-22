using ISpan.Utility;
using Project_Store.infra.Extensions;
using Project_Store.models.Service;
using Project_Store.models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_Store
{
    public partial class CreatTeacherProfile : Form
    {
        private int id;
        public CreatTeacherProfile()
        {
            InitializeComponent();

            InitForm();
            this.id = id;
        }
        private void CreatTeacherProfile_Click(object sender, EventArgs e)
        {
            BindData(id);
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

     
        private SubjectVM ToSubjectVM(DataRow row)
        {
            return new SubjectVM
            {
                Id = row.Field<int>("Id"),
                FName = row.Field<string>("FName"),
                DateOfBirth = row.Field<string>("DateOfBirth"),
                Gender = row.Field<string>("Gender"),
                gMail = row.Field<string>("gMail"),
                Depertment = row.Field<string>("Depertment"),
                PhoneNo = row.Field<string>("PhoneNo"),
                Major = row.Field<string>("Major"),
            };
        }
        private SubjectCategoryVM ToCategoryVM(DataRow row)
        {

            //try
            //{
                return new SubjectCategoryVM
                {
                    Id = row.Field<int>("Id"),
                    FName = row.Field<string>("FName"),
                    DateOfBirth = row.Field<string>("DateOfBirth"),
                    Gender = row.Field<string>("Gender"),
                    gMail = row.Field<string>("gMail"),
                    Depertment = row.Field<string>("Depertment"),
                    PhoneNo = row.Field<string>("PhoneNo"),
                    Major = row.Field<string>("Major"),
                    //Photo = row.Field<byte>("Photo")
                };
            //}
            //catch
            //{

            //    throw;
            //}

        }

        private void AddNewButton_Click(object sender, EventArgs e)
        {
            int id = RolltextBox.Text.ToInt(-1);
            // 取得表單的各欄位值
            string name = NameTextBox.Text;
            // string datefbirth= DOBComboBox.Text;
            string gmail = mailTextBox.Text;
            //int depertment = ((SubjectCategoryVM)this.CategoryComboBox.SelectedItem).Id;
            string depertment = CategoryComboBox.Text;
            string major = MajorTextBox.Text;
            string phoneNo = PhoneTextBox.Text;

            string sql = @"SELECT FROM test WHERE Name = ""+textBox1.Text + And AppointmentDate BETWEEN
               ** dateTimePicker1.Value. Date + " 'AND' " + dateTimePicker2.Value.Date + "'";

                //cmd is sql command
cmd.CommandText = "INSERT INTO person (birthdate) VALUES(" + dateTimePicker.Value.Date + ")";
            //con is sql connection
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            // byte photo = 
            // int price_per_hour = listPriceTextBox.Text.ToInt(-1); //如果没填牌價,傳回-1

            // 將它們繫結到ViewModel
            SubjectVM model = new SubjectVM
            {
                Id = id,
                //Depertment = depertment,
                FName = name,
                gMail = gmail,
                // DateOfBirth = datefbirth,
                Major = major,
                Depertment = depertment,
                PhoneNo = phoneNo,
                //Price_Per_Hour = price_per_hour
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
            string sql = @"INSERT INTO Employee
                        ([Id]
      ,[FName]
      ,DateOfBirth
      ,Gender
      ,gMail
      ,Depertment
      ,Major
      ,PhoneNo
      ,[Photo])
                        VALUES
                       (@[Id]
      ,@[FName]
      ,@DateOfBirth
      ,@Gender
      ,@gMail
      ,@Depertment
      ,@Major
      ,@PhoneNo
      ,@[Photo])";

            var parameters = new SqlParameterBuilder()

                // DateOfBirth
                //Gender
                //[Photo]
                .AddInt("Id", model.Id)
                .AddNVarchar("FName", 50, model.FName)
                .AddInt("gMail", model.Price_Per_Hour)
                 .AddInt("CategoryId", model.CategoryId)
                .AddNVarchar("gMail", 50, model.gMail)
                .AddNVarchar("Depertment", 50, model.Depertment)
                .AddNVarchar("Major", 50, model.Major)
                .AddNVarchar("PhoneNo", 50, model.PhoneNo)
                .AddInt("Price_Per_Hour", model.Price_Per_Hour)
                .Build();

            new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
            this.DialogResult = DialogResult.OK;
            File.Copy(AddNewButton.Text, Path.Combine(@"E:\Project-Website\File-Upload-Picture-Box\File-upload-Picture-BoxImages", 
                         Path.GetFileName(AddNewButton.Text)), true);
            
        }
        string photopath;
        byte[] binaryphoto;

        private void UPButton_Click(object sender, EventArgs e)
        {
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
            }
        }

        private void DwleteButton_Click(object sender, EventArgs e)
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
        public void BindData(int Id)
        {
            // 再將 viewModel值繫結到各控制項
            int id = RolltextBox.Text.ToInt(-1);
            // 取得表單的各欄位值
            string name = NameTextBox.Text;
            // string datefbirth= DOBComboBox.Text;
            string gmail = mailTextBox.Text;
            //int depertment = ((SubjectCategoryVM)this.CategoryComboBox.SelectedItem).Id;
            string depertment = CategoryComboBox.Text;
            string major = MajorTextBox.Text;
            string phoneNo = PhoneTextBox.Text;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
           
                // 取得表單的各欄位值
              

            int id = RolltextBox.Text.ToInt(-1);
            // 取得表單的各欄位值
            string name = NameTextBox.Text;
            // string datefbirth= DOBComboBox.Text;
            string gmail = mailTextBox.Text;
            //int depertment = ((SubjectCategoryVM)this.CategoryComboBox.SelectedItem).Id;
            string depertment = CategoryComboBox.Text;
            string major = MajorTextBox.Text;
            string phoneNo = PhoneTextBox.Text;
            // byte photo = 
            // int price_per_hour = listPriceTextBox.Text.ToInt(-1); //如果没填牌價,傳回-1


            // 將它們繫結到ViewModel
            UserVM model = new UserVM
                {
                  

                Id = this.id,
                //Depertment = depertment,
                FName = name,
                gMail = gmail,
                // DateOfBirth = datefbirth,
                Major = major,
                Depertment = depertment,
                PhoneNo = phoneNo,
                //Price_Per_Hour = price_per_hour
            };

                // 針對ViewModel進行欄位驗證
                Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
            {
                


                    { "Id" , RolltextBox},
                    {"FName", NameTextBox},
                {"gMail", mailTextBox},
                {"Depertment", CategoryComboBox},
            { "Major" , MajorTextBox},
                    {"PhoneNo", PhoneTextBox},

        };

                //bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
                //if (!isValid) return;

                // update record
                try
                {
                    new UserService().Update(model);

                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            private void deleteButton_Click(object sender, EventArgs e)
            {
                if (MessageBox
                    .Show("您真的要刪除嗎?",
                            "刪除記錄",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }

                new UserService().Delete(this.id);

                this.DialogResult = DialogResult.OK;
            
        }
    }
}
