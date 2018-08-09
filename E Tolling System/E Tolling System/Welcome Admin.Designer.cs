namespace E_Tolling_System
{
    partial class Welcome_Admin
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
            this.logout_bttn = new System.Windows.Forms.Button();
            this.register_new_tollgate_bttn = new System.Windows.Forms.Button();
            this.already_registered_user_bttn = new System.Windows.Forms.Button();
            this.register_user_bttn = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logout_bttn
            // 
            this.logout_bttn.Location = new System.Drawing.Point(237, 104);
            this.logout_bttn.Name = "logout_bttn";
            this.logout_bttn.Size = new System.Drawing.Size(120, 23);
            this.logout_bttn.TabIndex = 15;
            this.logout_bttn.Text = "Logout";
            this.logout_bttn.UseVisualStyleBackColor = true;
            this.logout_bttn.Click += new System.EventHandler(this.logout_bttn_Click);
            // 
            // register_new_tollgate_bttn
            // 
            this.register_new_tollgate_bttn.Location = new System.Drawing.Point(234, 59);
            this.register_new_tollgate_bttn.Name = "register_new_tollgate_bttn";
            this.register_new_tollgate_bttn.Size = new System.Drawing.Size(121, 23);
            this.register_new_tollgate_bttn.TabIndex = 14;
            this.register_new_tollgate_bttn.Text = "register new Tollgate";
            this.register_new_tollgate_bttn.UseVisualStyleBackColor = true;
            this.register_new_tollgate_bttn.Click += new System.EventHandler(this.btnRegisterNewT_Click);
            // 
            // already_registered_user_bttn
            // 
            this.already_registered_user_bttn.Location = new System.Drawing.Point(8, 104);
            this.already_registered_user_bttn.Name = "already_registered_user_bttn";
            this.already_registered_user_bttn.Size = new System.Drawing.Size(153, 23);
            this.already_registered_user_bttn.TabIndex = 13;
            this.already_registered_user_bttn.Text = "User already registered";
            this.already_registered_user_bttn.UseVisualStyleBackColor = true;
            this.already_registered_user_bttn.Click += new System.EventHandler(this.already_registered_user_bttn_Click);
            // 
            // register_user_bttn
            // 
            this.register_user_bttn.Location = new System.Drawing.Point(8, 59);
            this.register_user_bttn.Name = "register_user_bttn";
            this.register_user_bttn.Size = new System.Drawing.Size(153, 23);
            this.register_user_bttn.TabIndex = 12;
            this.register_user_bttn.Text = "register User";
            this.register_user_bttn.UseVisualStyleBackColor = true;
            this.register_user_bttn.Click += new System.EventHandler(this.addvehiclebtn_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(116, 17);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(148, 25);
            this.Label1.TabIndex = 11;
            this.Label1.Text = "Welcome Admin";
            // 
            // Welcome_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 208);
            this.Controls.Add(this.logout_bttn);
            this.Controls.Add(this.register_new_tollgate_bttn);
            this.Controls.Add(this.already_registered_user_bttn);
            this.Controls.Add(this.register_user_bttn);
            this.Controls.Add(this.Label1);
            this.Name = "Welcome_Admin";
            this.Text = "Welcome_Admin";
            this.Load += new System.EventHandler(this.Welcome_Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button logout_bttn;
        internal System.Windows.Forms.Button register_new_tollgate_bttn;
        internal System.Windows.Forms.Button already_registered_user_bttn;
        internal System.Windows.Forms.Button register_user_bttn;
        internal System.Windows.Forms.Label Label1;
    }
}