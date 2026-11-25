
using System;
using System.Linq;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace OyutniiBurtgel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cboDepartment.Items.AddRange(new string[]
            {
                "Мэдээллийн технологи",
                "Компьютерын ухаан",
                "Программ хангамж",
                "Байгалийн ухааны сургууль"
            });

            lstLanguage.Items.AddRange(new string[]
            {
                "Монгол", "Англи", "Орос",
                "Хятад", "Япон", "Солонгос"
            });

            clbSubjects.Items.AddRange(new string[]
            {
                "Программчлал",
                "Өгөгдлийн бүтэц",
                "Алгоритм",
                "Өгөгдлийн сан",
                "Сүлжээ"
            });

            tvDepartments.Nodes.Add("Мэдээллийн технологи");
            tvDepartments.Nodes[0].Nodes.Add("Компьютерын ухаан");
            tvDepartments.Nodes[0].Nodes.Add("Мэдээллийн технологи");
            tvDepartments.Nodes[0].Nodes.Add("Программ хангамж");

            tvDepartments.Nodes.Add("Байгалийн ухааны сургууль");
            tvDepartments.Nodes[1].Nodes.Add("Математик");
            tvDepartments.Nodes[1].Nodes.Add("Физик");

            dgvStudents.Columns.Add("Code", "Овог нэр");
            dgvStudents.Columns.Add("Phone", "Утас");
            dgvStudents.Columns.Add("Age", "Нас");

            dgvStudents.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            rdoDay.Checked = true;
            nudAge.Value = 21;
            dtpBirth.Value = new DateTime(2005, 1, 28);

            lblCount.Text = "Нийт: 0";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCode.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Код болон утсаа оруулна уу!");
                return;
            }

            string code = txtCode.Text.Trim();
            string phone = txtPhone.Text.Trim();
            int age = (int)nudAge.Value;

            string study = rdoDay.Checked
                ? "Өдрийн"
                : "Оройн";

            string department = cboDepartment.Text;
            string language = lstLanguage.SelectedItem?.ToString()
                ?? "Сонгоогүй";

            string scholarship = chkScholarship.Checked
                ? "Тийм"
                : "Үгүй";

            string subjects = string.Join(", ",
                clbSubjects.CheckedItems.Cast<object>());

            dgvStudents.Rows.Add(code, phone, age);

            lblCount.Text = "Нийт: " + dgvStudents.Rows.Count;

            rtbInfo.Text =
                "ОЮУТНЫ БҮРТГЭЛ\r\n" +
                "-----------------------------\r\n" +
                "Код: " + code + "\r\n" +
                "Утас: " + phone + "\r\n" +
                "Нас: " + age + "\r\n" +
                "Төрсөн өдөр: " +
                dtpBirth.Value.ToString("yyyy-MM-dd") + "\r\n" +
                "Сургалт: " + study + "\r\n" +
                "Тэнхим: " + department + "\r\n" +
                "Тэтгэлэг: " + scholarship + "\r\n" +
                "Хичээл: " + subjects + "\r\n" +
                "Хэл: " + language;

            MessageBox.Show("Оюутны бүртгэл амжилттай!");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCode.Clear();
            txtPhone.Clear();
            rtbInfo.Clear();

            chkScholarship.Checked = false;
            rdoDay.Checked = true;
            nudAge.Value = 18;

            cboDepartment.SelectedIndex = -1;
            lstLanguage.SelectedIndex = -1;

            for (int i = 0; i < clbSubjects.Items.Count; i++)
                clbSubjects.SetItemChecked(i, false);

            dtpBirth.Value = DateTime.Today;
        }
    }
}
