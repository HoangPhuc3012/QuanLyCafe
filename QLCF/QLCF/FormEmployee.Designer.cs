﻿namespace QLCF
{
    partial class FormEmployee
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
            this.data_Emp = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayofbirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hometown = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iccardnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enddate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchWork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.dtp_dob = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.cbb_homeTown = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_phoneNumber = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_state = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.cbb_branch = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dtp_daystart = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.dtp_dayend = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cbb_position = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_idCard = new System.Windows.Forms.TextBox();
            this.txt_basicSalary = new System.Windows.Forms.NumericUpDown();
            this.txt_bonus = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.data_Emp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_basicSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_bonus)).BeginInit();
            this.SuspendLayout();
            // 
            // data_Emp
            // 
            this.data_Emp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_Emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Emp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Active,
            this.lastname,
            this.firstname,
            this.dayofbirth,
            this.address,
            this.hometown,
            this.position,
            this.phonenumber,
            this.iccardnumber,
            this.email,
            this.password,
            this.startdate,
            this.enddate,
            this.salary,
            this.bonus,
            this.branchWork});
            this.data_Emp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_Emp.Location = new System.Drawing.Point(0, 830);
            this.data_Emp.Name = "data_Emp";
            this.data_Emp.ReadOnly = true;
            this.data_Emp.RowTemplate.Height = 28;
            this.data_Emp.Size = new System.Drawing.Size(1116, 220);
            this.data_Emp.TabIndex = 2;
            this.data_Emp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Emp_CellClick);
            this.data_Emp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Emp_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Mã";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Active
            // 
            this.Active.DataPropertyName = "active";
            this.Active.HeaderText = "Kích hoạt";
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            this.Active.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Active.Visible = false;
            // 
            // lastname
            // 
            this.lastname.DataPropertyName = "lastname";
            this.lastname.HeaderText = "Họ";
            this.lastname.Name = "lastname";
            this.lastname.ReadOnly = true;
            // 
            // firstname
            // 
            this.firstname.DataPropertyName = "firstname";
            this.firstname.HeaderText = "Tên";
            this.firstname.Name = "firstname";
            this.firstname.ReadOnly = true;
            // 
            // dayofbirth
            // 
            this.dayofbirth.DataPropertyName = "dayofbirth";
            this.dayofbirth.HeaderText = "Ngày sinh";
            this.dayofbirth.Name = "dayofbirth";
            this.dayofbirth.ReadOnly = true;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Địa chỉ";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // hometown
            // 
            this.hometown.DataPropertyName = "hometown";
            this.hometown.HeaderText = "Quê quán";
            this.hometown.Name = "hometown";
            this.hometown.ReadOnly = true;
            // 
            // position
            // 
            this.position.DataPropertyName = "position";
            this.position.HeaderText = "Chức vụ";
            this.position.Name = "position";
            this.position.ReadOnly = true;
            // 
            // phonenumber
            // 
            this.phonenumber.DataPropertyName = "phonenumber";
            this.phonenumber.HeaderText = "Số điện thoại";
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.ReadOnly = true;
            // 
            // iccardnumber
            // 
            this.iccardnumber.DataPropertyName = "idcardnumber";
            this.iccardnumber.HeaderText = "CMND";
            this.iccardnumber.Name = "iccardnumber";
            this.iccardnumber.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "Mật khẩu";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Visible = false;
            // 
            // startdate
            // 
            this.startdate.DataPropertyName = "startdate";
            this.startdate.HeaderText = "Ngày vào làm";
            this.startdate.Name = "startdate";
            this.startdate.ReadOnly = true;
            // 
            // enddate
            // 
            this.enddate.DataPropertyName = "enddate";
            this.enddate.HeaderText = "Ngày nghỉ việc";
            this.enddate.Name = "enddate";
            this.enddate.ReadOnly = true;
            // 
            // salary
            // 
            this.salary.DataPropertyName = "salary";
            this.salary.HeaderText = "Lương cơ bản";
            this.salary.Name = "salary";
            this.salary.ReadOnly = true;
            // 
            // bonus
            // 
            this.bonus.DataPropertyName = "bonus";
            this.bonus.HeaderText = "Thưởng";
            this.bonus.Name = "bonus";
            this.bonus.ReadOnly = true;
            // 
            // branchWork
            // 
            this.branchWork.DataPropertyName = "branchWork";
            this.branchWork.HeaderText = "Chi nhánh";
            this.branchWork.Name = "branchWork";
            this.branchWork.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Họ:";
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(26, 86);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(205, 26);
            this.txt_lastName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên:";
            // 
            // txt_firstName
            // 
            this.txt_firstName.Location = new System.Drawing.Point(26, 153);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(205, 26);
            this.txt_firstName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ:";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(26, 287);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(205, 26);
            this.txt_address.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tìm kiếm:";
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(26, 422);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(326, 26);
            this.txt_search.TabIndex = 5;
            // 
            // dtp_dob
            // 
            this.dtp_dob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dob.Location = new System.Drawing.Point(26, 219);
            this.dtp_dob.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.dtp_dob.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtp_dob.Name = "dtp_dob";
            this.dtp_dob.Size = new System.Drawing.Size(200, 26);
            this.dtp_dob.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(336, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Quê quán:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(658, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 24);
            this.label8.TabIndex = 4;
            this.label8.Text = "Email:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(662, 86);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(205, 26);
            this.txt_email.TabIndex = 10;
            // 
            // cbb_homeTown
            // 
            this.cbb_homeTown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_homeTown.FormattingEnabled = true;
            this.cbb_homeTown.Items.AddRange(new object[] {
            "Thành phố Hà Nội",
            "Tỉnh Hà Giang",
            "Tỉnh Cao Bằng",
            "Tỉnh Bắc Kạn",
            "Tỉnh Tuyên Quang",
            "Tỉnh Lào Cai",
            "Tỉnh Điện Biên",
            "Tỉnh Lai Châu",
            "Tỉnh Sơn La",
            "Tỉnh Yên Bái",
            "Tỉnh Hoà Bình",
            "Tỉnh Thái Nguyên",
            "Tỉnh Lạng Sơn",
            "Tỉnh Quảng Ninh",
            "Tỉnh Bắc Giang",
            "Tỉnh Phú Thọ",
            "Tỉnh Vĩnh Phúc",
            "Tỉnh Bắc Ninh",
            "Tỉnh Hải Dương",
            "Thành phố Hải Phòng",
            "Tỉnh Hưng Yên",
            "Tỉnh Thái Bình",
            "Tỉnh Hà Nam",
            "Tỉnh Nam Định",
            "Tỉnh Ninh Bình",
            "Tỉnh Thanh Hóa",
            "Tỉnh Nghệ An",
            "Tỉnh Hà Tĩnh",
            "Tỉnh Quảng Bình",
            "Tỉnh Quảng Trị",
            "Tỉnh Thừa Thiên Huế",
            "Thành phố Đà Nẵng",
            "Tỉnh Quảng Nam",
            "Tỉnh Quảng Ngãi",
            "Tỉnh Bình Định",
            "Tỉnh Phú Yên",
            "Tỉnh Khánh Hòa",
            "Tỉnh Ninh Thuận",
            "Tỉnh Bình Thuận",
            "Tỉnh Kon Tum",
            "Tỉnh Gia Lai",
            "Tỉnh Đắk Lắk",
            "Tỉnh Đắk Nông",
            "Tỉnh Lâm Đồng",
            "Tỉnh Bình Phước",
            "Tỉnh Tây Ninh",
            "Tỉnh Bình Dương",
            "Tỉnh Đồng Nai",
            "Tỉnh Bà Rịa - Vũng Tàu",
            "Thành phố Hồ Chí Minh",
            "Tỉnh Long An",
            "Tỉnh Tiền Giang",
            "Tỉnh Bến Tre",
            "Tỉnh Trà Vinh",
            "Tỉnh Vĩnh Long",
            "Tỉnh Đồng Tháp",
            "Tỉnh An Giang",
            "Tỉnh Kiên Giang",
            "Thành phố Cần Thơ",
            "Tỉnh Hậu Giang",
            "Tỉnh Sóc Trăng",
            "Tỉnh Bạc Liêu",
            "Tỉnh Cà Mau"});
            this.cbb_homeTown.Location = new System.Drawing.Point(340, 84);
            this.cbb_homeTown.Name = "cbb_homeTown";
            this.cbb_homeTown.Size = new System.Drawing.Size(205, 28);
            this.cbb_homeTown.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(336, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 24);
            this.label9.TabIndex = 4;
            this.label9.Text = "Chức vụ:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(336, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 24);
            this.label10.TabIndex = 4;
            this.label10.Text = "Số điện thoại:";
            // 
            // txt_phoneNumber
            // 
            this.txt_phoneNumber.Location = new System.Drawing.Point(340, 219);
            this.txt_phoneNumber.Name = "txt_phoneNumber";
            this.txt_phoneNumber.Size = new System.Drawing.Size(205, 26);
            this.txt_phoneNumber.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(336, 260);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 24);
            this.label11.TabIndex = 4;
            this.label11.Text = "Chi nhánh:";
            // 
            // cb_state
            // 
            this.cb_state.AutoSize = true;
            this.cb_state.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_state.Location = new System.Drawing.Point(340, 359);
            this.cb_state.Name = "cb_state";
            this.cb_state.Size = new System.Drawing.Size(142, 23);
            this.cb_state.TabIndex = 9;
            this.cb_state.Text = "Đang làm việc";
            this.cb_state.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(336, 329);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 24);
            this.label12.TabIndex = 4;
            this.label12.Text = "Trạng thái";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(658, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 24);
            this.label13.TabIndex = 4;
            this.label13.Text = "Mật khẩu:";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(662, 153);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(205, 26);
            this.txt_password.TabIndex = 11;
            // 
            // cbb_branch
            // 
            this.cbb_branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_branch.FormattingEnabled = true;
            this.cbb_branch.Location = new System.Drawing.Point(340, 285);
            this.cbb_branch.Name = "cbb_branch";
            this.cbb_branch.Size = new System.Drawing.Size(205, 28);
            this.cbb_branch.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(658, 192);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 24);
            this.label15.TabIndex = 4;
            this.label15.Text = "Ngày vào làm:";
            // 
            // dtp_daystart
            // 
            this.dtp_daystart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_daystart.Location = new System.Drawing.Point(662, 219);
            this.dtp_daystart.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.dtp_daystart.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtp_daystart.Name = "dtp_daystart";
            this.dtp_daystart.Size = new System.Drawing.Size(205, 26);
            this.dtp_daystart.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(658, 258);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(130, 24);
            this.label16.TabIndex = 4;
            this.label16.Text = "Ngày nghỉ việc:";
            // 
            // dtp_dayend
            // 
            this.dtp_dayend.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dayend.Location = new System.Drawing.Point(662, 285);
            this.dtp_dayend.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.dtp_dayend.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtp_dayend.Name = "dtp_dayend";
            this.dtp_dayend.Size = new System.Drawing.Size(205, 26);
            this.dtp_dayend.TabIndex = 13;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(658, 320);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(122, 24);
            this.label17.TabIndex = 4;
            this.label17.Text = "Lương cơ bản:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(658, 395);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 24);
            this.label18.TabIndex = 4;
            this.label18.Text = "Thưởng:";
            // 
            // cbb_position
            // 
            this.cbb_position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_position.FormattingEnabled = true;
            this.cbb_position.Items.AddRange(new object[] {
            "Quản lý",
            "Nhân viên"});
            this.cbb_position.Location = new System.Drawing.Point(340, 151);
            this.cbb_position.Name = "cbb_position";
            this.cbb_position.Size = new System.Drawing.Size(205, 28);
            this.cbb_position.TabIndex = 6;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(158, 13);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(183, 43);
            this.btn_add.TabIndex = 16;
            this.btn_add.Text = "THÊM NHÂN VIÊN";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(347, 12);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(183, 43);
            this.btn_edit.TabIndex = 17;
            this.btn_edit.Text = "SỬA THÔNG TIN";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.DarkGray;
            this.btn_back.Location = new System.Drawing.Point(26, 18);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(126, 38);
            this.btn_back.TabIndex = 10;
            this.btn_back.Text = "QUAY LẠI";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Olive;
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(358, 416);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(144, 39);
            this.btn_search.TabIndex = 9;
            this.btn_search.Text = "TÌM";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(22, 329);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 24);
            this.label14.TabIndex = 4;
            this.label14.Text = "CMND:";
            // 
            // txt_idCard
            // 
            this.txt_idCard.Location = new System.Drawing.Point(26, 356);
            this.txt_idCard.Name = "txt_idCard";
            this.txt_idCard.Size = new System.Drawing.Size(205, 26);
            this.txt_idCard.TabIndex = 4;
            // 
            // txt_basicSalary
            // 
            this.txt_basicSalary.Location = new System.Drawing.Point(662, 355);
            this.txt_basicSalary.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txt_basicSalary.Name = "txt_basicSalary";
            this.txt_basicSalary.Size = new System.Drawing.Size(205, 26);
            this.txt_basicSalary.TabIndex = 18;
            // 
            // txt_bonus
            // 
            this.txt_bonus.Location = new System.Drawing.Point(662, 429);
            this.txt_bonus.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txt_bonus.Name = "txt_bonus";
            this.txt_bonus.Size = new System.Drawing.Size(205, 26);
            this.txt_bonus.TabIndex = 18;
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 1050);
            this.Controls.Add(this.txt_bonus);
            this.Controls.Add(this.txt_basicSalary);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cb_state);
            this.Controls.Add(this.cbb_branch);
            this.Controls.Add(this.cbb_position);
            this.Controls.Add(this.cbb_homeTown);
            this.Controls.Add(this.dtp_dayend);
            this.Controls.Add(this.dtp_daystart);
            this.Controls.Add(this.dtp_dob);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_idCard);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txt_phoneNumber);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_firstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_lastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.data_Emp);
            this.MaximizeBox = false;
            this.Name = "FormEmployee";
            this.Text = "QUẢN LÝ NHÂN VIÊN";
            this.Load += new System.EventHandler(this.FormEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_Emp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_basicSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_bonus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView data_Emp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.DateTimePicker dtp_dob;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.ComboBox cbb_homeTown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_phoneNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox cb_state;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.ComboBox cbb_branch;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtp_daystart;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtp_dayend;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbb_position;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_idCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Active;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayofbirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn hometown;
        private System.Windows.Forms.DataGridViewTextBoxColumn position;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn iccardnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn enddate;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonus;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchWork;
        private System.Windows.Forms.NumericUpDown txt_basicSalary;
        private System.Windows.Forms.NumericUpDown txt_bonus;
    }
}