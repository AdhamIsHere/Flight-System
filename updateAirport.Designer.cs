namespace Flight_System
{
    partial class updateAirport
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nAMELabel;
            System.Windows.Forms.Label cOUNTRYLabel;
            System.Windows.Forms.Label cITYLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateAirport));
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOUNTRYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aIRPORTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tESTDataSet1 = new Flight_System.TESTDataSet1();
            this.aIRPORTTableAdapter = new Flight_System.TESTDataSet1TableAdapters.AIRPORTTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableAdapterManager = new Flight_System.TESTDataSet1TableAdapters.TableAdapterManager();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.nAMETextBox = new System.Windows.Forms.TextBox();
            this.cOUNTRYTextBox = new System.Windows.Forms.TextBox();
            this.cITYTextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            iDLabel = new System.Windows.Forms.Label();
            nAMELabel = new System.Windows.Forms.Label();
            cOUNTRYLabel = new System.Windows.Forms.Label();
            cITYLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRPORTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDLabel.Location = new System.Drawing.Point(200, 341);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(23, 16);
            iDLabel.TabIndex = 41;
            iDLabel.Text = "ID:";
            // 
            // nAMELabel
            // 
            nAMELabel.AutoSize = true;
            nAMELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nAMELabel.Location = new System.Drawing.Point(306, 341);
            nAMELabel.Name = "nAMELabel";
            nAMELabel.Size = new System.Drawing.Size(49, 16);
            nAMELabel.TabIndex = 43;
            nAMELabel.Text = "NAME:";
            // 
            // cOUNTRYLabel
            // 
            cOUNTRYLabel.AutoSize = true;
            cOUNTRYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cOUNTRYLabel.Location = new System.Drawing.Point(412, 341);
            cOUNTRYLabel.Name = "cOUNTRYLabel";
            cOUNTRYLabel.Size = new System.Drawing.Size(77, 16);
            cOUNTRYLabel.TabIndex = 45;
            cOUNTRYLabel.Text = "COUNTRY:";
            // 
            // cITYLabel
            // 
            cITYLabel.AutoSize = true;
            cITYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cITYLabel.Location = new System.Drawing.Point(518, 341);
            cITYLabel.Name = "cITYLabel";
            cITYLabel.Size = new System.Drawing.Size(40, 16);
            cITYLabel.TabIndex = 47;
            cITYLabel.Text = "CITY:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(287, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 58);
            this.label3.TabIndex = 37;
            this.label3.Text = "Update Airport";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.cOUNTRYDataGridViewTextBoxColumn,
            this.cITYDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aIRPORTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(192, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 165);
            this.dataGridView1.TabIndex = 38;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            // 
            // cOUNTRYDataGridViewTextBoxColumn
            // 
            this.cOUNTRYDataGridViewTextBoxColumn.DataPropertyName = "COUNTRY";
            this.cOUNTRYDataGridViewTextBoxColumn.HeaderText = "COUNTRY";
            this.cOUNTRYDataGridViewTextBoxColumn.Name = "cOUNTRYDataGridViewTextBoxColumn";
            // 
            // cITYDataGridViewTextBoxColumn
            // 
            this.cITYDataGridViewTextBoxColumn.DataPropertyName = "CITY";
            this.cITYDataGridViewTextBoxColumn.HeaderText = "CITY";
            this.cITYDataGridViewTextBoxColumn.Name = "cITYDataGridViewTextBoxColumn";
            // 
            // aIRPORTBindingSource
            // 
            this.aIRPORTBindingSource.DataMember = "AIRPORT";
            this.aIRPORTBindingSource.DataSource = this.tESTDataSet1;
            // 
            // tESTDataSet1
            // 
            this.tESTDataSet1.DataSetName = "TESTDataSet1";
            this.tESTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aIRPORTTableAdapter
            // 
            this.aIRPORTTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Azure;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(251, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 50);
            this.button1.TabIndex = 39;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Azure;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(404, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 50);
            this.button2.TabIndex = 40;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AIRCRAFTTableAdapter = null;
            this.tableAdapterManager.AIRPORTTableAdapter = this.aIRPORTTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FLIGHTTableAdapter = null;
            this.tableAdapterManager.RESERVATIONTableAdapter = null;
            this.tableAdapterManager.TICKETTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Flight_System.TESTDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERTableAdapter = null;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aIRPORTBindingSource, "ID", true));
            this.iDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDTextBox.Location = new System.Drawing.Point(203, 360);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 22);
            this.iDTextBox.TabIndex = 42;
            // 
            // nAMETextBox
            // 
            this.nAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aIRPORTBindingSource, "NAME", true));
            this.nAMETextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nAMETextBox.Location = new System.Drawing.Point(309, 360);
            this.nAMETextBox.Name = "nAMETextBox";
            this.nAMETextBox.Size = new System.Drawing.Size(100, 22);
            this.nAMETextBox.TabIndex = 44;
            // 
            // cOUNTRYTextBox
            // 
            this.cOUNTRYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aIRPORTBindingSource, "COUNTRY", true));
            this.cOUNTRYTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cOUNTRYTextBox.Location = new System.Drawing.Point(415, 360);
            this.cOUNTRYTextBox.Name = "cOUNTRYTextBox";
            this.cOUNTRYTextBox.Size = new System.Drawing.Size(100, 22);
            this.cOUNTRYTextBox.TabIndex = 46;
            // 
            // cITYTextBox
            // 
            this.cITYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aIRPORTBindingSource, "CITY", true));
            this.cITYTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cITYTextBox.Location = new System.Drawing.Point(521, 360);
            this.cITYTextBox.Name = "cITYTextBox";
            this.cITYTextBox.Size = new System.Drawing.Size(100, 22);
            this.cITYTextBox.TabIndex = 48;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Azure;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(686, 184);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 38);
            this.button4.TabIndex = 49;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 60;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // updateAirport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(848, 580);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(nAMELabel);
            this.Controls.Add(this.nAMETextBox);
            this.Controls.Add(cOUNTRYLabel);
            this.Controls.Add(this.cOUNTRYTextBox);
            this.Controls.Add(cITYLabel);
            this.Controls.Add(this.cITYTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Name = "updateAirport";
            this.Text = "updateAirport";
            this.Load += new System.EventHandler(this.updateAirport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRPORTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TESTDataSet1 tESTDataSet1;
        private System.Windows.Forms.BindingSource aIRPORTBindingSource;
        private TESTDataSet1TableAdapters.AIRPORTTableAdapter aIRPORTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOUNTRYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private TESTDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox nAMETextBox;
        private System.Windows.Forms.TextBox cOUNTRYTextBox;
        private System.Windows.Forms.TextBox cITYTextBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}