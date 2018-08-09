namespace E_Tolling_System
{
    partial class Register_New_TollGate
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
            this.highwayName_comboBox = new System.Windows.Forms.ComboBox();
            this.logout_Bttn = new System.Windows.Forms.Button();
            this.cancel_Bttn = new System.Windows.Forms.Button();
            this.submit_Bttn = new System.Windows.Forms.Button();
            this.tollgateName_txtBox = new System.Windows.Forms.TextBox();
            this.Tollgate_txtBox = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // highwayName_comboBox
            // 
            this.highwayName_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.highwayName_comboBox.FormattingEnabled = true;
            this.highwayName_comboBox.Items.AddRange(new object[] {
            "Beitbridge",
            "Chirundu",
            "Bulawayo",
            "Mutare"});
            this.highwayName_comboBox.Location = new System.Drawing.Point(180, 136);
            this.highwayName_comboBox.Name = "highwayName_comboBox";
            this.highwayName_comboBox.Size = new System.Drawing.Size(121, 21);
            this.highwayName_comboBox.TabIndex = 20;
            // 
            // logout_Bttn
            // 
            this.logout_Bttn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_Bttn.Location = new System.Drawing.Point(242, 220);
            this.logout_Bttn.Name = "logout_Bttn";
            this.logout_Bttn.Size = new System.Drawing.Size(75, 37);
            this.logout_Bttn.TabIndex = 19;
            this.logout_Bttn.Text = "Logout";
            this.logout_Bttn.UseVisualStyleBackColor = true;
            this.logout_Bttn.Click += new System.EventHandler(this.logout_Bttn_Click);
            // 
            // cancel_Bttn
            // 
            this.cancel_Bttn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_Bttn.Location = new System.Drawing.Point(124, 220);
            this.cancel_Bttn.Name = "cancel_Bttn";
            this.cancel_Bttn.Size = new System.Drawing.Size(75, 37);
            this.cancel_Bttn.TabIndex = 18;
            this.cancel_Bttn.Text = "Back";
            this.cancel_Bttn.UseVisualStyleBackColor = true;
            this.cancel_Bttn.Click += new System.EventHandler(this.cancel_Bttn_Click);
            // 
            // submit_Bttn
            // 
            this.submit_Bttn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_Bttn.Location = new System.Drawing.Point(12, 220);
            this.submit_Bttn.Name = "submit_Bttn";
            this.submit_Bttn.Size = new System.Drawing.Size(75, 37);
            this.submit_Bttn.TabIndex = 17;
            this.submit_Bttn.Text = "Submit";
            this.submit_Bttn.UseVisualStyleBackColor = true;
            this.submit_Bttn.Click += new System.EventHandler(this.submit_Bttn_Click);
            // 
            // tollgateName_txtBox
            // 
            this.tollgateName_txtBox.Location = new System.Drawing.Point(180, 96);
            this.tollgateName_txtBox.Name = "tollgateName_txtBox";
            this.tollgateName_txtBox.Size = new System.Drawing.Size(121, 20);
            this.tollgateName_txtBox.TabIndex = 16;
            // 
            // Tollgate_txtBox
            // 
            this.Tollgate_txtBox.Location = new System.Drawing.Point(180, 51);
            this.Tollgate_txtBox.Name = "Tollgate_txtBox";
            this.Tollgate_txtBox.Size = new System.Drawing.Size(121, 20);
            this.Tollgate_txtBox.TabIndex = 15;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(12, 139);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(77, 13);
            this.Label4.TabIndex = 14;
            this.Label4.Text = "Highway name";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(12, 96);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(76, 13);
            this.Label3.TabIndex = 13;
            this.Label3.Text = "Tollgate Name";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(12, 51);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(56, 13);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "TollgateID";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(59, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(258, 29);
            this.Label1.TabIndex = 11;
            this.Label1.Text = "Tollgate Registration";
            // 
            // Register_New_TollGate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 271);
            this.Controls.Add(this.highwayName_comboBox);
            this.Controls.Add(this.logout_Bttn);
            this.Controls.Add(this.cancel_Bttn);
            this.Controls.Add(this.submit_Bttn);
            this.Controls.Add(this.tollgateName_txtBox);
            this.Controls.Add(this.Tollgate_txtBox);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Register_New_TollGate";
            this.Text = "Register_New_TollGate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox highwayName_comboBox;
        internal System.Windows.Forms.Button logout_Bttn;
        internal System.Windows.Forms.Button cancel_Bttn;
        internal System.Windows.Forms.Button submit_Bttn;
        internal System.Windows.Forms.TextBox tollgateName_txtBox;
        internal System.Windows.Forms.TextBox Tollgate_txtBox;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}