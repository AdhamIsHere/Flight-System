namespace Flight_System
{
    partial class userAcc
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
            System.Windows.Forms.Label nAMELabel;
            System.Windows.Forms.Label cOUNTRYLabel;
            System.Windows.Forms.Label cITYLabel;
            System.Windows.Forms.Label sTREETLabel;
            System.Windows.Forms.Label pASSWORDLabel;
            System.Windows.Forms.Label pHONELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userAcc));
            this.tESTDataSet1 = new Flight_System.TESTDataSet1();
            this.uSERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSERTableAdapter = new Flight_System.TESTDataSet1TableAdapters.USERTableAdapter();
            this.tableAdapterManager = new Flight_System.TESTDataSet1TableAdapters.TableAdapterManager();
            this.nAMETextBox = new System.Windows.Forms.TextBox();
            this.cOUNTRYTextBox = new System.Windows.Forms.TextBox();
            this.cITYTextBox = new System.Windows.Forms.TextBox();
            this.sTREETTextBox = new System.Windows.Forms.TextBox();
            this.pASSWORDTextBox = new System.Windows.Forms.TextBox();
            this.pHONETextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            nAMELabel = new System.Windows.Forms.Label();
            cOUNTRYLabel = new System.Windows.Forms.Label();
            cITYLabel = new System.Windows.Forms.Label();
            sTREETLabel = new System.Windows.Forms.Label();
            pASSWORDLabel = new System.Windows.Forms.Label();
            pHONELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tESTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // nAMELabel
            // 
            nAMELabel.AutoSize = true;
            nAMELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nAMELabel.Location = new System.Drawing.Point(320, 172);
            nAMELabel.Name = "nAMELabel";
            nAMELabel.Size = new System.Drawing.Size(49, 16);
            nAMELabel.TabIndex = 3;
            nAMELabel.Text = "NAME:";
            // 
            // cOUNTRYLabel
            // 
            cOUNTRYLabel.AutoSize = true;
            cOUNTRYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cOUNTRYLabel.Location = new System.Drawing.Point(320, 201);
            cOUNTRYLabel.Name = "cOUNTRYLabel";
            cOUNTRYLabel.Size = new System.Drawing.Size(77, 16);
            cOUNTRYLabel.TabIndex = 5;
            cOUNTRYLabel.Text = "COUNTRY:";
            // 
            // cITYLabel
            // 
            cITYLabel.AutoSize = true;
            cITYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cITYLabel.Location = new System.Drawing.Point(320, 230);
            cITYLabel.Name = "cITYLabel";
            cITYLabel.Size = new System.Drawing.Size(40, 16);
            cITYLabel.TabIndex = 7;
            cITYLabel.Text = "CITY:";
            // 
            // sTREETLabel
            // 
            sTREETLabel.AutoSize = true;
            sTREETLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sTREETLabel.Location = new System.Drawing.Point(320, 258);
            sTREETLabel.Name = "sTREETLabel";
            sTREETLabel.Size = new System.Drawing.Size(65, 16);
            sTREETLabel.TabIndex = 9;
            sTREETLabel.Text = "STREET:";
            // 
            // pASSWORDLabel
            // 
            pASSWORDLabel.AutoSize = true;
            pASSWORDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pASSWORDLabel.Location = new System.Drawing.Point(320, 286);
            pASSWORDLabel.Name = "pASSWORDLabel";
            pASSWORDLabel.Size = new System.Drawing.Size(89, 16);
            pASSWORDLabel.TabIndex = 13;
            pASSWORDLabel.Text = "PASSWORD:";
            // 
            // pHONELabel
            // 
            pHONELabel.AutoSize = true;
            pHONELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pHONELabel.Location = new System.Drawing.Point(320, 314);
            pHONELabel.Name = "pHONELabel";
            pHONELabel.Size = new System.Drawing.Size(58, 16);
            pHONELabel.TabIndex = 15;
            pHONELabel.Text = "PHONE:";
            // 
            // tESTDataSet1
            // 
            this.tESTDataSet1.DataSetName = "TESTDataSet1";
            this.tESTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSERBindingSource
            // 
            this.uSERBindingSource.DataMember = "USER";
            this.uSERBindingSource.DataSource = this.tESTDataSet1;
            // 
            // uSERTableAdapter
            // 
            this.uSERTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AIRCRAFTTableAdapter = null;
            this.tableAdapterManager.AIRPORTTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FLIGHTTableAdapter = null;
            this.tableAdapterManager.RESERVATIONTableAdapter = null;
            this.tableAdapterManager.TICKETTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Flight_System.TESTDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERTableAdapter = this.uSERTableAdapter;
            // 
            // nAMETextBox
            // 
            this.nAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uSERBindingSource, "NAME", true));
            this.nAMETextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nAMETextBox.Location = new System.Drawing.Point(415, 169);
            this.nAMETextBox.Name = "nAMETextBox";
            this.nAMETextBox.Size = new System.Drawing.Size(104, 22);
            this.nAMETextBox.TabIndex = 4;
            // 
            // cOUNTRYTextBox
            // 
            this.cOUNTRYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uSERBindingSource, "COUNTRY", true));
            this.cOUNTRYTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cOUNTRYTextBox.Location = new System.Drawing.Point(415, 198);
            this.cOUNTRYTextBox.Name = "cOUNTRYTextBox";
            this.cOUNTRYTextBox.Size = new System.Drawing.Size(104, 22);
            this.cOUNTRYTextBox.TabIndex = 6;
            // 
            // cITYTextBox
            // 
            this.cITYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uSERBindingSource, "CITY", true));
            this.cITYTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cITYTextBox.Location = new System.Drawing.Point(415, 227);
            this.cITYTextBox.Name = "cITYTextBox";
            this.cITYTextBox.Size = new System.Drawing.Size(104, 22);
            this.cITYTextBox.TabIndex = 8;
            // 
            // sTREETTextBox
            // 
            this.sTREETTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uSERBindingSource, "STREET", true));
            this.sTREETTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sTREETTextBox.Location = new System.Drawing.Point(415, 255);
            this.sTREETTextBox.Name = "sTREETTextBox";
            this.sTREETTextBox.Size = new System.Drawing.Size(104, 22);
            this.sTREETTextBox.TabIndex = 10;
            // 
            // pASSWORDTextBox
            // 
            this.pASSWORDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uSERBindingSource, "PASSWORD", true));
            this.pASSWORDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pASSWORDTextBox.Location = new System.Drawing.Point(415, 283);
            this.pASSWORDTextBox.Name = "pASSWORDTextBox";
            this.pASSWORDTextBox.Size = new System.Drawing.Size(104, 22);
            this.pASSWORDTextBox.TabIndex = 14;
            // 
            // pHONETextBox
            // 
            this.pHONETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uSERBindingSource, "PHONE", true));
            this.pHONETextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pHONETextBox.Location = new System.Drawing.Point(415, 311);
            this.pHONETextBox.Name = "pHONETextBox";
            this.pHONETextBox.Size = new System.Drawing.Size(104, 22);
            this.pHONETextBox.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Azure;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(256, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 54);
            this.button1.TabIndex = 17;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(269, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(335, 58);
            this.label3.TabIndex = 34;
            this.label3.Text = "Account Information";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Azure;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(415, 353);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 54);
            this.button3.TabIndex = 35;
            this.button3.Text = "Delete Account";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 61;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // userAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(848, 580);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(nAMELabel);
            this.Controls.Add(this.nAMETextBox);
            this.Controls.Add(cOUNTRYLabel);
            this.Controls.Add(this.cOUNTRYTextBox);
            this.Controls.Add(cITYLabel);
            this.Controls.Add(this.cITYTextBox);
            this.Controls.Add(sTREETLabel);
            this.Controls.Add(this.sTREETTextBox);
            this.Controls.Add(pASSWORDLabel);
            this.Controls.Add(this.pASSWORDTextBox);
            this.Controls.Add(pHONELabel);
            this.Controls.Add(this.pHONETextBox);
            this.Name = "userAcc";
            this.Text = "User Account";
            this.Load += new System.EventHandler(this.userAcc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tESTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TESTDataSet1 tESTDataSet1;
        private System.Windows.Forms.BindingSource uSERBindingSource;
        private TESTDataSet1TableAdapters.USERTableAdapter uSERTableAdapter;
        private TESTDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nAMETextBox;
        private System.Windows.Forms.TextBox cOUNTRYTextBox;
        private System.Windows.Forms.TextBox cITYTextBox;
        private System.Windows.Forms.TextBox sTREETTextBox;
        private System.Windows.Forms.TextBox pASSWORDTextBox;
        private System.Windows.Forms.TextBox pHONETextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}