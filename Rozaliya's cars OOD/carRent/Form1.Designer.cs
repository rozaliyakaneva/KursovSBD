namespace carRent
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавянеНаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новаАгенцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.автомобилToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.служителToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отдаванеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.приеманеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отдадениАвтомобилиОтПредставителствоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отдадениАвтомобилиОтСлужителToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавянеНаToolStripMenuItem,
            this.operationsToolStripMenuItem,
            this.справкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавянеНаToolStripMenuItem
            // 
            this.добавянеНаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаАгенцияToolStripMenuItem,
            this.автомобилToolStripMenuItem,
            this.клиентToolStripMenuItem,
            this.служителToolStripMenuItem});
            this.добавянеНаToolStripMenuItem.Name = "добавянеНаToolStripMenuItem";
            this.добавянеНаToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.добавянеНаToolStripMenuItem.Text = "Add";
            // 
            // новаАгенцияToolStripMenuItem
            // 
            this.новаАгенцияToolStripMenuItem.Name = "новаАгенцияToolStripMenuItem";
            this.новаАгенцияToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.новаАгенцияToolStripMenuItem.Text = "Agency";
            this.новаАгенцияToolStripMenuItem.Click += new System.EventHandler(this.новаАгенцияToolStripMenuItem_Click);
            // 
            // автомобилToolStripMenuItem
            // 
            this.автомобилToolStripMenuItem.Name = "автомобилToolStripMenuItem";
            this.автомобилToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.автомобилToolStripMenuItem.Text = "Car";
            this.автомобилToolStripMenuItem.Click += new System.EventHandler(this.автомобилToolStripMenuItem_Click);
            // 
            // клиентToolStripMenuItem
            // 
            this.клиентToolStripMenuItem.Name = "клиентToolStripMenuItem";
            this.клиентToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.клиентToolStripMenuItem.Text = "Client";
            this.клиентToolStripMenuItem.Click += new System.EventHandler(this.клиентToolStripMenuItem_Click);
            // 
            // служителToolStripMenuItem
            // 
            this.служителToolStripMenuItem.Name = "служителToolStripMenuItem";
            this.служителToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.служителToolStripMenuItem.Text = "Worker";
            this.служителToolStripMenuItem.Click += new System.EventHandler(this.служителToolStripMenuItem_Click);
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отдаванеToolStripMenuItem,
            this.приеманеToolStripMenuItem});
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.operationsToolStripMenuItem.Text = "Operations";
            //this.operationsToolStripMenuItem.Click += new System.EventHandler(this.operationsToolStripMenuItem_Click);
            // 
            // отдаванеToolStripMenuItem
            // 
            this.отдаванеToolStripMenuItem.Name = "отдаванеToolStripMenuItem";
            this.отдаванеToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.отдаванеToolStripMenuItem.Text = "Rent";
            this.отдаванеToolStripMenuItem.Click += new System.EventHandler(this.отдаванеToolStripMenuItem_Click);
            // 
            // приеманеToolStripMenuItem
            // 
            this.приеманеToolStripMenuItem.Name = "приеманеToolStripMenuItem";
            this.приеманеToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.приеманеToolStripMenuItem.Text = "Return";
            this.приеманеToolStripMenuItem.Click += new System.EventHandler(this.приеманеToolStripMenuItem_Click);
            // 
            // справкиToolStripMenuItem
            // 
            this.справкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отдадениАвтомобилиОтПредставителствоToolStripMenuItem,
            this.отдадениАвтомобилиОтСлужителToolStripMenuItem});
            this.справкиToolStripMenuItem.Name = "справкиToolStripMenuItem";
            this.справкиToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.справкиToolStripMenuItem.Text = "Querries";
            // 
            // отдадениАвтомобилиОтПредставителствоToolStripMenuItem
            // 
            this.отдадениАвтомобилиОтПредставителствоToolStripMenuItem.Name = "отдадениАвтомобилиОтПредставителствоToolStripMenuItem";
            this.отдадениАвтомобилиОтПредставителствоToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.отдадениАвтомобилиОтПредставителствоToolStripMenuItem.Text = "Cars rented by company";
            this.отдадениАвтомобилиОтПредставителствоToolStripMenuItem.Click += new System.EventHandler(this.отдадениАвтомобилиОтПредставителствоToolStripMenuItem_Click);
            // 
            // отдадениАвтомобилиОтСлужителToolStripMenuItem
            // 
            this.отдадениАвтомобилиОтСлужителToolStripMenuItem.Name = "отдадениАвтомобилиОтСлужителToolStripMenuItem";
            this.отдадениАвтомобилиОтСлужителToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.отдадениАвтомобилиОтСлужителToolStripMenuItem.Text = "Cars rented by worker";
            this.отдадениАвтомобилиОтСлужителToolStripMenuItem.Click += new System.EventHandler(this.отдадениАвтомобилиОтСлужителToolStripMenuItem_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Purple;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(396, 276);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 38);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(346, 229);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(173, 22);
            this.txtPassword.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username: ";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(347, 194);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(173, 22);
            this.txtUsername.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 460);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Rent A Car";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавянеНаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новаАгенцияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem автомобилToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem служителToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отдадениАвтомобилиОтСлужителToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отдадениАвтомобилиОтПредставителствоToolStripMenuItem;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отдаванеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem приеманеToolStripMenuItem;
    }
}

