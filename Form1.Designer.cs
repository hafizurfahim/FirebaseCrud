namespace WindowsFormsApp1
{
    partial class Form1
    {
        private const string V = "Form1";

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.DepartmenttextBox5 = new System.Windows.Forms.TextBox();
            this.MobileNotextBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddresstextBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RegistrationtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobileNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentdataGridView = new System.Windows.Forms.DataGridView();
            this.Idlabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Deletebutton);
            this.groupBox1.Controls.Add(this.Save);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.DepartmenttextBox5);
            this.groupBox1.Controls.Add(this.MobileNotextBox4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.AddresstextBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.RegistrationtextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.NametextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-6, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 347);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Deletebutton
            // 
            this.Deletebutton.Enabled = false;
            this.Deletebutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Deletebutton.ForeColor = System.Drawing.Color.Red;
            this.Deletebutton.Location = new System.Drawing.Point(257, 287);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(94, 45);
            this.Deletebutton.TabIndex = 3;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Save.Location = new System.Drawing.Point(367, 287);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(94, 45);
            this.Save.TabIndex = 2;
            this.Save.Text = "Save";
            this.Save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Department";
            // 
            // DepartmenttextBox5
            // 
            this.DepartmenttextBox5.Location = new System.Drawing.Point(266, 237);
            this.DepartmenttextBox5.Name = "DepartmenttextBox5";
            this.DepartmenttextBox5.Size = new System.Drawing.Size(301, 27);
            this.DepartmenttextBox5.TabIndex = 1;
            // 
            // MobileNotextBox4
            // 
            this.MobileNotextBox4.Location = new System.Drawing.Point(266, 139);
            this.MobileNotextBox4.Name = "MobileNotextBox4";
            this.MobileNotextBox4.Size = new System.Drawing.Size(301, 27);
            this.MobileNotextBox4.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Address";
            // 
            // AddresstextBox3
            // 
            this.AddresstextBox3.Location = new System.Drawing.Point(266, 185);
            this.AddresstextBox3.Name = "AddresstextBox3";
            this.AddresstextBox3.Size = new System.Drawing.Size(301, 27);
            this.AddresstextBox3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mobile Number";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // RegistrationtextBox
            // 
            this.RegistrationtextBox.Location = new System.Drawing.Point(266, 84);
            this.RegistrationtextBox.Name = "RegistrationtextBox";
            this.RegistrationtextBox.Size = new System.Drawing.Size(301, 27);
            this.RegistrationtextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Registration No";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(266, 39);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(301, 27);
            this.NametextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Name
            // 
            this.Name.HeaderText = "Student Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Name.Width = 125;
            // 
            // RegistrationNO
            // 
            this.RegistrationNO.HeaderText = "Registration NO";
            this.RegistrationNO.MinimumWidth = 6;
            this.RegistrationNO.Name = "RegistrationNO";
            this.RegistrationNO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RegistrationNO.Width = 125;
            // 
            // MobileNo
            // 
            this.MobileNo.HeaderText = "Mobile No";
            this.MobileNo.MinimumWidth = 6;
            this.MobileNo.Name = "MobileNo";
            this.MobileNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MobileNo.Width = 125;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Address.Width = 125;
            // 
            // Department
            // 
            this.Department.HeaderText = "Department";
            this.Department.MinimumWidth = 6;
            this.Department.Name = "Department";
            this.Department.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Department.Width = 125;
            // 
            // StudentdataGridView
            // 
            this.StudentdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name,
            this.RegistrationNO,
            this.MobileNo,
            this.Address,
            this.Department});
            this.StudentdataGridView.Location = new System.Drawing.Point(12, 355);
            this.StudentdataGridView.Name = "StudentdataGridView";
            this.StudentdataGridView.RowHeadersWidth = 51;
            this.StudentdataGridView.Size = new System.Drawing.Size(1160, 294);
            this.StudentdataGridView.TabIndex = 1;
            this.StudentdataGridView.Text = "dataGridView2";
            this.StudentdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentdataGridView_CellContentClick);
            this.StudentdataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.StudentdataGridView_DoubleClick);
            this.StudentdataGridView.DoubleClick += new System.EventHandler(this.StudentdataGridView_DoubleClick_1);
            // 
            // Idlabel
            // 
            this.Idlabel.AutoSize = true;
            this.Idlabel.Location = new System.Drawing.Point(877, 124);
            this.Idlabel.Name = "Idlabel";
            this.Idlabel.Size = new System.Drawing.Size(50, 20);
            this.Idlabel.TabIndex = 2;
            this.Idlabel.Text = "label6";
            this.Idlabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1759, 937);
            this.Controls.Add(this.Idlabel);
            this.Controls.Add(this.StudentdataGridView);
            this.Controls.Add(this.groupBox1);
          //  this.Name = "Form1";
            this.Text = "Registration ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MobileNotextBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AddresstextBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RegistrationtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DepartmenttextBox5;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.DataGridView StudentdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MobileNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.Label Idlabel;
        private System.Windows.Forms.Button Deletebutton;
    }
}

