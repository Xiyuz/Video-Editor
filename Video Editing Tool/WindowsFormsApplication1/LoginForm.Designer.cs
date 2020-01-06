namespace DataStudioRecorder
{
    partial class LoginForm
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
        /// Required method for Designer support
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_user_name = new TX.Framework.WindowUI.Controls.TXTextBox();
            this.txt_user_pass = new TX.Framework.WindowUI.Controls.TXTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_login = new TX.Framework.WindowUI.Controls.TXButton();
            this.lb_messager = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "";
            // 
            // txt_user_name
            // 
            this.txt_user_name.BackColor = System.Drawing.Color.Transparent;
            this.txt_user_name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txt_user_name.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_user_name.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_user_name.HeightLightBolorColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.txt_user_name.Image = null;
            this.txt_user_name.ImageSize = new System.Drawing.Size(0, 0);
            this.txt_user_name.Location = new System.Drawing.Point(210, 198);
            this.txt_user_name.Name = "txt_user_name";
            this.txt_user_name.Padding = new System.Windows.Forms.Padding(2);
            this.txt_user_name.PasswordChar = '\0';
            this.txt_user_name.Required = false;
            this.txt_user_name.Size = new System.Drawing.Size(198, 22);
            this.txt_user_name.TabIndex = 1;
            // 
            // txt_user_pass
            // 
            this.txt_user_pass.BackColor = System.Drawing.Color.Transparent;
            this.txt_user_pass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txt_user_pass.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_user_pass.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_user_pass.HeightLightBolorColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.txt_user_pass.Image = null;
            this.txt_user_pass.ImageSize = new System.Drawing.Size(0, 0);
            this.txt_user_pass.Location = new System.Drawing.Point(210, 244);
            this.txt_user_pass.Name = "txt_user_pass";
            this.txt_user_pass.Padding = new System.Windows.Forms.Padding(2);
            this.txt_user_pass.PasswordChar = '\0';
            this.txt_user_pass.Required = false;
            this.txt_user_pass.Size = new System.Drawing.Size(198, 22);
            this.txt_user_pass.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "";
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.btn_login.Image = null;
            this.btn_login.Location = new System.Drawing.Point(207, 334);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(198, 31);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lb_messager
            // 
            this.lb_messager.AutoSize = true;
            this.lb_messager.ForeColor = System.Drawing.Color.Red;
            this.lb_messager.Location = new System.Drawing.Point(207, 309);
            this.lb_messager.Name = "lb_messager";
            this.lb_messager.Size = new System.Drawing.Size(95, 15);
            this.lb_messager.TabIndex = 5;
            this.lb_messager.Text = "lb_messager";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(210, 283);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(86, 19);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.ClientSize = new System.Drawing.Size(546, 393);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lb_messager);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_user_pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_user_name);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label1;
        
        private TX.Framework.WindowUI.Controls.TXTextBox txt_user_name;
        private TX.Framework.WindowUI.Controls.TXTextBox txt_user_pass;
        private System.Windows.Forms.Label label2;
        private TX.Framework.WindowUI.Controls.TXButton btn_login;
        private System.Windows.Forms.Label lb_messager;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}