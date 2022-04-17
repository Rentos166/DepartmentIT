
namespace DitProject
{
    partial class FormCTP
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
            this.Instit_Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelPosition = new System.Windows.Forms.Label();
            this.Dorm_Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.labelInstitAddress = new System.Windows.Forms.Label();
            this.labelDormAddress = new System.Windows.Forms.Label();
            this.listViewCTP = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MiddleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelMidName = new System.Windows.Forms.Label();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.labelFirName = new System.Windows.Forms.Label();
            this.labelLasName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelCTP = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.comboBoxInstit = new System.Windows.Forms.ComboBox();
            this.comboBoxDorm = new System.Windows.Forms.ComboBox();
            this.dateTimePickerCTP = new System.Windows.Forms.DateTimePicker();
            this.labelDOB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Instit_Address
            // 
            this.Instit_Address.Text = "Корпус института";
            this.Instit_Address.Width = 135;
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(59, 455);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(85, 17);
            this.labelPosition.TabIndex = 99;
            this.labelPosition.Text = "Должность:";
            // 
            // Dorm_Address
            // 
            this.Dorm_Address.Text = "Корпус общежития";
            this.Dorm_Address.Width = 137;
            // 
            // Position
            // 
            this.Position.Text = "Должность";
            this.Position.Width = 102;
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(153, 452);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(100, 22);
            this.textBoxPosition.TabIndex = 98;
            // 
            // labelInstitAddress
            // 
            this.labelInstitAddress.AutoSize = true;
            this.labelInstitAddress.Location = new System.Drawing.Point(17, 154);
            this.labelInstitAddress.Name = "labelInstitAddress";
            this.labelInstitAddress.Size = new System.Drawing.Size(130, 17);
            this.labelInstitAddress.TabIndex = 97;
            this.labelInstitAddress.Text = "Корпус института:";
            // 
            // labelDormAddress
            // 
            this.labelDormAddress.AutoSize = true;
            this.labelDormAddress.Location = new System.Drawing.Point(9, 183);
            this.labelDormAddress.Name = "labelDormAddress";
            this.labelDormAddress.Size = new System.Drawing.Size(138, 17);
            this.labelDormAddress.TabIndex = 95;
            this.labelDormAddress.Text = "Корпус общежития:";
            // 
            // listViewCTP
            // 
            this.listViewCTP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Instit_Address,
            this.Dorm_Address,
            this.LastName,
            this.FirstName,
            this.MiddleName,
            this.DOB,
            this.Phone,
            this.Email,
            this.Position});
            this.listViewCTP.FullRowSelect = true;
            this.listViewCTP.GridLines = true;
            this.listViewCTP.HideSelection = false;
            this.listViewCTP.Location = new System.Drawing.Point(326, 154);
            this.listViewCTP.Name = "listViewCTP";
            this.listViewCTP.Size = new System.Drawing.Size(951, 266);
            this.listViewCTP.TabIndex = 93;
            this.listViewCTP.UseCompatibleStateImageBehavior = false;
            this.listViewCTP.View = System.Windows.Forms.View.Details;
            this.listViewCTP.SelectedIndexChanged += new System.EventHandler(this.listViewCTP_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // LastName
            // 
            this.LastName.Text = "Фамилия";
            this.LastName.Width = 90;
            // 
            // FirstName
            // 
            this.FirstName.Text = "Имя";
            // 
            // MiddleName
            // 
            this.MiddleName.Text = "Отчество";
            this.MiddleName.Width = 82;
            // 
            // DOB
            // 
            this.DOB.Text = "Дата рождения";
            this.DOB.Width = 115;
            // 
            // Phone
            // 
            this.Phone.Text = "Телефон";
            this.Phone.Width = 84;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 80;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(565, 51);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 92;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(734, 427);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 91;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(637, 427);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(80, 23);
            this.buttonEdit.TabIndex = 90;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(529, 427);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 89;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(98, 420);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(46, 17);
            this.labelEmail.TabIndex = 88;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(153, 415);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 22);
            this.textBoxEmail.TabIndex = 87;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(75, 382);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(72, 17);
            this.labelPhone.TabIndex = 86;
            this.labelPhone.Text = "Телефон:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(153, 377);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(100, 22);
            this.textBoxPhone.TabIndex = 85;
            this.textBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhone_KeyPress);
            // 
            // labelMidName
            // 
            this.labelMidName.AutoSize = true;
            this.labelMidName.Location = new System.Drawing.Point(62, 288);
            this.labelMidName.Name = "labelMidName";
            this.labelMidName.Size = new System.Drawing.Size(75, 17);
            this.labelMidName.TabIndex = 84;
            this.labelMidName.Text = "Отчество:";
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(153, 285);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(100, 22);
            this.textBoxMiddleName.TabIndex = 83;
            // 
            // labelFirName
            // 
            this.labelFirName.AutoSize = true;
            this.labelFirName.Location = new System.Drawing.Point(101, 247);
            this.labelFirName.Name = "labelFirName";
            this.labelFirName.Size = new System.Drawing.Size(39, 17);
            this.labelFirName.TabIndex = 82;
            this.labelFirName.Text = "Имя:";
            // 
            // labelLasName
            // 
            this.labelLasName.AutoSize = true;
            this.labelLasName.Location = new System.Drawing.Point(70, 219);
            this.labelLasName.Name = "labelLasName";
            this.labelLasName.Size = new System.Drawing.Size(74, 17);
            this.labelLasName.TabIndex = 80;
            this.labelLasName.Text = "Фамилия:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(153, 216);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 22);
            this.textBoxLastName.TabIndex = 79;
            // 
            // labelCTP
            // 
            this.labelCTP.AutoSize = true;
            this.labelCTP.Location = new System.Drawing.Point(562, 122);
            this.labelCTP.Name = "labelCTP";
            this.labelCTP.Size = new System.Drawing.Size(120, 17);
            this.labelCTP.TabIndex = 78;
            this.labelCTP.Text = "Сотрудники ЦТП";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(153, 244);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 22);
            this.textBoxFirstName.TabIndex = 81;
            // 
            // comboBoxInstit
            // 
            this.comboBoxInstit.FormattingEnabled = true;
            this.comboBoxInstit.Location = new System.Drawing.Point(153, 154);
            this.comboBoxInstit.Name = "comboBoxInstit";
            this.comboBoxInstit.Size = new System.Drawing.Size(121, 24);
            this.comboBoxInstit.TabIndex = 100;
            // 
            // comboBoxDorm
            // 
            this.comboBoxDorm.FormattingEnabled = true;
            this.comboBoxDorm.Location = new System.Drawing.Point(153, 184);
            this.comboBoxDorm.Name = "comboBoxDorm";
            this.comboBoxDorm.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDorm.TabIndex = 101;
            // 
            // dateTimePickerCTP
            // 
            this.dateTimePickerCTP.Location = new System.Drawing.Point(153, 334);
            this.dateTimePickerCTP.Name = "dateTimePickerCTP";
            this.dateTimePickerCTP.Size = new System.Drawing.Size(167, 22);
            this.dateTimePickerCTP.TabIndex = 128;
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Location = new System.Drawing.Point(25, 339);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(115, 17);
            this.labelDOB.TabIndex = 127;
            this.labelDOB.Text = "Дата рождения:";
            // 
            // FormCTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 500);
            this.Controls.Add(this.dateTimePickerCTP);
            this.Controls.Add(this.labelDOB);
            this.Controls.Add(this.comboBoxDorm);
            this.Controls.Add(this.comboBoxInstit);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.textBoxPosition);
            this.Controls.Add(this.labelInstitAddress);
            this.Controls.Add(this.labelDormAddress);
            this.Controls.Add(this.listViewCTP);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelMidName);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.labelFirName);
            this.Controls.Add(this.labelLasName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelCTP);
            this.Controls.Add(this.textBoxFirstName);
            this.Name = "FormCTP";
            this.Text = "Сотрудники ЦТП";
            this.Load += new System.EventHandler(this.FormCTP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader Instit_Address;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.ColumnHeader Dorm_Address;
        private System.Windows.Forms.ColumnHeader Position;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.Label labelInstitAddress;
        private System.Windows.Forms.Label labelDormAddress;
        private System.Windows.Forms.ListView listViewCTP;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader MiddleName;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelMidName;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.Label labelFirName;
        private System.Windows.Forms.Label labelLasName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelCTP;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.ComboBox comboBoxInstit;
        private System.Windows.Forms.ComboBox comboBoxDorm;
        private System.Windows.Forms.ColumnHeader DOB;
        private System.Windows.Forms.DateTimePicker dateTimePickerCTP;
        private System.Windows.Forms.Label labelDOB;
    }
}