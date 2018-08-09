namespace E_Tolling_System
{
    partial class register_compaint
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
            this.submit_bttn = new System.Windows.Forms.Button();
            this.tag_txtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.complaint_txtBox = new System.Windows.Forms.TextBox();
            this.dateofRegistration_Datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.back_bttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // submit_bttn
            // 
            this.submit_bttn.Location = new System.Drawing.Point(11, 215);
            this.submit_bttn.Name = "submit_bttn";
            this.submit_bttn.Size = new System.Drawing.Size(139, 39);
            this.submit_bttn.TabIndex = 0;
            this.submit_bttn.Text = "Submit";
            this.submit_bttn.UseVisualStyleBackColor = true;
            this.submit_bttn.Click += new System.EventHandler(this.submit_bttn_Click);
            // 
            // tag_txtBox
            // 
            this.tag_txtBox.Location = new System.Drawing.Point(116, 67);
            this.tag_txtBox.Name = "tag_txtBox";
            this.tag_txtBox.Size = new System.Drawing.Size(200, 20);
            this.tag_txtBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Date of Registation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tag Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Complaint Description";
            // 
            // complaint_txtBox
            // 
            this.complaint_txtBox.Location = new System.Drawing.Point(116, 110);
            this.complaint_txtBox.Multiline = true;
            this.complaint_txtBox.Name = "complaint_txtBox";
            this.complaint_txtBox.Size = new System.Drawing.Size(196, 99);
            this.complaint_txtBox.TabIndex = 6;
            // 
            // dateofRegistration_Datetimepicker
            // 
            this.dateofRegistration_Datetimepicker.Location = new System.Drawing.Point(117, 24);
            this.dateofRegistration_Datetimepicker.Name = "dateofRegistration_Datetimepicker";
            this.dateofRegistration_Datetimepicker.Size = new System.Drawing.Size(200, 20);
            this.dateofRegistration_Datetimepicker.TabIndex = 7;
            // 
            // back_bttn
            // 
            this.back_bttn.Location = new System.Drawing.Point(173, 215);
            this.back_bttn.Name = "back_bttn";
            this.back_bttn.Size = new System.Drawing.Size(139, 39);
            this.back_bttn.TabIndex = 8;
            this.back_bttn.Text = "BACK";
            this.back_bttn.UseVisualStyleBackColor = true;
            this.back_bttn.Click += new System.EventHandler(this.back_bttn_Click);
            // 
            // register_compaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 261);
            this.Controls.Add(this.back_bttn);
            this.Controls.Add(this.dateofRegistration_Datetimepicker);
            this.Controls.Add(this.complaint_txtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tag_txtBox);
            this.Controls.Add(this.submit_bttn);
            this.Name = "register_compaint";
            this.Text = "register_compaint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit_bttn;
        private System.Windows.Forms.TextBox tag_txtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox complaint_txtBox;
        private System.Windows.Forms.DateTimePicker dateofRegistration_Datetimepicker;
        private System.Windows.Forms.Button back_bttn;
    }
}