namespace Project_Store
{
    partial class TeacherForm
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
            this.addNewButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.categoryIdComboBox = new System.Windows.Forms.ComboBox();
            this.subjectCategoryVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Major_Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_Per_Hour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectIndexVMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.subjectVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.subjectCategoryVMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectIndexVMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectIndexVMBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectVMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewButton
            // 
            this.addNewButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addNewButton.Font = new System.Drawing.Font("Old English Text MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.addNewButton.Location = new System.Drawing.Point(584, 38);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(75, 34);
            this.addNewButton.TabIndex = 8;
            this.addNewButton.Text = "Add";
            this.addNewButton.UseVisualStyleBackColor = false;
            this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click_1);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.searchButton.Font = new System.Drawing.Font("Old English Text MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.searchButton.Location = new System.Drawing.Point(181, 38);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(74, 34);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click_1);
            // 
            // categoryIdComboBox
            // 
            this.categoryIdComboBox.DataSource = this.subjectCategoryVMBindingSource;
            this.categoryIdComboBox.DisplayMember = "CategoryName";
            this.categoryIdComboBox.FormattingEnabled = true;
            this.categoryIdComboBox.Location = new System.Drawing.Point(25, 48);
            this.categoryIdComboBox.Name = "categoryIdComboBox";
            this.categoryIdComboBox.Size = new System.Drawing.Size(150, 20);
            this.categoryIdComboBox.TabIndex = 6;
            this.categoryIdComboBox.ValueMember = "Id";
            this.categoryIdComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryIdComboBox_SelectedIndexChanged);
            // 
            // subjectCategoryVMBindingSource
            // 
            this.subjectCategoryVMBindingSource.DataSource = typeof(Project_Store.models.ViewModels.SubjectCategoryVM);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.CategoryName,
            this.Major_Subject,
            this.Price_Per_Hour});
            this.dataGridView1.DataSource = this.subjectIndexVMBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(634, 246);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "CategoryName";
            this.CategoryName.HeaderText = "Category Subject";
            this.CategoryName.MinimumWidth = 8;
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            this.CategoryName.Width = 150;
            // 
            // Major_Subject
            // 
            this.Major_Subject.DataPropertyName = "Major_Subject";
            this.Major_Subject.HeaderText = "Major Subject";
            this.Major_Subject.MinimumWidth = 8;
            this.Major_Subject.Name = "Major_Subject";
            this.Major_Subject.ReadOnly = true;
            this.Major_Subject.Width = 150;
            // 
            // Price_Per_Hour
            // 
            this.Price_Per_Hour.DataPropertyName = "Price_Per_Hour";
            this.Price_Per_Hour.HeaderText = "Price Per Hour";
            this.Price_Per_Hour.MinimumWidth = 8;
            this.Price_Per_Hour.Name = "Price_Per_Hour";
            this.Price_Per_Hour.ReadOnly = true;
            this.Price_Per_Hour.Width = 150;
            // 
            // subjectIndexVMBindingSource
            // 
            this.subjectIndexVMBindingSource.DataSource = typeof(Project_Store.models.ViewModels.SubjectIndexVM);
            // 
            // subjectIndexVMBindingSource1
            // 
            this.subjectIndexVMBindingSource1.DataSource = typeof(Project_Store.models.ViewModels.SubjectIndexVM);
            // 
            // subjectVMBindingSource
            // 
            this.subjectVMBindingSource.DataSource = typeof(Project_Store.models.ViewModels.SubjectVM);
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(703, 399);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addNewButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.categoryIdComboBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "TeacherForm";
            this.Text = "SubjectCategory";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subjectCategoryVMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectIndexVMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectIndexVMBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectVMBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addNewButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox categoryIdComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource subjectIndexVMBindingSource;
        private System.Windows.Forms.BindingSource subjectVMBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn majorsubjuctDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn listPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource subjectIndexVMBindingSource1;
        private System.Windows.Forms.BindingSource subjectCategoryVMBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Major_Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_Per_Hour;
    }
}