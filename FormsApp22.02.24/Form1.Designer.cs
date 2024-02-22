namespace FormsApp22._02._24
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnNewPerson = new System.Windows.Forms.Button();
            this.cmbChooseName = new System.Windows.Forms.ComboBox();
            this.txtbShowAge = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewPerson
            // 
            this.btnNewPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewPerson.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPerson.Location = new System.Drawing.Point(30, 338);
            this.btnNewPerson.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNewPerson.Name = "btnNewPerson";
            this.btnNewPerson.Size = new System.Drawing.Size(361, 117);
            this.btnNewPerson.TabIndex = 0;
            this.btnNewPerson.Text = "Add new person";
            this.btnNewPerson.UseVisualStyleBackColor = true;
            this.btnNewPerson.Click += new System.EventHandler(this.btnNewPerson_Click);
            // 
            // cmbChooseName
            // 
            this.cmbChooseName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbChooseName.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChooseName.FormattingEnabled = true;
            this.cmbChooseName.Location = new System.Drawing.Point(30, 102);
            this.cmbChooseName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbChooseName.Name = "cmbChooseName";
            this.cmbChooseName.Size = new System.Drawing.Size(361, 43);
            this.cmbChooseName.TabIndex = 1;
            this.cmbChooseName.SelectedIndexChanged += new System.EventHandler(this.cmbChooseName_SelectedIndexChanged);
            // 
            // txtbShowAge
            // 
            this.txtbShowAge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtbShowAge.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbShowAge.Location = new System.Drawing.Point(448, 103);
            this.txtbShowAge.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtbShowAge.Name = "txtbShowAge";
            this.txtbShowAge.Size = new System.Drawing.Size(218, 42);
            this.txtbShowAge.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(493, 188);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(173, 117);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(442, 61);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(82, 35);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Age:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(24, 61);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(111, 35);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name:";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(493, 338);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(173, 117);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 478);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtbShowAge);
            this.Controls.Add(this.cmbChooseName);
            this.Controls.Add(this.btnNewPerson);
            this.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Person\'s Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewPerson;
        private System.Windows.Forms.ComboBox cmbChooseName;
        private System.Windows.Forms.TextBox txtbShowAge;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnClose;
    }
}

