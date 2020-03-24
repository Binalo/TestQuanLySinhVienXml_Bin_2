namespace TestQuanLySinhVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.Label();
            this.av = new System.Windows.Forms.Label();
            this.ac = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.DataGridView();
            this.sinhvienprkid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinhvienid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinhvienname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinhvienaddr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinhvienemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinhvienphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPrkId = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddr = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnDoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "SinhVienID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "SinhVienPrkID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "SinhVienName";
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A.Location = new System.Drawing.Point(43, 493);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(122, 20);
            this.A.TabIndex = 3;
            this.A.Text = "SinhVienAddr";
            // 
            // av
            // 
            this.av.AutoSize = true;
            this.av.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.av.Location = new System.Drawing.Point(43, 535);
            this.av.Name = "av";
            this.av.Size = new System.Drawing.Size(130, 20);
            this.av.TabIndex = 4;
            this.av.Text = "SinhVienEmail";
            // 
            // ac
            // 
            this.ac.AutoSize = true;
            this.ac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ac.Location = new System.Drawing.Point(43, 575);
            this.ac.Name = "ac";
            this.ac.Size = new System.Drawing.Size(135, 20);
            this.ac.TabIndex = 5;
            this.ac.Text = "SinhVienPhone";
            // 
            // listView1
            // 
            this.listView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sinhvienprkid,
            this.sinhvienid,
            this.sinhvienname,
            this.sinhvienaddr,
            this.sinhvienemail,
            this.sinhvienphone});
            this.listView1.Location = new System.Drawing.Point(46, 53);
            this.listView1.Name = "listView1";
            this.listView1.RowHeadersWidth = 51;
            this.listView1.RowTemplate.Height = 24;
            this.listView1.Size = new System.Drawing.Size(1117, 284);
            this.listView1.TabIndex = 6;
            this.listView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListView_CellClick);
            // 
            // sinhvienprkid
            // 
            this.sinhvienprkid.HeaderText = "SinhVienPrkID";
            this.sinhvienprkid.MinimumWidth = 6;
            this.sinhvienprkid.Name = "sinhvienprkid";
            this.sinhvienprkid.Width = 125;
            // 
            // sinhvienid
            // 
            this.sinhvienid.HeaderText = "SinhVienID";
            this.sinhvienid.MinimumWidth = 6;
            this.sinhvienid.Name = "sinhvienid";
            this.sinhvienid.Width = 125;
            // 
            // sinhvienname
            // 
            this.sinhvienname.HeaderText = "SinhVienName";
            this.sinhvienname.MinimumWidth = 6;
            this.sinhvienname.Name = "sinhvienname";
            this.sinhvienname.Width = 165;
            // 
            // sinhvienaddr
            // 
            this.sinhvienaddr.HeaderText = "SinhVienAddr";
            this.sinhvienaddr.MinimumWidth = 6;
            this.sinhvienaddr.Name = "sinhvienaddr";
            this.sinhvienaddr.Width = 140;
            // 
            // sinhvienemail
            // 
            this.sinhvienemail.HeaderText = "SinhVienEmail";
            this.sinhvienemail.MinimumWidth = 6;
            this.sinhvienemail.Name = "sinhvienemail";
            this.sinhvienemail.Width = 140;
            // 
            // sinhvienphone
            // 
            this.sinhvienphone.HeaderText = "SinhVienPhone";
            this.sinhvienphone.MinimumWidth = 6;
            this.sinhvienphone.Name = "sinhvienphone";
            this.sinhvienphone.Width = 140;
            // 
            // txtPrkId
            // 
            this.txtPrkId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrkId.Location = new System.Drawing.Point(201, 363);
            this.txtPrkId.Name = "txtPrkId";
            this.txtPrkId.Size = new System.Drawing.Size(616, 27);
            this.txtPrkId.TabIndex = 7;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(201, 400);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(616, 27);
            this.txtId.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(201, 450);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(616, 27);
            this.txtName.TabIndex = 9;
            // 
            // txtAddr
            // 
            this.txtAddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddr.Location = new System.Drawing.Point(201, 490);
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(616, 27);
            this.txtAddr.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(201, 530);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(616, 27);
            this.txtEmail.TabIndex = 11;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(201, 571);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(616, 27);
            this.txtPhone.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(968, 370);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 39);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(968, 433);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(104, 39);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(968, 490);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(104, 39);
            this.btnDel.TabIndex = 15;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1059, 559);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 39);
            this.button4.TabIndex = 16;
            this.button4.Text = "Đóng";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnDoc
            // 
            this.btnDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoc.Location = new System.Drawing.Point(885, 556);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Size = new System.Drawing.Size(104, 39);
            this.btnDoc.TabIndex = 17;
            this.btnDoc.Text = "Load File";
            this.btnDoc.UseVisualStyleBackColor = true;
            this.btnDoc.Click += new System.EventHandler(this.btnDoc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 644);
            this.Controls.Add(this.btnDoc);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAddr);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtPrkId);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ac);
            this.Controls.Add(this.av);
            this.Controls.Add(this.A);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.listView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.Label av;
        private System.Windows.Forms.Label ac;
        private System.Windows.Forms.DataGridView listView1;
        private System.Windows.Forms.TextBox txtPrkId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddr;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinhvienprkid;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinhvienid;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinhvienname;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinhvienaddr;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinhvienemail;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinhvienphone;
    }
}

