namespace Bai_4._6
{
    partial class FormStudent
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            btnExportCsv = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            btnChooseAvatar = new Button();
            picAvatar = new PictureBox();
            cboGender = new ComboBox();
            lblGender = new Label();
            txtAge = new TextBox();
            lblAge = new Label();
            txtFullName = new TextBox();
            lblFullName = new Label();
            txtStudentId = new TextBox();
            lblStudentId = new Label();
            dgvStudents = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnExportCsv);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(btnChooseAvatar);
            groupBox1.Controls.Add(picAvatar);
            groupBox1.Controls.Add(cboGender);
            groupBox1.Controls.Add(lblGender);
            groupBox1.Controls.Add(txtAge);
            groupBox1.Controls.Add(lblAge);
            groupBox1.Controls.Add(txtFullName);
            groupBox1.Controls.Add(lblFullName);
            groupBox1.Controls.Add(txtStudentId);
            groupBox1.Controls.Add(lblStudentId);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(478, 450);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sinh viên";
            // 
            // btnExportCsv
            // 
            btnExportCsv.Location = new Point(242, 323);
            btnExportCsv.Name = "btnExportCsv";
            btnExportCsv.Size = new Size(94, 29);
            btnExportCsv.TabIndex = 13;
            btnExportCsv.Text = "Xuất file CSV";
            btnExportCsv.UseVisualStyleBackColor = true;
            btnExportCsv.Click += btnExportCsv_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(97, 323);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(242, 252);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(97, 252);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnChooseAvatar
            // 
            btnChooseAvatar.Location = new Point(43, 199);
            btnChooseAvatar.Name = "btnChooseAvatar";
            btnChooseAvatar.Size = new Size(94, 29);
            btnChooseAvatar.TabIndex = 9;
            btnChooseAvatar.Text = "Chọn ảnh";
            btnChooseAvatar.UseVisualStyleBackColor = true;
            btnChooseAvatar.Click += btnChooseAvatar_Click;
            // 
            // picAvatar
            // 
            picAvatar.Location = new Point(21, 26);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(150, 167);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 8;
            picAvatar.TabStop = false;
            // 
            // cboGender
            // 
            cboGender.FormattingEnabled = true;
            cboGender.Location = new Point(263, 153);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(186, 28);
            cboGender.TabIndex = 7;
            cboGender.SelectedIndexChanged += cboGender_SelectedIndexChanged;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(183, 156);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(65, 20);
            lblGender.TabIndex = 6;
            lblGender.Text = "Giới tính";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(263, 109);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(186, 27);
            txtAge.TabIndex = 5;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(186, 109);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(38, 20);
            lblAge.TabIndex = 4;
            lblAge.Text = "Tuổi";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(263, 63);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(186, 27);
            txtFullName.TabIndex = 3;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(183, 66);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(54, 20);
            lblFullName.TabIndex = 2;
            lblFullName.Text = "Họ tên";
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(263, 23);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(186, 27);
            txtStudentId.TabIndex = 1;
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Location = new Point(186, 23);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(51, 20);
            lblStudentId.TabIndex = 0;
            lblStudentId.Text = "Mã SV";
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Dock = DockStyle.Right;
            dgvStudents.Location = new Point(484, 0);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.Size = new Size(675, 450);
            dgvStudents.TabIndex = 1;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 450);
            Controls.Add(dgvStudents);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnChooseAvatar;
        private PictureBox picAvatar;
        private ComboBox cboGender;
        private Label lblGender;
        private TextBox txtAge;
        private Label lblAge;
        private TextBox txtFullName;
        private Label lblFullName;
        private TextBox txtStudentId;
        private Label lblStudentId;
        private Button btnExportCsv;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private DataGridView dgvStudents;
        private ErrorProvider errorProvider1;
    }
}
