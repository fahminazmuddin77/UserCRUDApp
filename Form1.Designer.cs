namespace UserCRUDApp
{
    partial class lab
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.labelHutang = new System.Windows.Forms.Label();
            this.txtHutang = new System.Windows.Forms.TextBox();
            this.labelNetWorth = new System.Windows.Forms.Label();
            this.txtNetWorth = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(63, 21);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(63, 61);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 1;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(9, 27);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(20, 16);
            this.labelId.TabIndex = 3;
            this.labelId.Text = "ID";
            this.labelId.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(9, 64);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 16);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(347, 231);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(103, 23);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load Data";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(347, 45);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 23);
            this.btnGet.TabIndex = 7;
            this.btnGet.Text = "Get by ID";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(12, 231);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(121, 231);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(234, 231);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(63, 279);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(610, 159);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelSaldo
            // 
            this.labelSaldo.AutoSize = true;
            this.labelSaldo.Location = new System.Drawing.Point(9, 103);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(43, 16);
            this.labelSaldo.TabIndex = 12;
            this.labelSaldo.Text = "Saldo";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(63, 103);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(100, 22);
            this.txtSaldo.TabIndex = 13;
            this.txtSaldo.TextChanged += new System.EventHandler(this.txtSaldo_TextChanged);
            // 
            // labelHutang
            // 
            this.labelHutang.AutoSize = true;
            this.labelHutang.Location = new System.Drawing.Point(3, 146);
            this.labelHutang.Name = "labelHutang";
            this.labelHutang.Size = new System.Drawing.Size(50, 16);
            this.labelHutang.TabIndex = 14;
            this.labelHutang.Text = "Hutang";
            // 
            // txtHutang
            // 
            this.txtHutang.Location = new System.Drawing.Point(63, 146);
            this.txtHutang.Name = "txtHutang";
            this.txtHutang.Size = new System.Drawing.Size(100, 22);
            this.txtHutang.TabIndex = 15;
            this.txtHutang.TextChanged += new System.EventHandler(this.txtHutang_TextChanged);
            // 
            // labelNetWorth
            // 
            this.labelNetWorth.AutoSize = true;
            this.labelNetWorth.Location = new System.Drawing.Point(191, 146);
            this.labelNetWorth.Name = "labelNetWorth";
            this.labelNetWorth.Size = new System.Drawing.Size(63, 16);
            this.labelNetWorth.TabIndex = 16;
            this.labelNetWorth.Text = "NetWorth";
            // 
            // txtNetWorth
            // 
            this.txtNetWorth.Enabled = false;
            this.txtNetWorth.Location = new System.Drawing.Point(260, 146);
            this.txtNetWorth.Name = "txtNetWorth";
            this.txtNetWorth.Size = new System.Drawing.Size(100, 22);
            this.txtNetWorth.TabIndex = 17;
            // 
            // lab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNetWorth);
            this.Controls.Add(this.labelNetWorth);
            this.Controls.Add(this.txtHutang);
            this.Controls.Add(this.labelHutang);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.labelSaldo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Name = "lab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User CRUD API";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelSaldo;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label labelHutang;
        private System.Windows.Forms.TextBox txtHutang;
        private System.Windows.Forms.Label labelNetWorth;
        private System.Windows.Forms.TextBox txtNetWorth;
    }
}

