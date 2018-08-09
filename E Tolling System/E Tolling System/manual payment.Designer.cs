namespace E_Tolling_System
{
    partial class Cashier_Box
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
            this.label1 = new System.Windows.Forms.Label();
            this.back_bttn = new System.Windows.Forms.Button();
            this.print_bttn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numberPlate_txtBox = new System.Windows.Forms.TextBox();
            this.enterAmount_txtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.print_richTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter NumberPlate";
            // 
            // back_bttn
            // 
            this.back_bttn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_bttn.Location = new System.Drawing.Point(218, 265);
            this.back_bttn.Name = "back_bttn";
            this.back_bttn.Size = new System.Drawing.Size(80, 38);
            this.back_bttn.TabIndex = 2;
            this.back_bttn.Text = "LogOut";
            this.back_bttn.UseVisualStyleBackColor = true;
            this.back_bttn.Click += new System.EventHandler(this.button2_Click);
            // 
            // print_bttn
            // 
            this.print_bttn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print_bttn.Location = new System.Drawing.Point(78, 265);
            this.print_bttn.Name = "print_bttn";
            this.print_bttn.Size = new System.Drawing.Size(80, 38);
            this.print_bttn.TabIndex = 3;
            this.print_bttn.Text = "PRINT";
            this.print_bttn.UseVisualStyleBackColor = true;
            this.print_bttn.Click += new System.EventHandler(this.print_bttn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter AmountPaid";
            // 
            // numberPlate_txtBox
            // 
            this.numberPlate_txtBox.Location = new System.Drawing.Point(151, 58);
            this.numberPlate_txtBox.Name = "numberPlate_txtBox";
            this.numberPlate_txtBox.Size = new System.Drawing.Size(100, 20);
            this.numberPlate_txtBox.TabIndex = 7;
            // 
            // enterAmount_txtBox
            // 
            this.enterAmount_txtBox.Location = new System.Drawing.Point(151, 97);
            this.enterAmount_txtBox.Name = "enterAmount_txtBox";
            this.enterAmount_txtBox.Size = new System.Drawing.Size(100, 20);
            this.enterAmount_txtBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Adobe Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(95, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "manual toll payment";
            // 
            // print_richTextBox
            // 
            this.print_richTextBox.Enabled = false;
            this.print_richTextBox.Location = new System.Drawing.Point(78, 139);
            this.print_richTextBox.Name = "print_richTextBox";
            this.print_richTextBox.Size = new System.Drawing.Size(220, 96);
            this.print_richTextBox.TabIndex = 12;
            this.print_richTextBox.Text = "";
            // 
            // Cashier_Box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 315);
            this.Controls.Add(this.print_richTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.enterAmount_txtBox);
            this.Controls.Add(this.numberPlate_txtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.print_bttn);
            this.Controls.Add(this.back_bttn);
            this.Controls.Add(this.label1);
            this.Name = "Cashier_Box";
            this.Text = "Cashier Box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_bttn;
        private System.Windows.Forms.Button print_bttn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numberPlate_txtBox;
        private System.Windows.Forms.TextBox enterAmount_txtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox print_richTextBox;
    }
}