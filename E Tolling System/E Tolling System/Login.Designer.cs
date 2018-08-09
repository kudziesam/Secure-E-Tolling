namespace E_Tolling_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Pass_txtBox = new System.Windows.Forms.TextBox();
            this.enter_bttn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usernamecomboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 100);
            this.panel1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(112, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // Pass_txtBox
            // 
            this.Pass_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass_txtBox.Location = new System.Drawing.Point(155, 165);
            this.Pass_txtBox.Multiline = true;
            this.Pass_txtBox.Name = "Pass_txtBox";
            this.Pass_txtBox.PasswordChar = 'X';
            this.Pass_txtBox.Size = new System.Drawing.Size(250, 42);
            this.Pass_txtBox.TabIndex = 21;
            // 
            // enter_bttn
            // 
            this.enter_bttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enter_bttn.BackgroundImage")));
            this.enter_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enter_bttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.enter_bttn.Location = new System.Drawing.Point(303, 212);
            this.enter_bttn.Name = "enter_bttn";
            this.enter_bttn.Size = new System.Drawing.Size(98, 51);
            this.enter_bttn.TabIndex = 22;
            this.enter_bttn.UseVisualStyleBackColor = true;
            this.enter_bttn.Click += new System.EventHandler(this.enter_bttn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Password";
            // 
            // usernamecomboBox
            // 
            this.usernamecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usernamecomboBox.FormattingEnabled = true;
            this.usernamecomboBox.Items.AddRange(new object[] {
            "admin",
            "cashier"});
            this.usernamecomboBox.Location = new System.Drawing.Point(155, 122);
            this.usernamecomboBox.Name = "usernamecomboBox";
            this.usernamecomboBox.Size = new System.Drawing.Size(246, 21);
            this.usernamecomboBox.TabIndex = 27;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 338);
            this.Controls.Add(this.usernamecomboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pass_txtBox);
            this.Controls.Add(this.enter_bttn);
            this.Name = "Login";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Pass_txtBox;
        private System.Windows.Forms.Button enter_bttn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox usernamecomboBox;
    }
}

