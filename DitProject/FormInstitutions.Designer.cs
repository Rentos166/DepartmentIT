
namespace DitProject
{
    partial class FormInstitutions
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
            this.listViewInstit = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumBuilding = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelNumBuilding = new System.Windows.Forms.Label();
            this.textBoxNumBuilding = new System.Windows.Forms.TextBox();
            this.labelInstit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewInstit
            // 
            this.listViewInstit.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.NumBuilding,
            this.Address});
            this.listViewInstit.FullRowSelect = true;
            this.listViewInstit.GridLines = true;
            this.listViewInstit.HideSelection = false;
            this.listViewInstit.Location = new System.Drawing.Point(22, 205);
            this.listViewInstit.Name = "listViewInstit";
            this.listViewInstit.Size = new System.Drawing.Size(256, 204);
            this.listViewInstit.TabIndex = 137;
            this.listViewInstit.UseCompatibleStateImageBehavior = false;
            this.listViewInstit.View = System.Windows.Forms.View.Details;
            this.listViewInstit.SelectedIndexChanged += new System.EventHandler(this.listViewInstit_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // NumBuilding
            // 
            this.NumBuilding.Text = "Номер корпуса";
            this.NumBuilding.Width = 118;
            // 
            // Address
            // 
            this.Address.Text = "Адрес";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(71, 32);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 136;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(216, 415);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 135;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(119, 415);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(80, 23);
            this.buttonEdit.TabIndex = 134;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(11, 415);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 133;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(119, 165);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(100, 22);
            this.textBoxAddress.TabIndex = 125;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(61, 168);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(52, 17);
            this.labelAddress.TabIndex = 126;
            this.labelAddress.Text = "Адрес:";
            // 
            // labelNumBuilding
            // 
            this.labelNumBuilding.AutoSize = true;
            this.labelNumBuilding.Location = new System.Drawing.Point(1, 140);
            this.labelNumBuilding.Name = "labelNumBuilding";
            this.labelNumBuilding.Size = new System.Drawing.Size(112, 17);
            this.labelNumBuilding.TabIndex = 124;
            this.labelNumBuilding.Text = "Номер корпуса:";
            // 
            // textBoxNumBuilding
            // 
            this.textBoxNumBuilding.Location = new System.Drawing.Point(119, 137);
            this.textBoxNumBuilding.Name = "textBoxNumBuilding";
            this.textBoxNumBuilding.Size = new System.Drawing.Size(100, 22);
            this.textBoxNumBuilding.TabIndex = 123;
            this.textBoxNumBuilding.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumBuilding_KeyPress);
            // 
            // labelInstit
            // 
            this.labelInstit.AutoSize = true;
            this.labelInstit.Location = new System.Drawing.Point(67, 99);
            this.labelInstit.Name = "labelInstit";
            this.labelInstit.Size = new System.Drawing.Size(124, 17);
            this.labelInstit.TabIndex = 122;
            this.labelInstit.Text = "Институты ВятГУ";
            // 
            // FormInstitutions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 450);
            this.Controls.Add(this.listViewInstit);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelNumBuilding);
            this.Controls.Add(this.textBoxNumBuilding);
            this.Controls.Add(this.labelInstit);
            this.Name = "FormInstitutions";
            this.Text = "Институты ВятГУ";
            this.Load += new System.EventHandler(this.FormInstitutions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewInstit;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader NumBuilding;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelNumBuilding;
        private System.Windows.Forms.TextBox textBoxNumBuilding;
        private System.Windows.Forms.Label labelInstit;
    }
}