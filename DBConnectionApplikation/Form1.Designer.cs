namespace DBConnectionApplikation
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtSibling = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gridOutput = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gridAgeOutput = new System.Windows.Forms.DataGridView();
            this.txtAge2 = new System.Windows.Forms.TextBox();
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Birthday = new System.Windows.Forms.Label();
            this.buttonAddtoPerson = new System.Windows.Forms.Button();
            this.gridSiblingOutput = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFunFact = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSiblingName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSiblingAge = new System.Windows.Forms.TextBox();
            this.buttonAddtoPerson2 = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.selectAgeButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNumber3 = new System.Windows.Forms.TextBox();
            this.selectSiblingButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAgeOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSiblingOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(156, 55);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(322, 35);
            this.txtName.TabIndex = 0;
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(156, 108);
            this.txtAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(322, 35);
            this.txtAge.TabIndex = 0;
            // 
            // txtSibling
            // 
            this.txtSibling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSibling.Location = new System.Drawing.Point(156, 169);
            this.txtSibling.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSibling.Name = "txtSibling";
            this.txtSibling.Size = new System.Drawing.Size(322, 35);
            this.txtSibling.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sibling:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(41, 276);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 101);
            this.button1.TabIndex = 2;
            this.button1.Text = "INSERT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(252, 276);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 101);
            this.button2.TabIndex = 4;
            this.button2.Text = "SELECT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gridOutput
            // 
            this.gridOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOutput.Location = new System.Drawing.Point(41, 408);
            this.gridOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridOutput.Name = "gridOutput";
            this.gridOutput.RowHeadersWidth = 51;
            this.gridOutput.RowTemplate.Height = 24;
            this.gridOutput.Size = new System.Drawing.Size(659, 340);
            this.gridOutput.TabIndex = 5;
            this.gridOutput.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridOutput_CellClick);
            this.gridOutput.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridOutput_CellContentClick);
            this.gridOutput.SelectionChanged += new System.EventHandler(this.gridOutput_SelectionChanged);
            this.gridOutput.Click += new System.EventHandler(this.gridOutput_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(252, 756);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(192, 101);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(450, 276);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(204, 101);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search NAME";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gridAgeOutput
            // 
            this.gridAgeOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAgeOutput.Location = new System.Drawing.Point(722, 408);
            this.gridAgeOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridAgeOutput.Name = "gridAgeOutput";
            this.gridAgeOutput.RowHeadersWidth = 51;
            this.gridAgeOutput.RowTemplate.Height = 24;
            this.gridAgeOutput.Size = new System.Drawing.Size(414, 340);
            this.gridAgeOutput.TabIndex = 5;
            this.gridAgeOutput.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAgeOutput_Click);
            // 
            // txtAge2
            // 
            this.txtAge2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge2.Location = new System.Drawing.Point(790, 140);
            this.txtAge2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAge2.Name = "txtAge2";
            this.txtAge2.Size = new System.Drawing.Size(322, 35);
            this.txtAge2.TabIndex = 0;
            // 
            // txtBirthday
            // 
            this.txtBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBirthday.Location = new System.Drawing.Point(790, 202);
            this.txtBirthday.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(322, 35);
            this.txtBirthday.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(714, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Age:";
            // 
            // Birthday
            // 
            this.Birthday.AutoSize = true;
            this.Birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Birthday.Location = new System.Drawing.Point(684, 202);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(106, 29);
            this.Birthday.TabIndex = 1;
            this.Birthday.Text = "Birthday:";
            // 
            // buttonAddtoPerson
            // 
            this.buttonAddtoPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddtoPerson.Location = new System.Drawing.Point(932, 276);
            this.buttonAddtoPerson.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddtoPerson.Name = "buttonAddtoPerson";
            this.buttonAddtoPerson.Size = new System.Drawing.Size(204, 101);
            this.buttonAddtoPerson.TabIndex = 2;
            this.buttonAddtoPerson.Text = "Add to current Person";
            this.buttonAddtoPerson.UseVisualStyleBackColor = true;
            this.buttonAddtoPerson.Click += new System.EventHandler(this.buttonAddtoPerson_Click);
            // 
            // gridSiblingOutput
            // 
            this.gridSiblingOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSiblingOutput.Location = new System.Drawing.Point(1160, 408);
            this.gridSiblingOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridSiblingOutput.Name = "gridSiblingOutput";
            this.gridSiblingOutput.RowHeadersWidth = 51;
            this.gridSiblingOutput.RowTemplate.Height = 24;
            this.gridSiblingOutput.Size = new System.Drawing.Size(522, 340);
            this.gridSiblingOutput.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fun fact:";
            // 
            // txtFunFact
            // 
            this.txtFunFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFunFact.Location = new System.Drawing.Point(156, 221);
            this.txtFunFact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFunFact.Name = "txtFunFact";
            this.txtFunFact.Size = new System.Drawing.Size(322, 35);
            this.txtFunFact.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1159, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sibling name:";
            // 
            // txtSiblingName
            // 
            this.txtSiblingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSiblingName.Location = new System.Drawing.Point(1325, 140);
            this.txtSiblingName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSiblingName.Name = "txtSiblingName";
            this.txtSiblingName.Size = new System.Drawing.Size(322, 35);
            this.txtSiblingName.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1178, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Sibling age:";
            // 
            // txtSiblingAge
            // 
            this.txtSiblingAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSiblingAge.Location = new System.Drawing.Point(1325, 202);
            this.txtSiblingAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSiblingAge.Name = "txtSiblingAge";
            this.txtSiblingAge.Size = new System.Drawing.Size(322, 35);
            this.txtSiblingAge.TabIndex = 12;
            // 
            // buttonAddtoPerson2
            // 
            this.buttonAddtoPerson2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddtoPerson2.Location = new System.Drawing.Point(1443, 276);
            this.buttonAddtoPerson2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddtoPerson2.Name = "buttonAddtoPerson2";
            this.buttonAddtoPerson2.Size = new System.Drawing.Size(204, 101);
            this.buttonAddtoPerson2.TabIndex = 14;
            this.buttonAddtoPerson2.Text = "Add sibling to current Person";
            this.buttonAddtoPerson2.UseVisualStyleBackColor = true;
            this.buttonAddtoPerson2.Click += new System.EventHandler(this.buttonAddtoPerson2_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(156, 12);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(322, 35);
            this.txtNumber.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(117, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 29);
            this.label8.TabIndex = 16;
            this.label8.Text = "Id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(484, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Must be unique";
            // 
            // selectAgeButton
            // 
            this.selectAgeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectAgeButton.Location = new System.Drawing.Point(722, 276);
            this.selectAgeButton.Name = "selectAgeButton";
            this.selectAgeButton.Size = new System.Drawing.Size(204, 101);
            this.selectAgeButton.TabIndex = 18;
            this.selectAgeButton.Text = "SELECT";
            this.selectAgeButton.UseVisualStyleBackColor = true;
            this.selectAgeButton.Click += new System.EventHandler(this.selectAgeButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(751, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 29);
            this.label11.TabIndex = 20;
            this.label11.Text = "Id";
            // 
            // txtNumber2
            // 
            this.txtNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber2.Location = new System.Drawing.Point(790, 88);
            this.txtNumber2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(322, 35);
            this.txtNumber2.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1286, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 29);
            this.label13.TabIndex = 23;
            this.label13.Text = "Id";
            // 
            // txtNumber3
            // 
            this.txtNumber3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber3.Location = new System.Drawing.Point(1325, 91);
            this.txtNumber3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumber3.Name = "txtNumber3";
            this.txtNumber3.Size = new System.Drawing.Size(322, 35);
            this.txtNumber3.TabIndex = 22;
            // 
            // selectSiblingButton
            // 
            this.selectSiblingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectSiblingButton.Location = new System.Drawing.Point(1233, 276);
            this.selectSiblingButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.selectSiblingButton.Name = "selectSiblingButton";
            this.selectSiblingButton.Size = new System.Drawing.Size(204, 101);
            this.selectSiblingButton.TabIndex = 24;
            this.selectSiblingButton.Text = "SELECT";
            this.selectSiblingButton.UseVisualStyleBackColor = true;
            this.selectSiblingButton.Click += new System.EventHandler(this.selectSiblingButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1694, 908);
            this.Controls.Add(this.selectSiblingButton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtNumber3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.selectAgeButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.buttonAddtoPerson2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSiblingAge);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSiblingName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFunFact);
            this.Controls.Add(this.gridSiblingOutput);
            this.Controls.Add(this.gridAgeOutput);
            this.Controls.Add(this.gridOutput);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.buttonAddtoPerson);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Birthday);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSibling);
            this.Controls.Add(this.txtBirthday);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtAge2);
            this.Controls.Add(this.txtName);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAgeOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSiblingOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtSibling;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView gridOutput;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView gridAgeOutput;
        private System.Windows.Forms.TextBox txtAge2;
        private System.Windows.Forms.TextBox txtBirthday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Birthday;
        private System.Windows.Forms.Button buttonAddtoPerson;
        private System.Windows.Forms.DataGridView gridSiblingOutput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFunFact;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSiblingName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSiblingAge;
        private System.Windows.Forms.Button buttonAddtoPerson2;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button selectAgeButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNumber3;
        private System.Windows.Forms.Button selectSiblingButton;
    }
}

