namespace JIRAManagementSystem
{
    partial class Projects
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
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.textBoxProjectName = new System.Windows.Forms.TextBox();
            this.textBoxProjectId = new System.Windows.Forms.TextBox();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.labelDDate = new System.Windows.Forms.Label();
            this.labelSDate = new System.Windows.Forms.Label();
            this.labelProjecttName = new System.Windows.Forms.Label();
            this.labelProjectId = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBoxPrDescription = new System.Windows.Forms.RichTextBox();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDue = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(246, 329);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.Size = new System.Drawing.Size(532, 109);
            this.dataGridViewEmployees.TabIndex = 49;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(642, 300);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 48;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(531, 300);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 47;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(413, 300);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 46;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(296, 300);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 45;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(657, 160);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDepartment.TabIndex = 44;
            // 
            // textBoxProjectName
            // 
            this.textBoxProjectName.Location = new System.Drawing.Point(345, 142);
            this.textBoxProjectName.Name = "textBoxProjectName";
            this.textBoxProjectName.Size = new System.Drawing.Size(203, 20);
            this.textBoxProjectName.TabIndex = 39;
            // 
            // textBoxProjectId
            // 
            this.textBoxProjectId.Location = new System.Drawing.Point(345, 116);
            this.textBoxProjectId.Name = "textBoxProjectId";
            this.textBoxProjectId.Size = new System.Drawing.Size(46, 20);
            this.textBoxProjectId.TabIndex = 38;
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.ForeColor = System.Drawing.Color.White;
            this.labelDepartment.Location = new System.Drawing.Point(572, 168);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(62, 13);
            this.labelDepartment.TabIndex = 37;
            this.labelDepartment.Text = "Department";
            // 
            // labelDDate
            // 
            this.labelDDate.AutoSize = true;
            this.labelDDate.ForeColor = System.Drawing.Color.White;
            this.labelDDate.Location = new System.Drawing.Point(243, 274);
            this.labelDDate.Name = "labelDDate";
            this.labelDDate.Size = new System.Drawing.Size(53, 13);
            this.labelDDate.TabIndex = 35;
            this.labelDDate.Text = "Due Date";
            // 
            // labelSDate
            // 
            this.labelSDate.AutoSize = true;
            this.labelSDate.ForeColor = System.Drawing.Color.White;
            this.labelSDate.Location = new System.Drawing.Point(243, 246);
            this.labelSDate.Name = "labelSDate";
            this.labelSDate.Size = new System.Drawing.Size(55, 13);
            this.labelSDate.TabIndex = 34;
            this.labelSDate.Text = "Start Date";
            // 
            // labelProjecttName
            // 
            this.labelProjecttName.AutoSize = true;
            this.labelProjecttName.ForeColor = System.Drawing.Color.White;
            this.labelProjecttName.Location = new System.Drawing.Point(243, 150);
            this.labelProjecttName.Name = "labelProjecttName";
            this.labelProjecttName.Size = new System.Drawing.Size(71, 13);
            this.labelProjecttName.TabIndex = 32;
            this.labelProjecttName.Text = "Project Name";
            // 
            // labelProjectId
            // 
            this.labelProjectId.AutoSize = true;
            this.labelProjectId.ForeColor = System.Drawing.Color.White;
            this.labelProjectId.Location = new System.Drawing.Point(243, 119);
            this.labelProjectId.Name = "labelProjectId";
            this.labelProjectId.Size = new System.Drawing.Size(54, 13);
            this.labelProjectId.TabIndex = 30;
            this.labelProjectId.Text = "Project ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(319, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(354, 33);
            this.label6.TabIndex = 31;
            this.label6.Text = "Project Management System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(245)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 450);
            this.panel1.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Logout";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Activities";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Projects";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employees";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(243, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Project Description";
            // 
            // richTextBoxPrDescription
            // 
            this.richTextBoxPrDescription.Location = new System.Drawing.Point(345, 180);
            this.richTextBoxPrDescription.Name = "richTextBoxPrDescription";
            this.richTextBoxPrDescription.Size = new System.Drawing.Size(203, 42);
            this.richTextBoxPrDescription.TabIndex = 51;
            this.richTextBoxPrDescription.Text = "";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(340, 242);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(191, 20);
            this.dateTimePickerStart.TabIndex = 52;
            // 
            // dateTimePickerDue
            // 
            this.dateTimePickerDue.Location = new System.Drawing.Point(340, 267);
            this.dateTimePickerDue.Name = "dateTimePickerDue";
            this.dateTimePickerDue.Size = new System.Drawing.Size(191, 20);
            this.dateTimePickerDue.TabIndex = 53;
            // 
            // Projects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePickerDue);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.richTextBoxPrDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.textBoxProjectName);
            this.Controls.Add(this.textBoxProjectId);
            this.Controls.Add(this.labelDepartment);
            this.Controls.Add(this.labelDDate);
            this.Controls.Add(this.labelSDate);
            this.Controls.Add(this.labelProjecttName);
            this.Controls.Add(this.labelProjectId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Name = "Projects";
            this.Text = "Projects";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.TextBox textBoxProjectName;
        private System.Windows.Forms.TextBox textBoxProjectId;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.Label labelDDate;
        private System.Windows.Forms.Label labelSDate;
        private System.Windows.Forms.Label labelProjecttName;
        private System.Windows.Forms.Label labelProjectId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBoxPrDescription;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerDue;
    }
}