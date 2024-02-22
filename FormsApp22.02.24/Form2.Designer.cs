namespace FormsApp22._02._24
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.txtbAge = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPerson.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPerson.Location = new System.Drawing.Point(320, 118);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(232, 128);
            this.btnAddPerson.TabIndex = 0;
            this.btnAddPerson.Text = "Add person";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbName
            // 
            this.txtbName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtbName.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbName.Location = new System.Drawing.Point(34, 88);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(209, 45);
            this.txtbName.TabIndex = 1;
            // 
            // txtbAge
            // 
            this.txtbAge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtbAge.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbAge.Location = new System.Drawing.Point(37, 244);
            this.txtbAge.Name = "txtbAge";
            this.txtbAge.Size = new System.Drawing.Size(206, 45);
            this.txtbAge.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(27, 46);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(123, 38);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(27, 192);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(91, 38);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Age:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 383);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtbAge);
            this.Controls.Add(this.txtbName);
            this.Controls.Add(this.btnAddPerson);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Additional Person";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.TextBox txtbAge;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
    }
}