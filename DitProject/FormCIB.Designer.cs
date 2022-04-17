
namespace DitProject
{
    partial class FormCIB
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
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MiddleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewCIB = new System.Windows.Forms.ListView();
            this.Instit_Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dorm_Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelLasName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelCIB = new System.Windows.Forms.Label();
            this.labelDormAddress = new System.Windows.Forms.Label();
            this.labelInstitAddress = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.comboBoxInstit = new System.Windows.Forms.ComboBox();
            this.comboBoxDorm = new System.Windows.Forms.ComboBox();
            this.dateTimePickerCIB = new System.Windows.Forms.DateTimePicker();
            this.labelDOB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 80;
            // 
            // MiddleName
            // 
            this.MiddleName.Text = "Отчество";
            this.MiddleName.Width = 82;
            // 
            // FirstName
            // 
            this.FirstName.Text = "Имя";
            // 
            // LastName
            // 
            this.LastName.Text = "Фамилия";
            this.LastName.Width = 90;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // listViewCIB
            // 
            this.listViewCIB.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
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
            this.listViewCIB.FullRowSelect = true;
            this.listViewCIB.GridLines = true;
            this.listViewCIB.HideSelection = false;
            this.listViewCIB.Location = new System.Drawing.Point(326, 115);
            this.listViewCIB.Name = "listViewCIB";
            this.listViewCIB.Size = new System.Drawing.Size(956, 266);
            this.listViewCIB.TabIndex = 71;
            this.listViewCIB.UseCompatibleStateImageBehavior = false;
            this.listViewCIB.View = System.Windows.Forms.View.Details;
            this.listViewCIB.SelectedIndexChanged += new System.EventHandler(this.listViewCIB_SelectedIndexChanged);
            // 
            // Instit_Address
            // 
            this.Instit_Address.Text = "Корпус института";
            this.Instit_Address.Width = 135;
            // 
            // Dorm_Address
            // 
            this.Dorm_Address.Text = "Корпус общежития";
            this.Dorm_Address.Width = 137;
            // 
            // DOB
            // 
            this.DOB.Text = "Дата рождения";
            this.DOB.Width = 120;
            // 
            // Phone
            // 
            this.Phone.Text = "Телефон";
            this.Phone.Width = 84;
            // 
            // Position
            // 
            this.Position.Text = "Должность";
            this.Position.Width = 102;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(565, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 70;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(734, 388);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 69;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(637, 388);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(80, 23);
            this.buttonEdit.TabIndex = 68;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(529, 388);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 67;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(98, 379);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(46, 17);
            this.labelEmail.TabIndex = 66;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(153, 374);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 22);
            this.textBoxEmail.TabIndex = 65;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(75, 341);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(72, 17);
            this.labelPhone.TabIndex = 64;
            this.labelPhone.Text = "Телефон:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(153, 336);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(100, 22);
            this.textBoxPhone.TabIndex = 63;
            this.textBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhone_KeyPress);
            // 
            // labelMidName
            // 
            this.labelMidName.AutoSize = true;
            this.labelMidName.Location = new System.Drawing.Point(62, 249);
            this.labelMidName.Name = "labelMidName";
            this.labelMidName.Size = new System.Drawing.Size(75, 17);
            this.labelMidName.TabIndex = 62;
            this.labelMidName.Text = "Отчество:";
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(153, 246);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(100, 22);
            this.textBoxMiddleName.TabIndex = 61;
            // 
            // labelFirName
            // 
            this.labelFirName.AutoSize = true;
            this.labelFirName.Location = new System.Drawing.Point(101, 208);
            this.labelFirName.Name = "labelFirName";
            this.labelFirName.Size = new System.Drawing.Size(39, 17);
            this.labelFirName.TabIndex = 60;
            this.labelFirName.Text = "Имя:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(153, 205);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 22);
            this.textBoxFirstName.TabIndex = 59;
            // 
            // labelLasName
            // 
            this.labelLasName.AutoSize = true;
            this.labelLasName.Location = new System.Drawing.Point(70, 180);
            this.labelLasName.Name = "labelLasName";
            this.labelLasName.Size = new System.Drawing.Size(74, 17);
            this.labelLasName.TabIndex = 58;
            this.labelLasName.Text = "Фамилия:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(153, 177);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 22);
            this.textBoxLastName.TabIndex = 57;
            // 
            // labelCIB
            // 
            this.labelCIB.AutoSize = true;
            this.labelCIB.Location = new System.Drawing.Point(562, 79);
            this.labelCIB.Name = "labelCIB";
            this.labelCIB.Size = new System.Drawing.Size(120, 17);
            this.labelCIB.TabIndex = 56;
            this.labelCIB.Text = "Сотрудники ЦИБ";
            // 
            // labelDormAddress
            // 
            this.labelDormAddress.AutoSize = true;
            this.labelDormAddress.Location = new System.Drawing.Point(9, 144);
            this.labelDormAddress.Name = "labelDormAddress";
            this.labelDormAddress.Size = new System.Drawing.Size(138, 17);
            this.labelDormAddress.TabIndex = 73;
            this.labelDormAddress.Text = "Корпус общежития:";
            // 
            // labelInstitAddress
            // 
            this.labelInstitAddress.AutoSize = true;
            this.labelInstitAddress.Location = new System.Drawing.Point(17, 115);
            this.labelInstitAddress.Name = "labelInstitAddress";
            this.labelInstitAddress.Size = new System.Drawing.Size(130, 17);
            this.labelInstitAddress.TabIndex = 75;
            this.labelInstitAddress.Text = "Корпус института:";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(59, 414);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(85, 17);
            this.labelPosition.TabIndex = 77;
            this.labelPosition.Text = "Должность:";
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(153, 411);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(100, 22);
            this.textBoxPosition.TabIndex = 76;
            // 
            // comboBoxInstit
            // 
            this.comboBoxInstit.FormattingEnabled = true;
            this.comboBoxInstit.Location = new System.Drawing.Point(153, 115);
            this.comboBoxInstit.Name = "comboBoxInstit";
            this.comboBoxInstit.Size = new System.Drawing.Size(121, 24);
            this.comboBoxInstit.TabIndex = 78;
            // 
            // comboBoxDorm
            // 
            this.comboBoxDorm.FormattingEnabled = true;
            this.comboBoxDorm.Location = new System.Drawing.Point(153, 144);
            this.comboBoxDorm.Name = "comboBoxDorm";
            this.comboBoxDorm.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDorm.TabIndex = 79;
            // 
            // dateTimePickerCIB
            // 
            this.dateTimePickerCIB.Location = new System.Drawing.Point(153, 291);
            this.dateTimePickerCIB.Name = "dateTimePickerCIB";
            this.dateTimePickerCIB.Size = new System.Drawing.Size(167, 22);
            this.dateTimePickerCIB.TabIndex = 126;
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Location = new System.Drawing.Point(25, 296);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(115, 17);
            this.labelDOB.TabIndex = 125;
            this.labelDOB.Text = "Дата рождения:";
            // 
            // FormCIB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 450);
            this.Controls.Add(this.dateTimePickerCIB);
            this.Controls.Add(this.labelDOB);
            this.Controls.Add(this.comboBoxDorm);
            this.Controls.Add(this.comboBoxInstit);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.textBoxPosition);
            this.Controls.Add(this.labelInstitAddress);
            this.Controls.Add(this.labelDormAddress);
            this.Controls.Add(this.listViewCIB);
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
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelLasName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelCIB);
            this.Name = "FormCIB";
            this.Text = "Сотрудники ЦИБ";
            this.Load += new System.EventHandler(this.FormCIB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader MiddleName;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ListView listViewCIB;
        private System.Windows.Forms.ColumnHeader Instit_Address;
        private System.Windows.Forms.ColumnHeader Dorm_Address;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.ColumnHeader Position;
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
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelLasName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelCIB;
        private System.Windows.Forms.Label labelDormAddress;
        private System.Windows.Forms.Label labelInstitAddress;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.ComboBox comboBoxInstit;
        private System.Windows.Forms.ComboBox comboBoxDorm;
        private System.Windows.Forms.ColumnHeader DOB;
        private System.Windows.Forms.DateTimePicker dateTimePickerCIB;
        private System.Windows.Forms.Label labelDOB;
    }
}