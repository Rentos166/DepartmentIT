
namespace DitProject
{
    partial class FormDorms
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
            this.listViewDorm = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumDorm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelNumBuilding = new System.Windows.Forms.Label();
            this.textBoxNumDorm = new System.Windows.Forms.TextBox();
            this.labelDorms = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewDorm
            // 
            this.listViewDorm.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.NumDorm,
            this.Address});
            this.listViewDorm.FullRowSelect = true;
            this.listViewDorm.GridLines = true;
            this.listViewDorm.HideSelection = false;
            this.listViewDorm.Location = new System.Drawing.Point(29, 202);
            this.listViewDorm.Name = "listViewDorm";
            this.listViewDorm.Size = new System.Drawing.Size(256, 204);
            this.listViewDorm.TabIndex = 147;
            this.listViewDorm.UseCompatibleStateImageBehavior = false;
            this.listViewDorm.View = System.Windows.Forms.View.Details;
            this.listViewDorm.SelectedIndexChanged += new System.EventHandler(this.listViewDorm_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // NumDorm
            // 
            this.NumDorm.Text = "Номер общежития";
            this.NumDorm.Width = 134;
            // 
            // Address
            // 
            this.Address.Text = "Адрес";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(78, 29);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 146;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(223, 412);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 145;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(126, 412);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(80, 23);
            this.buttonEdit.TabIndex = 144;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(18, 412);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 143;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(148, 162);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(100, 22);
            this.textBoxAddress.TabIndex = 141;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(90, 165);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(52, 17);
            this.labelAddress.TabIndex = 142;
            this.labelAddress.Text = "Адрес:";
            // 
            // labelNumBuilding
            // 
            this.labelNumBuilding.AutoSize = true;
            this.labelNumBuilding.Location = new System.Drawing.Point(8, 137);
            this.labelNumBuilding.Name = "labelNumBuilding";
            this.labelNumBuilding.Size = new System.Drawing.Size(134, 17);
            this.labelNumBuilding.TabIndex = 140;
            this.labelNumBuilding.Text = "Номер общежития:";
            // 
            // textBoxNumDorm
            // 
            this.textBoxNumDorm.Location = new System.Drawing.Point(148, 134);
            this.textBoxNumDorm.Name = "textBoxNumDorm";
            this.textBoxNumDorm.Size = new System.Drawing.Size(100, 22);
            this.textBoxNumDorm.TabIndex = 139;
            this.textBoxNumDorm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumDorm_KeyPress);
            // 
            // labelDorms
            // 
            this.labelDorms.AutoSize = true;
            this.labelDorms.Location = new System.Drawing.Point(74, 96);
            this.labelDorms.Name = "labelDorms";
            this.labelDorms.Size = new System.Drawing.Size(131, 17);
            this.labelDorms.TabIndex = 138;
            this.labelDorms.Text = "Общежития ВятГУ";
            // 
            // FormDorms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 450);
            this.Controls.Add(this.listViewDorm);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelNumBuilding);
            this.Controls.Add(this.textBoxNumDorm);
            this.Controls.Add(this.labelDorms);
            this.Name = "FormDorms";
            this.Text = "Общежития ВятГУ";
            this.Load += new System.EventHandler(this.FormDorms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewDorm;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader NumDorm;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelNumBuilding;
        private System.Windows.Forms.TextBox textBoxNumDorm;
        private System.Windows.Forms.Label labelDorms;
    }
}