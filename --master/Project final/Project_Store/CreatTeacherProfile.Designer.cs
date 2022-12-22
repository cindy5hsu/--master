namespace Project_Store
{
    partial class CreatTeacherProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatTeacherProfile));
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.birthdate = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UPButton = new System.Windows.Forms.Button();
            this.DwleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.AddNewButton = new System.Windows.Forms.Button();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.subjectCategoryVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.RolltextBox = new System.Windows.Forms.TextBox();
            this.FMradioButton2 = new System.Windows.Forms.RadioButton();
            this.MaeradioButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.MajorTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectCategoryVMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(540, 356);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(121, 22);
            this.radioButton3.TabIndex = 57;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // birthdate
            // 
            this.birthdate.Location = new System.Drawing.Point(257, 288);
            this.birthdate.Name = "birthdate";
            this.birthdate.Size = new System.Drawing.Size(165, 29);
            this.birthdate.TabIndex = 56;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(855, 170);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 252);
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // UPButton
            // 
            this.UPButton.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.UPButton.Location = new System.Drawing.Point(889, 476);
            this.UPButton.Margin = new System.Windows.Forms.Padding(4);
            this.UPButton.Name = "UPButton";
            this.UPButton.Size = new System.Drawing.Size(153, 54);
            this.UPButton.TabIndex = 54;
            this.UPButton.Text = "Upload Picture";
            this.UPButton.UseVisualStyleBackColor = true;
            this.UPButton.Click += new System.EventHandler(this.UPButton_Click);
            // 
            // DwleteButton
            // 
            this.DwleteButton.Location = new System.Drawing.Point(802, 642);
            this.DwleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.DwleteButton.Name = "DwleteButton";
            this.DwleteButton.Size = new System.Drawing.Size(87, 35);
            this.DwleteButton.TabIndex = 53;
            this.DwleteButton.Text = "Delete";
            this.DwleteButton.UseVisualStyleBackColor = true;
            this.DwleteButton.Click += new System.EventHandler(this.DwleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(662, 642);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(87, 35);
            this.UpdateButton.TabIndex = 52;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // AddNewButton
            // 
            this.AddNewButton.Location = new System.Drawing.Point(512, 642);
            this.AddNewButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddNewButton.Name = "AddNewButton";
            this.AddNewButton.Size = new System.Drawing.Size(87, 35);
            this.AddNewButton.TabIndex = 50;
            this.AddNewButton.Text = "Add New";
            this.AddNewButton.UseVisualStyleBackColor = true;
            this.AddNewButton.Click += new System.EventHandler(this.AddNewButton_Click);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.DataSource = this.subjectCategoryVMBindingSource;
            this.CategoryComboBox.DisplayMember = "CategoryName";
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(257, 416);
            this.CategoryComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(170, 26);
            this.CategoryComboBox.TabIndex = 48;
            this.CategoryComboBox.ValueMember = "Id";
            // 
            // subjectCategoryVMBindingSource
            // 
            this.subjectCategoryVMBindingSource.DataSource = typeof(Project_Store.models.ViewModels.SubjectCategoryVM);
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(257, 524);
            this.PhoneTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(170, 29);
            this.PhoneTextBox.TabIndex = 47;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(257, 229);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(170, 29);
            this.NameTextBox.TabIndex = 46;
            // 
            // RolltextBox
            // 
            this.RolltextBox.Location = new System.Drawing.Point(257, 170);
            this.RolltextBox.Margin = new System.Windows.Forms.Padding(4);
            this.RolltextBox.Name = "RolltextBox";
            this.RolltextBox.Size = new System.Drawing.Size(170, 29);
            this.RolltextBox.TabIndex = 45;
            // 
            // FMradioButton2
            // 
            this.FMradioButton2.AutoSize = true;
            this.FMradioButton2.Location = new System.Drawing.Point(381, 347);
            this.FMradioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.FMradioButton2.Name = "FMradioButton2";
            this.FMradioButton2.Size = new System.Drawing.Size(84, 22);
            this.FMradioButton2.TabIndex = 44;
            this.FMradioButton2.TabStop = true;
            this.FMradioButton2.Text = "Female";
            this.FMradioButton2.UseVisualStyleBackColor = true;
            // 
            // MaeradioButton
            // 
            this.MaeradioButton.AutoSize = true;
            this.MaeradioButton.Location = new System.Drawing.Point(257, 347);
            this.MaeradioButton.Margin = new System.Windows.Forms.Padding(4);
            this.MaeradioButton.Name = "MaeradioButton";
            this.MaeradioButton.Size = new System.Drawing.Size(69, 22);
            this.MaeradioButton.TabIndex = 43;
            this.MaeradioButton.TabStop = true;
            this.MaeradioButton.Text = "Male";
            this.MaeradioButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 347);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 42;
            this.label4.Text = "Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 529);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 18);
            this.label7.TabIndex = 38;
            this.label7.Text = "Phone No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 467);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 41;
            this.label6.Text = "Course";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 295);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 37;
            this.label3.Text = "Date of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 415);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 18);
            this.label5.TabIndex = 36;
            this.label5.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 233);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 40;
            this.label2.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(392, 60);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(380, 48);
            this.label9.TabIndex = 39;
            this.label9.Text = "Teacher_Profile";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 35;
            this.label1.Text = "Roll No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(125, 586);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 18);
            this.label8.TabIndex = 38;
            this.label8.Text = "GMail";
            // 
            // mailTextBox
            // 
            this.mailTextBox.Location = new System.Drawing.Point(257, 581);
            this.mailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(170, 29);
            this.mailTextBox.TabIndex = 47;
            // 
            // MajorTextBox
            // 
            this.MajorTextBox.Location = new System.Drawing.Point(257, 464);
            this.MajorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MajorTextBox.Name = "MajorTextBox";
            this.MajorTextBox.Size = new System.Drawing.Size(170, 29);
            this.MajorTextBox.TabIndex = 47;
            // 
            // CreatTeacherProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 831);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.birthdate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UPButton);
            this.Controls.Add(this.DwleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddNewButton);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.mailTextBox);
            this.Controls.Add(this.MajorTextBox);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.RolltextBox);
            this.Controls.Add(this.FMradioButton2);
            this.Controls.Add(this.MaeradioButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Name = "CreatTeacherProfile";
            this.Text = "CreatTeacherProfile";
            this.Click += new System.EventHandler(this.CreatTeacherProfile_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectCategoryVMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.DateTimePicker birthdate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button UPButton;
        private System.Windows.Forms.Button DwleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button AddNewButton;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox RolltextBox;
        private System.Windows.Forms.RadioButton FMradioButton2;
        private System.Windows.Forms.RadioButton MaeradioButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource subjectCategoryVMBindingSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.TextBox MajorTextBox;
    }
}