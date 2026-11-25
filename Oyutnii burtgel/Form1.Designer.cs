
namespace OyutniiBurtgel
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.CheckBox chkScholarship;
        private System.Windows.Forms.RadioButton rdoDay;
        private System.Windows.Forms.RadioButton rdoNight;
        private System.Windows.Forms.CheckedListBox clbSubjects;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.ListBox lstLanguage;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.TreeView tvDepartments;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RichTextBox rtbInfo;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.PictureBox picStudent;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtCode = new TextBox();
            txtPhone = new TextBox();
            chkScholarship = new CheckBox();
            rdoDay = new RadioButton();
            rdoNight = new RadioButton();
            clbSubjects = new CheckedListBox();
            nudAge = new NumericUpDown();
            cboDepartment = new ComboBox();
            lstLanguage = new ListBox();
            dgvStudents = new DataGridView();
            tvDepartments = new TreeView();
            dtpBirth = new DateTimePicker();
            btnRegister = new Button();
            btnClear = new Button();
            rtbInfo = new RichTextBox();
            lblCount = new Label();
            picStudent = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)nudAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStudent).BeginInit();
            SuspendLayout();
            // 
            // txtCode
            // 
            txtCode.Location = new Point(25, 25);
            txtCode.Name = "txtCode";
            txtCode.PlaceholderText = "Оюутны код";
            txtCode.Size = new Size(230, 35);
            txtCode.TabIndex = 0;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(25, 425);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Утасны дугаар";
            txtPhone.Size = new Size(230, 35);
            txtPhone.TabIndex = 7;
            // 
            // chkScholarship
            // 
            chkScholarship.Location = new Point(25, 70);
            chkScholarship.Name = "chkScholarship";
            chkScholarship.Size = new Size(180, 30);
            chkScholarship.TabIndex = 1;
            chkScholarship.Text = "Тэтгэлэгтэй";
            // 
            // rdoDay
            // 
            rdoDay.Location = new Point(25, 110);
            rdoDay.Name = "rdoDay";
            rdoDay.Size = new Size(160, 30);
            rdoDay.TabIndex = 2;
            rdoDay.Text = "Өдрийн сургалт";
            // 
            // rdoNight
            // 
            rdoNight.Location = new Point(25, 145);
            rdoNight.Name = "rdoNight";
            rdoNight.Size = new Size(160, 30);
            rdoNight.TabIndex = 3;
            rdoNight.Text = "Оройн сургалт";
            // 
            // clbSubjects
            // 
            clbSubjects.CheckOnClick = true;
            clbSubjects.Location = new Point(25, 190);
            clbSubjects.Name = "clbSubjects";
            clbSubjects.Size = new Size(230, 100);
            clbSubjects.TabIndex = 4;
            // 
            // nudAge
            // 
            nudAge.Location = new Point(25, 335);
            nudAge.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAge.Name = "nudAge";
            nudAge.Size = new Size(230, 35);
            nudAge.TabIndex = 5;
            nudAge.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cboDepartment
            // 
            cboDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDepartment.Location = new Point(25, 380);
            cboDepartment.Name = "cboDepartment";
            cboDepartment.Size = new Size(230, 38);
            cboDepartment.TabIndex = 6;
            // 
            // lstLanguage
            // 
            lstLanguage.ItemHeight = 30;
            lstLanguage.Location = new Point(290, 25);
            lstLanguage.Name = "lstLanguage";
            lstLanguage.Size = new Size(180, 124);
            lstLanguage.TabIndex = 9;
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.ColumnHeadersHeight = 40;
            dgvStudents.Location = new Point(500, 25);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.RowHeadersWidth = 72;
            dgvStudents.Size = new Size(520, 150);
            dgvStudents.TabIndex = 11;
            // 
            // tvDepartments
            // 
            tvDepartments.Location = new Point(500, 190);
            tvDepartments.Name = "tvDepartments";
            tvDepartments.Size = new Size(520, 200);
            tvDepartments.TabIndex = 12;
            // 
            // dtpBirth
            // 
            dtpBirth.Format = DateTimePickerFormat.Short;
            dtpBirth.Location = new Point(25, 470);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(230, 35);
            dtpBirth.TabIndex = 8;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(25, 525);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(230, 45);
            btnRegister.TabIndex = 13;
            btnRegister.Text = "Бүртгэх";
            btnRegister.Click += btnRegister_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(25, 580);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(230, 40);
            btnClear.TabIndex = 14;
            btnClear.Text = "Цэвэрлэх";
            btnClear.Click += btnClear_Click;
            // 
            // rtbInfo
            // 
            rtbInfo.Font = new Font("Microsoft Sans Serif", 11F);
            rtbInfo.Location = new Point(290, 435);
            rtbInfo.Name = "rtbInfo";
            rtbInfo.ReadOnly = true;
            rtbInfo.Size = new Size(730, 180);
            rtbInfo.TabIndex = 16;
            rtbInfo.Text = "";
            // 
            // lblCount
            // 
            lblCount.Location = new Point(500, 395);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(200, 30);
            lblCount.TabIndex = 15;
            lblCount.Text = "Нийт: 0";
            // 
            // picStudent
            // 
            picStudent.BorderStyle = BorderStyle.FixedSingle;
            picStudent.Image = (Image)resources.GetObject("picStudent.Image");
            picStudent.Location = new Point(290, 190);
            picStudent.Name = "picStudent";
            picStudent.Size = new Size(180, 200);
            picStudent.SizeMode = PictureBoxSizeMode.Zoom;
            picStudent.TabIndex = 10;
            picStudent.TabStop = false;
            // 
            // Form1
            // 
            ClientSize = new Size(1050, 700);
            Controls.Add(txtCode);
            Controls.Add(chkScholarship);
            Controls.Add(rdoDay);
            Controls.Add(rdoNight);
            Controls.Add(clbSubjects);
            Controls.Add(nudAge);
            Controls.Add(cboDepartment);
            Controls.Add(txtPhone);
            Controls.Add(dtpBirth);
            Controls.Add(lstLanguage);
            Controls.Add(picStudent);
            Controls.Add(dgvStudents);
            Controls.Add(tvDepartments);
            Controls.Add(btnRegister);
            Controls.Add(btnClear);
            Controls.Add(lblCount);
            Controls.Add(rtbInfo);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Оюутны бүртгэлийн программ";
            ((System.ComponentModel.ISupportInitialize)nudAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
