
namespace DitProject
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelMain = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonCIB = new System.Windows.Forms.Button();
            this.buttonCTP = new System.Windows.Forms.Button();
            this.buttonInstit = new System.Windows.Forms.Button();
            this.buttonDorms = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Location = new System.Drawing.Point(9, 92);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(296, 17);
            this.labelMain.TabIndex = 0;
            this.labelMain.Text = "Департамент информационных технологий";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(95, 24);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonCIB
            // 
            this.buttonCIB.Location = new System.Drawing.Point(85, 151);
            this.buttonCIB.Name = "buttonCIB";
            this.buttonCIB.Size = new System.Drawing.Size(135, 32);
            this.buttonCIB.TabIndex = 2;
            this.buttonCIB.Text = "Сотрудники ЦИБ";
            this.buttonCIB.UseVisualStyleBackColor = true;
            this.buttonCIB.Click += new System.EventHandler(this.buttonCIB_Click);
            // 
            // buttonCTP
            // 
            this.buttonCTP.Location = new System.Drawing.Point(85, 189);
            this.buttonCTP.Name = "buttonCTP";
            this.buttonCTP.Size = new System.Drawing.Size(135, 32);
            this.buttonCTP.TabIndex = 3;
            this.buttonCTP.Text = "Сотрудники ЦТП";
            this.buttonCTP.UseVisualStyleBackColor = true;
            this.buttonCTP.Click += new System.EventHandler(this.buttonCTP_Click);
            // 
            // buttonInstit
            // 
            this.buttonInstit.Location = new System.Drawing.Point(85, 227);
            this.buttonInstit.Name = "buttonInstit";
            this.buttonInstit.Size = new System.Drawing.Size(135, 36);
            this.buttonInstit.TabIndex = 4;
            this.buttonInstit.Text = "Институты";
            this.buttonInstit.UseVisualStyleBackColor = true;
            this.buttonInstit.Click += new System.EventHandler(this.buttonInstit_Click);
            // 
            // buttonDorms
            // 
            this.buttonDorms.Location = new System.Drawing.Point(85, 269);
            this.buttonDorms.Name = "buttonDorms";
            this.buttonDorms.Size = new System.Drawing.Size(135, 38);
            this.buttonDorms.TabIndex = 5;
            this.buttonDorms.Text = "Общежития";
            this.buttonDorms.UseVisualStyleBackColor = true;
            this.buttonDorms.Click += new System.EventHandler(this.buttonDorms_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(115, 323);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 369);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonDorms);
            this.Controls.Add(this.buttonInstit);
            this.Controls.Add(this.buttonCTP);
            this.Controls.Add(this.buttonCIB);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.labelMain);
            this.Name = "Menu";
            this.Text = "Главная";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonCIB;
        private System.Windows.Forms.Button buttonCTP;
        private System.Windows.Forms.Button buttonInstit;
        private System.Windows.Forms.Button buttonDorms;
        private System.Windows.Forms.Button buttonExit;
    }
}

