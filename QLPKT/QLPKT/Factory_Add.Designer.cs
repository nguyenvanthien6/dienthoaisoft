namespace QLPKT
{
    partial class Factory_Add
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
            this.components = new System.ComponentModel.Container();
            this.InfoBox = new System.Windows.Forms.GroupBox();
            this.id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.namebox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttom_add1 = new System.Windows.Forms.Button();
            this.buttom_clear1 = new System.Windows.Forms.Button();
            this.InfoBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // InfoBox
            // 
            this.InfoBox.Controls.Add(this.id);
            this.InfoBox.Controls.Add(this.label9);
            this.InfoBox.Controls.Add(this.add);
            this.InfoBox.Controls.Add(this.email);
            this.InfoBox.Controls.Add(this.phone);
            this.InfoBox.Controls.Add(this.namebox);
            this.InfoBox.Controls.Add(this.label5);
            this.InfoBox.Controls.Add(this.label4);
            this.InfoBox.Controls.Add(this.label3);
            this.InfoBox.Controls.Add(this.label1);
            this.InfoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoBox.ForeColor = System.Drawing.Color.Red;
            this.InfoBox.Location = new System.Drawing.Point(22, 12);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.Size = new System.Drawing.Size(791, 129);
            this.InfoBox.TabIndex = 14;
            this.InfoBox.TabStop = false;
            this.InfoBox.Text = "Infomation";
            // 
            // id
            // 
            this.id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id.Enabled = false;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(494, 54);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(59, 22);
            this.id.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(392, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 16);
            this.label9.TabIndex = 31;
            this.label9.Text = "ID:";
            // 
            // add
            // 
            this.add.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(494, 17);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(262, 22);
            this.add.TabIndex = 41;
            this.add.TextChanged += new System.EventHandler(this.add_TextChanged);
            // 
            // email
            // 
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(96, 89);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(251, 22);
            this.email.TabIndex = 39;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // phone
            // 
            this.phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(96, 54);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(251, 22);
            this.phone.TabIndex = 38;
            this.phone.TextChanged += new System.EventHandler(this.phone_TextChanged);
            // 
            // namebox
            // 
            this.namebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.namebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namebox.Location = new System.Drawing.Point(96, 19);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(251, 22);
            this.namebox.TabIndex = 37;
            this.namebox.TextChanged += new System.EventHandler(this.namebox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(392, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(18, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(18, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Phone:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Name:";
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(350, 163);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 15);
            this.error.TabIndex = 58;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // buttom_add1
            // 
            this.buttom_add1.Location = new System.Drawing.Point(294, 179);
            this.buttom_add1.Name = "buttom_add1";
            this.buttom_add1.Size = new System.Drawing.Size(75, 23);
            this.buttom_add1.TabIndex = 59;
            this.buttom_add1.Text = "Thêm";
            this.buttom_add1.UseVisualStyleBackColor = true;
            this.buttom_add1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttom_clear1
            // 
            this.buttom_clear1.Location = new System.Drawing.Point(392, 179);
            this.buttom_clear1.Name = "buttom_clear1";
            this.buttom_clear1.Size = new System.Drawing.Size(75, 23);
            this.buttom_clear1.TabIndex = 60;
            this.buttom_clear1.Text = "Xóa";
            this.buttom_clear1.UseVisualStyleBackColor = true;
            this.buttom_clear1.Click += new System.EventHandler(this.buttom_clear1_Click);
            // 
            // Factory_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 482);
            this.Controls.Add(this.buttom_clear1);
            this.Controls.Add(this.buttom_add1);
            this.Controls.Add(this.error);
            this.Controls.Add(this.InfoBox);
            this.Name = "Factory_Add";
            this.Text = "Factory_Add";
            this.Load += new System.EventHandler(this.Factory_Add_Load);
            this.InfoBox.ResumeLayout(false);
            this.InfoBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox InfoBox;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox add;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button buttom_clear1;
        private System.Windows.Forms.Button buttom_add1;
    }
}