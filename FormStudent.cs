using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Forms;
namespace Bai_4._6
{
    public partial class FormStudent : Form
    {
        BindingList<Student> students = new BindingList<Student>();
        BindingSource source = new BindingSource();
        public FormStudent()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboGender.Items.Add("Nam");
            cboGender.Items.Add("Nữ");
            cboGender.SelectedIndex = 0;

            source.DataSource = students;
            dgvStudents.DataSource = source;

            txtStudentId.DataBindings.Add(
                "Text", source, "StudentId",
                true, DataSourceUpdateMode.OnPropertyChanged);

            txtFullName.DataBindings.Add(
                "Text", source, "FullName",
                true, DataSourceUpdateMode.OnPropertyChanged);

            txtAge.DataBindings.Add(
                "Text", source, "Age",
                true, DataSourceUpdateMode.OnPropertyChanged);

            cboGender.DataBindings.Add(
                "Text", source, "Gender",
                true, DataSourceUpdateMode.OnPropertyChanged);

            picAvatar.DataBindings.Add(
                "ImageLocation", source, "AvatarPath",
                true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            int tuoi;
            bool loi = false;

            if (txtStudentId.Text.Trim() == "")
            {
                errorProvider1.SetError(txtStudentId, "Vui lòng nhập mã sinh viên!");
                loi = true;
            }
            else
            {
                foreach (Student sv in students)
                {
                    if (sv.StudentId == txtStudentId.Text.Trim())
                    {
                        errorProvider1.SetError(txtStudentId, "Mã sinh viên đã tồn tại!");
                        loi = true;
                        break;
                    }
                }
            }

            if (txtFullName.Text.Trim() == "")
            {
                errorProvider1.SetError(txtFullName, "Vui lòng nhập họ tên!");
                loi = true;
            }

            if (!int.TryParse(txtAge.Text, out tuoi) || tuoi < 1 || tuoi > 100)
            {
                errorProvider1.SetError(txtAge, "Tuổi phải từ 1 đến 100!");
                loi = true;
            }

            if (cboGender.Text == "")
            {
                errorProvider1.SetError(cboGender, "Vui lòng chọn giới tính!");
                loi = true;
            }

            if (loi)
                return;

            Student svMoi = new Student();

            svMoi.StudentId = txtStudentId.Text.Trim();
            svMoi.FullName = txtFullName.Text.Trim();
            svMoi.Age = tuoi;
            svMoi.Gender = cboGender.Text;
            svMoi.AvatarPath = "";

            students.Add(svMoi);
            source.Position = students.Count - 1;

            MessageBox.Show("Thêm sinh viên thành công!");
            if (this.MdiParent is FormMain main)
            {
                main.CapNhatTrangThai("Thêm sinh viên thành công");
            }
        }

        private void btnChooseAvatar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "File ảnh|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (source.Current == null)
                    {
                        MessageBox.Show("Hãy thêm hoặc chọn sinh viên trước!");
                        return;
                    }

                    Student sv = (Student)source.Current;
                    sv.AvatarPath = ofd.FileName;

                    picAvatar.ImageLocation = ofd.FileName;
                    source.ResetCurrentItem();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (source.Current == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!");
                return;
            }

            DialogResult kq = MessageBox.Show(
                "Bạn có chắc muốn xóa sinh viên này không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (kq == DialogResult.Yes)
            {
                source.RemoveCurrent();
                picAvatar.Image = null;
            }
            if (this.MdiParent is FormMain main)
            {
                main.CapNhatTrangThai("Xóa sinh viên thành công");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (source.Current == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần cập nhật!");
                return;
            }

            int tuoi;
            bool loi = false;

            if (txtStudentId.Text.Trim() == "")
            {
                errorProvider1.SetError(txtStudentId, "Không được để trống mã sinh viên!");
                loi = true;
            }

            if (txtFullName.Text.Trim() == "")
            {
                errorProvider1.SetError(txtFullName, "Không được để trống họ tên!");
                loi = true;
            }

            if (!int.TryParse(txtAge.Text, out tuoi) || tuoi < 1 || tuoi > 100)
            {
                errorProvider1.SetError(txtAge, "Tuổi phải từ 1 đến 100!");
                loi = true;
            }

            if (cboGender.Text == "")
            {
                errorProvider1.SetError(cboGender, "Vui lòng chọn giới tính!");
                loi = true;
            }

            if (loi)
                return;

            source.EndEdit();
            source.ResetCurrentItem();

            MessageBox.Show("Cập nhật thành công!");
        }

        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV files (*.csv)|*.csv";
                sfd.FileName = "DanhSachSinhVien.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(
                        sfd.FileName, false, new UTF8Encoding(true)))
                    {
                        sw.WriteLine("Mã SV,Họ tên,Tuổi,Giới tính,Đường dẫn ảnh");

                        foreach (Student sv in students)
                        {
                            string dong =
                                "\"" + (sv.StudentId ?? "").Replace("\"", "\"\"") + "\"," +
                                "\"" + (sv.FullName ?? "").Replace("\"", "\"\"") + "\"," +
                                sv.Age + "," +
                                "\"" + (sv.Gender ?? "").Replace("\"", "\"\"") + "\"," +
                                "\"" + (sv.AvatarPath ?? "").Replace("\"", "\"\"") + "\"";

                            sw.WriteLine(dong);
                        }
                    }

                    MessageBox.Show("Xuất CSV thành công!");
                }
            }
        }
        private void txtStudentId_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtStudentId, "");
        }
        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtFullName, "");
        }
        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtAge, "");
        }

        private void cboGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(cboGender, "");
        }
    }
}
