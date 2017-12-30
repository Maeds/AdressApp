namespace AdressBokProjektet
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
            this.formFirstName = new System.Windows.Forms.TextBox();
            this.formLastName = new System.Windows.Forms.TextBox();
            this.Firstname = new System.Windows.Forms.Label();
            this.Lastname = new System.Windows.Forms.Label();
            this.Adress = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.formAdress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // formFirstName
            // 
            this.formFirstName.Location = new System.Drawing.Point(54, 49);
            this.formFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.formFirstName.Name = "formFirstName";
            this.formFirstName.Size = new System.Drawing.Size(211, 26);
            this.formFirstName.TabIndex = 1;
            this.formFirstName.TextChanged += new System.EventHandler(this.formFirstName_TextChanged);
            // 
            // formLastName
            // 
            this.formLastName.Location = new System.Drawing.Point(54, 118);
            this.formLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.formLastName.Name = "formLastName";
            this.formLastName.Size = new System.Drawing.Size(211, 26);
            this.formLastName.TabIndex = 2;
            this.formLastName.TextChanged += new System.EventHandler(this.formLastName_TextChanged);
            // 
            // Firstname
            // 
            this.Firstname.AutoSize = true;
            this.Firstname.Location = new System.Drawing.Point(50, 25);
            this.Firstname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(84, 20);
            this.Firstname.TabIndex = 3;
            this.Firstname.Text = "First name";
            // 
            // Lastname
            // 
            this.Lastname.AutoSize = true;
            this.Lastname.Location = new System.Drawing.Point(50, 94);
            this.Lastname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(84, 20);
            this.Lastname.TabIndex = 4;
            this.Lastname.Text = "Last name";
            // 
            // Adress
            // 
            this.Adress.AutoSize = true;
            this.Adress.Location = new System.Drawing.Point(50, 169);
            this.Adress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(59, 20);
            this.Adress.TabIndex = 6;
            this.Adress.Text = "Adress";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(54, 245);
            this.Add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(165, 40);
            this.Add.TabIndex = 8;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(54, 341);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(466, 122);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // formAdress
            // 
            this.formAdress.Location = new System.Drawing.Point(54, 192);
            this.formAdress.Name = "formAdress";
            this.formAdress.Size = new System.Drawing.Size(297, 26);
            this.formAdress.TabIndex = 10;
            this.formAdress.TextChanged += new System.EventHandler(this.formAdress_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 477);
            this.Controls.Add(this.formAdress);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Adress);
            this.Controls.Add(this.Lastname);
            this.Controls.Add(this.Firstname);
            this.Controls.Add(this.formLastName);
            this.Controls.Add(this.formFirstName);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox formFirstName;
        private System.Windows.Forms.TextBox formLastName;
        private System.Windows.Forms.Label Firstname;
        private System.Windows.Forms.Label Lastname;
        private System.Windows.Forms.Label Adress;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox formAdress;
    }
}

