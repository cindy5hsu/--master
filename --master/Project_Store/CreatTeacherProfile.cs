using ISpan.Utility;
using Project_Store.infra.Extensions;
using Project_Store.models.Service;
using Project_Store.models.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
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
           // BindData(id);
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
                DateOfBirth = row.Field<DateTime>("DateOfBirth"),
                Gender = row.Field<string>("Gender"),
                gMail = row.Field<string>("gMail"),
                Depertment = row.Field<string>("Depertment"),
                PhoneNo = row.Field<string>("PhoneNo"),
                Major = row.Field<string>("Major"),
            };
        }
        private SubjectCategoryVM ToCategoryVM(DataRow row)
        {
                return new SubjectCategoryVM
                {
                    Id = row.Field<int>("Id"),
                    CategoryName = row.Field<string>("CategoryName"),
                    DisplayOrder = row.Field<int>("DisplayOrder")
                    //Photo = row.Field<byte>("Photo")
                };
            
        }
        string photopath;
        byte[] binaryphoto;
        private void UPButton_Click(object sender, EventArgs e)
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

                textBox1.Text  = file.SafeFileName;
            }
        }

        private void AddNewButton_Click(object sender, EventArgs e)
        {
           // int id = RolltextBox.Text.ToInt(-1);
            // 取得表單的各欄位值
            string name = NameTextBox.Text;
            // string datefbirth= DOBComboBox.Text;
            string dateOfbirth = birthdate.Text;
            string gmail = mailTextBox.Text;
           string gender1 ;
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

            
            // 如果通過驗證,就新增記錄
            string sql = @"INSERT INTO Employee
                        (
      FName
      ,DateOfBirth
      ,Gender
      ,gMail
      ,Depertment
      ,Major
      ,PhoneNo
      ,Image)
                        VALUES
                       (
       @FName
      ,@DateOfBirth
      ,@Gender
      ,@gMail
      ,@Depertment
      ,@Major
      ,@PhoneNo
      ,@Image)";

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

            MessageBox.Show("記錄已新增");
            
        }
        
   
       

        //private void DwleteButton_Click(object sender, EventArgs e)
        //{
        //    if (MessageBox
        //  .Show("您真的要刪除嗎?",
        //          "刪除記錄",
        //          MessageBoxButtons.YesNo,
        //          MessageBoxIcon.Question) != DialogResult.Yes)
        //    {
        //        return;
        //    }

        //    string sql = @"DELETE FROM Data_Teacher WHERE Id=@Id";

        //    var parameters = new SqlParameterBuilder()
        //        .AddInt("Id", this.id)
        //        .Build();

        //    new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

        //    this.DialogResult = DialogResult.OK;
        //}
        //public void BindData(int Id)
        //{
        //    // 再將 viewModel值繫結到各控制項
        //  //  int id = RolltextBox.Text.ToInt(-1);
        //    // 取得表單的各欄位值
        //    string name = NameTextBox.Text;
        //    string gmail = mailTextBox.Text;
        //    string depertment = CategoryComboBox.Text;
        //    string major = MajorTextBox.Text;
        //    string phoneNo = PhoneTextBox.Text;
        //}

       

      
    }
}
