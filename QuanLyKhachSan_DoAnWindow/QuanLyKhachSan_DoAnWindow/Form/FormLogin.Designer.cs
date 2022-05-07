
namespace QuanLyKhachSan_DoAnWindow
{
    partial class FormLogin
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
            this.title = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_password = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label_username = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.bt_login = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Silver;
            this.title.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.title.Location = new System.Drawing.Point(75, 49);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(587, 40);
            this.title.TabIndex = 0;
            this.title.Text = "CHƯƠNG TRÌNH QUẢN LÝ KHÁCH SẠN";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.92405F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.07595F));
            this.tableLayoutPanel1.Controls.Add(this.label_password, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_username, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_password, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_username, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(83, 203);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(527, 181);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label_password
            // 
            this.label_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_password.AutoSize = true;
            this.label_password.BackColor = System.Drawing.Color.Linen;
            this.label_password.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(4, 124);
            this.label_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(170, 23);
            this.label_password.TabIndex = 1;
            this.label_password.Text = "Mật khẩu:";
            this.label_password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_username
            // 
            this.txt_username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_username.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(182, 29);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(341, 31);
            this.txt_username.TabIndex = 2;
            // 
            // txt_password
            // 
            this.txt_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_password.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(182, 120);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(341, 31);
            this.txt_password.TabIndex = 3;
            // 
            // label_username
            // 
            this.label_username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_username.AutoSize = true;
            this.label_username.BackColor = System.Drawing.Color.Linen;
            this.label_username.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(4, 33);
            this.label_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(170, 23);
            this.label_username.TabIndex = 0;
            this.label_username.Text = "Tài khoản:";
            this.label_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.BackColor = System.Drawing.Color.Silver;
            this.label_login.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_login.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_login.Location = new System.Drawing.Point(256, 128);
            this.label_login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(188, 40);
            this.label_login.TabIndex = 2;
            this.label_login.Text = "Đăng nhập";
            this.label_login.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bt_login
            // 
            this.bt_login.Location = new System.Drawing.Point(401, 425);
            this.bt_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(155, 39);
            this.bt_login.TabIndex = 5;
            this.bt_login.Text = "Đăng nhập";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(141, 425);
            this.bt_exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(155, 39);
            this.bt_exit.TabIndex = 6;
            this.bt_exit.Text = "Thoát";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(769, 506);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.title);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.Button bt_exit;
    }
}