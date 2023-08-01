namespace Flight_System
{
    partial class buyTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buyTicket));
            this.label3 = new System.Windows.Forms.Label();
            this.tESTDataSet1 = new Flight_System.TESTDataSet1();
            this.fLIGHTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fLIGHTTableAdapter = new Flight_System.TESTDataSet1TableAdapters.FLIGHTTableAdapter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.FLIGHT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CLASS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PRICE = new System.Windows.Forms.TextBox();
            this.fLIGHTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.from = new System.Windows.Forms.CheckBox();
            this.to = new System.Windows.Forms.CheckBox();
            this.dep = new System.Windows.Forms.CheckBox();
            this.arrive = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.search = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tESTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLIGHTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLIGHTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 58);
            this.label3.TabIndex = 35;
            this.label3.Text = "Buy Ticket";
            // 
            // tESTDataSet1
            // 
            this.tESTDataSet1.DataSetName = "TESTDataSet1";
            this.tESTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fLIGHTBindingSource
            // 
            this.fLIGHTBindingSource.DataMember = "FLIGHT";
            this.fLIGHTBindingSource.DataSource = this.tESTDataSet1;
            // 
            // fLIGHTTableAdapter
            // 
            this.fLIGHTTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Available Flights";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Azure;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(235, 458);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 54);
            this.button2.TabIndex = 38;
            this.button2.Text = "Buy";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FLIGHT
            // 
            this.FLIGHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FLIGHT.Location = new System.Drawing.Point(253, 419);
            this.FLIGHT.Name = "FLIGHT";
            this.FLIGHT.Size = new System.Drawing.Size(100, 24);
            this.FLIGHT.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "Flight ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(359, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "Class";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // CLASS
            // 
            this.CLASS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLASS.Location = new System.Drawing.Point(359, 419);
            this.CLASS.Name = "CLASS";
            this.CLASS.Size = new System.Drawing.Size(100, 24);
            this.CLASS.TabIndex = 41;
            this.CLASS.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(465, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "Price";
            // 
            // PRICE
            // 
            this.PRICE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRICE.Location = new System.Drawing.Point(465, 419);
            this.PRICE.Name = "PRICE";
            this.PRICE.Size = new System.Drawing.Size(100, 24);
            this.PRICE.TabIndex = 43;
            // 
            // fLIGHTBindingSource1
            // 
            this.fLIGHTBindingSource1.DataMember = "FLIGHT";
            this.fLIGHTBindingSource1.DataSource = this.tESTDataSet1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(106, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(594, 150);
            this.dataGridView1.TabIndex = 45;
            // 
            // from
            // 
            this.from.AutoSize = true;
            this.from.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from.Location = new System.Drawing.Point(106, 171);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(57, 20);
            this.from.TabIndex = 46;
            this.from.Text = "From";
            this.from.UseVisualStyleBackColor = true;
            // 
            // to
            // 
            this.to.AutoSize = true;
            this.to.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to.Location = new System.Drawing.Point(168, 171);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(43, 20);
            this.to.TabIndex = 47;
            this.to.Text = "To";
            this.to.UseVisualStyleBackColor = true;
            // 
            // dep
            // 
            this.dep.AutoSize = true;
            this.dep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dep.Location = new System.Drawing.Point(287, 171);
            this.dep.Name = "dep";
            this.dep.Size = new System.Drawing.Size(86, 20);
            this.dep.TabIndex = 49;
            this.dep.Text = "Departure";
            this.dep.UseVisualStyleBackColor = true;
            // 
            // arrive
            // 
            this.arrive.AutoSize = true;
            this.arrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrive.Location = new System.Drawing.Point(217, 171);
            this.arrive.Name = "arrive";
            this.arrive.Size = new System.Drawing.Size(64, 20);
            this.arrive.TabIndex = 48;
            this.arrive.Text = "Arrival";
            this.arrive.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Azure;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(406, 458);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 54);
            this.button3.TabIndex = 50;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(106, 144);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(267, 20);
            this.search.TabIndex = 52;
            this.search.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(382, 141);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(19, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 53;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // buyTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(848, 580);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.search);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dep);
            this.Controls.Add(this.arrive);
            this.Controls.Add(this.to);
            this.Controls.Add(this.from);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PRICE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CLASS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FLIGHT);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "buyTicket";
            this.Text = "Buy Ticket";
            this.Load += new System.EventHandler(this.buyTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tESTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLIGHTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLIGHTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private TESTDataSet1 tESTDataSet1;
        private System.Windows.Forms.BindingSource fLIGHTBindingSource;
        private TESTDataSet1TableAdapters.FLIGHTTableAdapter fLIGHTTableAdapter;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox FLIGHT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CLASS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PRICE;
        private System.Windows.Forms.BindingSource fLIGHTBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox from;
        private System.Windows.Forms.CheckBox to;
        private System.Windows.Forms.CheckBox dep;
        private System.Windows.Forms.CheckBox arrive;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}