namespace E_Tolling_System
{
    partial class user_alreadyRegistered
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
            this.registerComplaint_bttn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.back_bttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registerComplaint_bttn
            // 
            this.registerComplaint_bttn.Location = new System.Drawing.Point(337, 56);
            this.registerComplaint_bttn.Name = "registerComplaint_bttn";
            this.registerComplaint_bttn.Size = new System.Drawing.Size(126, 28);
            this.registerComplaint_bttn.TabIndex = 1;
            this.registerComplaint_bttn.Text = "Register complaint";
            this.registerComplaint_bttn.UseVisualStyleBackColor = true;
            this.registerComplaint_bttn.Click += new System.EventHandler(this.registerComplaint_bttn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Registered User";
            // 
            // back_bttn
            // 
            this.back_bttn.Location = new System.Drawing.Point(337, 149);
            this.back_bttn.Name = "back_bttn";
            this.back_bttn.Size = new System.Drawing.Size(126, 28);
            this.back_bttn.TabIndex = 4;
            this.back_bttn.Text = "BACK";
            this.back_bttn.UseVisualStyleBackColor = true;
            this.back_bttn.Click += new System.EventHandler(this.back_bttn_Click);
            // 
            // user_alreadyRegistered
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 261);
            this.Controls.Add(this.back_bttn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registerComplaint_bttn);
            this.Name = "user_alreadyRegistered";
            this.Text = "User Already Registered";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button registerComplaint_bttn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_bttn;
    }
}