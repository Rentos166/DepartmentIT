
namespace DitProject
{
    partial class FormDIT
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
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MiddleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.listViewDIT = new System.Windows.Forms.ListView();
            this.Position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelPosition = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelMidName = new System.Windows.Forms.Label();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.labelFirName = new System.Windows.Forms.Label();
            this.labelLasName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelDIT = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.DOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelDOB = new System.Windows.Forms.Label();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 80;
            // 
            // Phone
            // 
            this.Phone.Text = "Телефон";
            this.Phone.Width = 84;
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
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(124, 310);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(167, 22);
            this.textBoxPosition.TabIndex = 120;
            // 
            // listViewDIT
            // 
            this.listViewDIT.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.LastName,
            this.FirstName,
            this.MiddleName,
            this.DOB,
            this.Phone,
            this.Email,
            this.Position});
            this.listViewDIT.FullRowSelect = true;
            this.listViewDIT.GridLines = true;
            this.listViewDIT.HideSelection = false;
            this.listViewDIT.Location = new System.Drawing.Point(330, 102);
            this.listViewDIT.Name = "listViewDIT";
            this.listViewDIT.Size = new System.Drawing.Size(682, 204);
            this.listViewDIT.TabIndex = 117;
            this.listViewDIT.UseCompatibleStateImageBehavior = false;
            this.listViewDIT.View = System.Windows.Forms.View.Details;
            this.listViewDIT.SelectedIndexChanged += new System.EventHandler(this.listViewDIT_SelectedIndexChanged);
            // 
            // Position
            // 
            this.Position.Text = "Должность";
            this.Position.Width = 102;
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(30, 313);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(85, 17);
            this.labelPosition.TabIndex = 121;
            this.labelPosition.Text = "Должность:";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(548, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 116;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(665, 312);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 115;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(568, 312);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(80, 23);
            this.buttonEdit.TabIndex = 114;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(460, 312);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 113;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(124, 127);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(167, 22);
            this.textBoxFirstName.TabIndex = 105;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(124, 273);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(167, 22);
            this.textBoxEmail.TabIndex = 111;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(46, 240);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(72, 17);
            this.labelPhone.TabIndex = 110;
            this.labelPhone.Text = "Телефон:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(124, 235);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(167, 22);
            this.textBoxPhone.TabIndex = 109;
            this.textBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhone_KeyPress);
            // 
            // labelMidName
            // 
            this.labelMidName.AutoSize = true;
            this.labelMidName.Location = new System.Drawing.Point(33, 171);
            this.labelMidName.Name = "labelMidName";
            this.labelMidName.Size = new System.Drawing.Size(75, 17);
            this.labelMidName.TabIndex = 108;
            this.labelMidName.Text = "Отчество:";
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(124, 168);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(167, 22);
            this.textBoxMiddleName.TabIndex = 107;
            // 
            // labelFirName
            // 
            this.labelFirName.AutoSize = true;
            this.labelFirName.Location = new System.Drawing.Point(72, 130);
            this.labelFirName.Name = "labelFirName";
            this.labelFirName.Size = new System.Drawing.Size(39, 17);
            this.labelFirName.TabIndex = 106;
            this.labelFirName.Text = "Имя:";
            // 
            // labelLasName
            // 
            this.labelLasName.AutoSize = true;
            this.labelLasName.Location = new System.Drawing.Point(41, 102);
            this.labelLasName.Name = "labelLasName";
            this.labelLasName.Size = new System.Drawing.Size(74, 17);
            this.labelLasName.TabIndex = 104;
            this.labelLasName.Text = "Фамилия:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(124, 99);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(167, 22);
            this.textBoxLastName.TabIndex = 103;
            // 
            // labelDIT
            // 
            this.labelDIT.AutoSize = true;
            this.labelDIT.Location = new System.Drawing.Point(545, 82);
            this.labelDIT.Name = "labelDIT";
            this.labelDIT.Size = new System.Drawing.Size(120, 17);
            this.labelDIT.TabIndex = 102;
            this.labelDIT.Text = "Сотрудники ДИТ";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(69, 278);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(46, 17);
            this.labelEmail.TabIndex = 112;
            this.labelEmail.Text = "Email:";
            // 
            // DOB
            // 
            this.DOB.Text = "Дата рождения";
            this.DOB.Width = 118;
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Location = new System.Drawing.Point(3, 210);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(115, 17);
            this.labelDOB.TabIndex = 123;
            this.labelDOB.Text = "Дата рождения:";
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.Location = new System.Drawing.Point(124, 204);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(167, 22);
            this.dateTimePickerDOB.TabIndex = 124;
            // 
            // FormDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 356);
            this.Controls.Add(this.dateTimePickerDOB);
            this.Controls.Add(this.labelDOB);
            this.Controls.Add(this.textBoxPosition);
            this.Controls.Add(this.listViewDIT);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelMidName);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.labelFirName);
            this.Controls.Add(this.labelLasName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelDIT);
            this.Controls.Add(this.labelEmail);
            this.Name = "FormDIT";
            this.Text = "Сотрудники ДИТ";
            this.Load += new System.EventHandler(this.FormDIT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.ColumnHeader MiddleName;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.ListView listViewDIT;
        private System.Windows.Forms.ColumnHeader Position;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelMidName;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.Label labelFirName;
        private System.Windows.Forms.Label labelLasName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelDIT;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.ColumnHeader DOB;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
    }
}