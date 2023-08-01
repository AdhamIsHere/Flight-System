namespace Flight_System
{
    partial class updateAircraft
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
            System.Windows.Forms.Label tYPELabel;
            System.Windows.Forms.Label mODELLabel;
            System.Windows.Forms.Label cAPACITYLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateAircraft));
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mODELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAPACITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aIRCRAFTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tESTDataSet1 = new Flight_System.TESTDataSet1();
            this.aIRCRAFTTableAdapter = new Flight_System.TESTDataSet1TableAdapters.AIRCRAFTTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tableAdapterManager = new Flight_System.TESTDataSet1TableAdapters.TableAdapterManager();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.tYPETextBox = new System.Windows.Forms.TextBox();
            this.mODELTextBox = new System.Windows.Forms.TextBox();
            this.cAPACITYTextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            iDLabel = new System.Windows.Forms.Label();
            tYPELabel = new System.Windows.Forms.Label();
            mODELLabel = new System.Windows.Forms.Label();
            cAPACITYLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRCRAFTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDLabel.Location = new System.Drawing.Point(196, 318);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(23, 16);
            iDLabel.TabIndex = 38;
            iDLabel.Text = "ID:";
            // 
            // tYPELabel
            // 
            tYPELabel.AutoSize = true;
            tYPELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tYPELabel.Location = new System.Drawing.Point(302, 318);
            tYPELabel.Name = "tYPELabel";
            tYPELabel.Size = new System.Drawing.Size(46, 16);
            tYPELabel.TabIndex = 40;
            tYPELabel.Text = "TYPE:";
            // 
            // mODELLabel
            // 
            mODELLabel.AutoSize = true;
            mODELLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mODELLabel.Location = new System.Drawing.Point(408, 317);
            mODELLabel.Name = "mODELLabel";
            mODELLabel.Size = new System.Drawing.Size(57, 16);
            mODELLabel.TabIndex = 42;
            mODELLabel.Text = "MODEL:";
            // 
            // cAPACITYLabel
            // 
            cAPACITYLabel.AutoSize = true;
            cAPACITYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cAPACITYLabel.Location = new System.Drawing.Point(514, 318);
            cAPACITYLabel.Name = "cAPACITYLabel";
            cAPACITYLabel.Size = new System.Drawing.Size(76, 16);
            cAPACITYLabel.TabIndex = 44;
            cAPACITYLabel.Text = "CAPACITY:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.tYPEDataGridViewTextBoxColumn,
            this.mODELDataGridViewTextBoxColumn,
            this.cAPACITYDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aIRCRAFTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(188, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 156);
            this.dataGridView1.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tYPEDataGridViewTextBoxColumn
            // 
            this.tYPEDataGridViewTextBoxColumn.DataPropertyName = "TYPE";
            this.tYPEDataGridViewTextBoxColumn.HeaderText = "TYPE";
            this.tYPEDataGridViewTextBoxColumn.Name = "tYPEDataGridViewTextBoxColumn";
            // 
            // mODELDataGridViewTextBoxColumn
            // 
            this.mODELDataGridViewTextBoxColumn.DataPropertyName = "MODEL";
            this.mODELDataGridViewTextBoxColumn.HeaderText = "MODEL";
            this.mODELDataGridViewTextBoxColumn.Name = "mODELDataGridViewTextBoxColumn";
            // 
            // cAPACITYDataGridViewTextBoxColumn
            // 
            this.cAPACITYDataGridViewTextBoxColumn.DataPropertyName = "CAPACITY";
            this.cAPACITYDataGridViewTextBoxColumn.HeaderText = "CAPACITY";
            this.cAPACITYDataGridViewTextBoxColumn.Name = "cAPACITYDataGridViewTextBoxColumn";
            // 
            // aIRCRAFTBindingSource
            // 
            this.aIRCRAFTBindingSource.DataMember = "AIRCRAFT";
            this.aIRCRAFTBindingSource.DataSource = this.tESTDataSet1;
            // 
            // tESTDataSet1
            // 
            this.tESTDataSet1.DataSetName = "TESTDataSet1";
            this.tESTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aIRCRAFTTableAdapter
            // 
            this.aIRCRAFTTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(281, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 58);
            this.label3.TabIndex = 36;
            this.label3.Text = "Update Aircraft";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Azure;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(251, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 51);
            this.button2.TabIndex = 37;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Azure;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(411, 384);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 51);
            this.button3.TabIndex = 38;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AIRCRAFTTableAdapter = this.aIRCRAFTTableAdapter;
            this.tableAdapterManager.AIRPORTTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FLIGHTTableAdapter = null;
            this.tableAdapterManager.RESERVATIONTableAdapter = null;
            this.tableAdapterManager.TICKETTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Flight_System.TESTDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERTableAdapter = null;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aIRCRAFTBindingSource, "ID", true));
            this.iDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDTextBox.Location = new System.Drawing.Point(199, 337);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 22);
            this.iDTextBox.TabIndex = 39;
            // 
            // tYPETextBox
            // 
            this.tYPETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aIRCRAFTBindingSource, "TYPE", true));
            this.tYPETextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tYPETextBox.Location = new System.Drawing.Point(305, 337);
            this.tYPETextBox.Name = "tYPETextBox";
            this.tYPETextBox.Size = new System.Drawing.Size(100, 22);
            this.tYPETextBox.TabIndex = 41;
            // 
            // mODELTextBox
            // 
            this.mODELTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aIRCRAFTBindingSource, "MODEL", true));
            this.mODELTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mODELTextBox.Location = new System.Drawing.Point(411, 337);
            this.mODELTextBox.Name = "mODELTextBox";
            this.mODELTextBox.Size = new System.Drawing.Size(100, 22);
            this.mODELTextBox.TabIndex = 43;
            // 
            // cAPACITYTextBox
            // 
            this.cAPACITYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aIRCRAFTBindingSource, "CAPACITY", true));
            this.cAPACITYTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cAPACITYTextBox.Location = new System.Drawing.Point(517, 337);
            this.cAPACITYTextBox.Name = "cAPACITYTextBox";
            this.cAPACITYTextBox.Size = new System.Drawing.Size(100, 22);
            this.cAPACITYTextBox.TabIndex = 45;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Azure;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(662, 167);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 44);
            this.button4.TabIndex = 46;
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
            this.pictureBox2.TabIndex = 59;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // updateAircraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(848, 580);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(tYPELabel);
            this.Controls.Add(this.tYPETextBox);
            this.Controls.Add(mODELLabel);
            this.Controls.Add(this.mODELTextBox);
            this.Controls.Add(cAPACITYLabel);
            this.Controls.Add(this.cAPACITYTextBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "updateAircraft";
            this.Text = "Update Aircraft";
            this.Load += new System.EventHandler(this.updateAircraft_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRCRAFTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TESTDataSet1 tESTDataSet1;
        private System.Windows.Forms.BindingSource aIRCRAFTBindingSource;
        private TESTDataSet1TableAdapters.AIRCRAFTTableAdapter aIRCRAFTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mODELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAPACITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private TESTDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox tYPETextBox;
        private System.Windows.Forms.TextBox mODELTextBox;
        private System.Windows.Forms.TextBox cAPACITYTextBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}