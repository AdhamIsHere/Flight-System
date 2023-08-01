namespace Flight_System
{
    partial class modifyFlight
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
            System.Windows.Forms.Label aIRPORT_SOURCELabel;
            System.Windows.Forms.Label aIRPORT_DESTINATIONLabel;
            System.Windows.Forms.Label aIRCRAFT_IDLabel;
            System.Windows.Forms.Label aRRIVALLabel;
            System.Windows.Forms.Label dEPARTURELabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modifyFlight));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aIRPORTSOURCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aIRPORTDESTINATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aIRCRAFTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRRIVALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPARTUREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fLIGHTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tESTDataSet2 = new Flight_System.TESTDataSet2();
            this.fLIGHTTableAdapter = new Flight_System.TESTDataSet2TableAdapters.FLIGHTTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableAdapterManager = new Flight_System.TESTDataSet2TableAdapters.TableAdapterManager();
            this.aIRCRAFTTableAdapter = new Flight_System.TESTDataSet2TableAdapters.AIRCRAFTTableAdapter();
            this.aIRPORTTableAdapter = new Flight_System.TESTDataSet2TableAdapters.AIRPORTTableAdapter();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.aIRPORT_SOURCETextBox = new System.Windows.Forms.TextBox();
            this.aIRPORT_DESTINATIONTextBox = new System.Windows.Forms.TextBox();
            this.aIRCRAFT_IDTextBox = new System.Windows.Forms.TextBox();
            this.arrive = new System.Windows.Forms.TextBox();
            this.departure = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.aIRPORTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aIRPORTDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aIRCRAFTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aIRCRAFTDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            iDLabel = new System.Windows.Forms.Label();
            aIRPORT_SOURCELabel = new System.Windows.Forms.Label();
            aIRPORT_DESTINATIONLabel = new System.Windows.Forms.Label();
            aIRCRAFT_IDLabel = new System.Windows.Forms.Label();
            aRRIVALLabel = new System.Windows.Forms.Label();
            dEPARTURELabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLIGHTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESTDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRPORTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRPORTDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRCRAFTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRCRAFTDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDLabel.Location = new System.Drawing.Point(420, 297);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(20, 16);
            iDLabel.TabIndex = 19;
            iDLabel.Text = "ID";
            // 
            // aIRPORT_SOURCELabel
            // 
            aIRPORT_SOURCELabel.AutoSize = true;
            aIRPORT_SOURCELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aIRPORT_SOURCELabel.Location = new System.Drawing.Point(559, 297);
            aIRPORT_SOURCELabel.Name = "aIRPORT_SOURCELabel";
            aIRPORT_SOURCELabel.Size = new System.Drawing.Size(50, 16);
            aIRPORT_SOURCELabel.TabIndex = 21;
            aIRPORT_SOURCELabel.Text = "Source";
            // 
            // aIRPORT_DESTINATIONLabel
            // 
            aIRPORT_DESTINATIONLabel.AutoSize = true;
            aIRPORT_DESTINATIONLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aIRPORT_DESTINATIONLabel.Location = new System.Drawing.Point(695, 297);
            aIRPORT_DESTINATIONLabel.Name = "aIRPORT_DESTINATIONLabel";
            aIRPORT_DESTINATIONLabel.Size = new System.Drawing.Size(74, 16);
            aIRPORT_DESTINATIONLabel.TabIndex = 23;
            aIRPORT_DESTINATIONLabel.Text = "Destination";
            // 
            // aIRCRAFT_IDLabel
            // 
            aIRCRAFT_IDLabel.AutoSize = true;
            aIRCRAFT_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aIRCRAFT_IDLabel.Location = new System.Drawing.Point(828, 297);
            aIRCRAFT_IDLabel.Name = "aIRCRAFT_IDLabel";
            aIRCRAFT_IDLabel.Size = new System.Drawing.Size(64, 16);
            aIRCRAFT_IDLabel.TabIndex = 25;
            aIRCRAFT_IDLabel.Text = "Aircraft ID";
            // 
            // aRRIVALLabel
            // 
            aRRIVALLabel.AutoSize = true;
            aRRIVALLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aRRIVALLabel.Location = new System.Drawing.Point(964, 297);
            aRRIVALLabel.Name = "aRRIVALLabel";
            aRRIVALLabel.Size = new System.Drawing.Size(45, 16);
            aRRIVALLabel.TabIndex = 27;
            aRRIVALLabel.Text = "Arrival";
            // 
            // dEPARTURELabel
            // 
            dEPARTURELabel.AutoSize = true;
            dEPARTURELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dEPARTURELabel.Location = new System.Drawing.Point(1100, 297);
            dEPARTURELabel.Name = "dEPARTURELabel";
            dEPARTURELabel.Size = new System.Drawing.Size(67, 16);
            dEPARTURELabel.TabIndex = 29;
            dEPARTURELabel.Text = "Departure";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(12, 340);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(55, 16);
            label1.TabIndex = 33;
            label1.Text = "Aircrafts";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(12, 92);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(53, 16);
            label2.TabIndex = 34;
            label2.Text = "Airports";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(495, 92);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(46, 16);
            label3.TabIndex = 35;
            label3.Text = "Flights";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.aIRPORTSOURCEDataGridViewTextBoxColumn,
            this.aIRPORTDESTINATIONDataGridViewTextBoxColumn,
            this.aIRCRAFTIDDataGridViewTextBoxColumn,
            this.aRRIVALDataGridViewTextBoxColumn,
            this.dEPARTUREDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fLIGHTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(498, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 156);
            this.dataGridView1.TabIndex = 6;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aIRPORTSOURCEDataGridViewTextBoxColumn
            // 
            this.aIRPORTSOURCEDataGridViewTextBoxColumn.DataPropertyName = "AIRPORT_SOURCE";
            this.aIRPORTSOURCEDataGridViewTextBoxColumn.HeaderText = "AIRPORT_SOURCE";
            this.aIRPORTSOURCEDataGridViewTextBoxColumn.Name = "aIRPORTSOURCEDataGridViewTextBoxColumn";
            // 
            // aIRPORTDESTINATIONDataGridViewTextBoxColumn
            // 
            this.aIRPORTDESTINATIONDataGridViewTextBoxColumn.DataPropertyName = "AIRPORT_DESTINATION";
            this.aIRPORTDESTINATIONDataGridViewTextBoxColumn.HeaderText = "AIRPORT_DESTINATION";
            this.aIRPORTDESTINATIONDataGridViewTextBoxColumn.Name = "aIRPORTDESTINATIONDataGridViewTextBoxColumn";
            // 
            // aIRCRAFTIDDataGridViewTextBoxColumn
            // 
            this.aIRCRAFTIDDataGridViewTextBoxColumn.DataPropertyName = "AIRCRAFT_ID";
            this.aIRCRAFTIDDataGridViewTextBoxColumn.HeaderText = "AIRCRAFT_ID";
            this.aIRCRAFTIDDataGridViewTextBoxColumn.Name = "aIRCRAFTIDDataGridViewTextBoxColumn";
            // 
            // aRRIVALDataGridViewTextBoxColumn
            // 
            this.aRRIVALDataGridViewTextBoxColumn.DataPropertyName = "ARRIVAL";
            this.aRRIVALDataGridViewTextBoxColumn.HeaderText = "ARRIVAL";
            this.aRRIVALDataGridViewTextBoxColumn.Name = "aRRIVALDataGridViewTextBoxColumn";
            // 
            // dEPARTUREDataGridViewTextBoxColumn
            // 
            this.dEPARTUREDataGridViewTextBoxColumn.DataPropertyName = "DEPARTURE";
            this.dEPARTUREDataGridViewTextBoxColumn.HeaderText = "DEPARTURE";
            this.dEPARTUREDataGridViewTextBoxColumn.Name = "dEPARTUREDataGridViewTextBoxColumn";
            // 
            // fLIGHTBindingSource
            // 
            this.fLIGHTBindingSource.DataMember = "FLIGHT";
            this.fLIGHTBindingSource.DataSource = this.tESTDataSet2;
            // 
            // tESTDataSet2
            // 
            this.tESTDataSet2.DataSetName = "TESTDataSet2";
            this.tESTDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fLIGHTTableAdapter
            // 
            this.fLIGHTTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(591, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 58);
            this.label8.TabIndex = 18;
            this.label8.Text = "Flights ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Azure;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(628, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 57);
            this.button1.TabIndex = 19;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AIRCRAFTTableAdapter = this.aIRCRAFTTableAdapter;
            this.tableAdapterManager.AIRPORTTableAdapter = this.aIRPORTTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FLIGHTTableAdapter = this.fLIGHTTableAdapter;
            this.tableAdapterManager.RESERVATIONTableAdapter = null;
            this.tableAdapterManager.TICKETTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Flight_System.TESTDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERTableAdapter = null;
            // 
            // aIRCRAFTTableAdapter
            // 
            this.aIRCRAFTTableAdapter.ClearBeforeFill = true;
            // 
            // aIRPORTTableAdapter
            // 
            this.aIRPORTTableAdapter.ClearBeforeFill = true;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fLIGHTBindingSource, "ID", true));
            this.iDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDTextBox.Location = new System.Drawing.Point(423, 316);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(130, 22);
            this.iDTextBox.TabIndex = 20;
            // 
            // aIRPORT_SOURCETextBox
            // 
            this.aIRPORT_SOURCETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fLIGHTBindingSource, "AIRPORT_SOURCE", true));
            this.aIRPORT_SOURCETextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aIRPORT_SOURCETextBox.Location = new System.Drawing.Point(559, 316);
            this.aIRPORT_SOURCETextBox.Name = "aIRPORT_SOURCETextBox";
            this.aIRPORT_SOURCETextBox.Size = new System.Drawing.Size(130, 22);
            this.aIRPORT_SOURCETextBox.TabIndex = 22;
            // 
            // aIRPORT_DESTINATIONTextBox
            // 
            this.aIRPORT_DESTINATIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fLIGHTBindingSource, "AIRPORT_DESTINATION", true));
            this.aIRPORT_DESTINATIONTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aIRPORT_DESTINATIONTextBox.Location = new System.Drawing.Point(695, 316);
            this.aIRPORT_DESTINATIONTextBox.Name = "aIRPORT_DESTINATIONTextBox";
            this.aIRPORT_DESTINATIONTextBox.Size = new System.Drawing.Size(130, 22);
            this.aIRPORT_DESTINATIONTextBox.TabIndex = 24;
            // 
            // aIRCRAFT_IDTextBox
            // 
            this.aIRCRAFT_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fLIGHTBindingSource, "AIRCRAFT_ID", true));
            this.aIRCRAFT_IDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aIRCRAFT_IDTextBox.Location = new System.Drawing.Point(831, 316);
            this.aIRCRAFT_IDTextBox.Name = "aIRCRAFT_IDTextBox";
            this.aIRCRAFT_IDTextBox.Size = new System.Drawing.Size(130, 22);
            this.aIRCRAFT_IDTextBox.TabIndex = 26;
            // 
            // arrive
            // 
            this.arrive.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fLIGHTBindingSource, "AIRPORT_SOURCE", true));
            this.arrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrive.Location = new System.Drawing.Point(967, 316);
            this.arrive.Name = "arrive";
            this.arrive.Size = new System.Drawing.Size(130, 22);
            this.arrive.TabIndex = 30;
            // 
            // departure
            // 
            this.departure.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fLIGHTBindingSource, "AIRPORT_SOURCE", true));
            this.departure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departure.Location = new System.Drawing.Point(1103, 316);
            this.departure.Name = "departure";
            this.departure.Size = new System.Drawing.Size(130, 22);
            this.departure.TabIndex = 31;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Azure;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(1167, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 47);
            this.button2.TabIndex = 32;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // aIRPORTBindingSource
            // 
            this.aIRPORTBindingSource.DataMember = "AIRPORT";
            this.aIRPORTBindingSource.DataSource = this.tESTDataSet2;
            // 
            // aIRPORTDataGridView
            // 
            this.aIRPORTDataGridView.AutoGenerateColumns = false;
            this.aIRPORTDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aIRPORTDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.aIRPORTDataGridView.DataSource = this.aIRPORTBindingSource;
            this.aIRPORTDataGridView.Location = new System.Drawing.Point(15, 111);
            this.aIRPORTDataGridView.Name = "aIRPORTDataGridView";
            this.aIRPORTDataGridView.Size = new System.Drawing.Size(443, 156);
            this.aIRPORTDataGridView.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "NAME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "COUNTRY";
            this.dataGridViewTextBoxColumn3.HeaderText = "COUNTRY";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CITY";
            this.dataGridViewTextBoxColumn4.HeaderText = "CITY";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // aIRCRAFTBindingSource
            // 
            this.aIRCRAFTBindingSource.DataMember = "AIRCRAFT";
            this.aIRCRAFTBindingSource.DataSource = this.tESTDataSet2;
            // 
            // aIRCRAFTDataGridView
            // 
            this.aIRCRAFTDataGridView.AutoGenerateColumns = false;
            this.aIRCRAFTDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aIRCRAFTDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.aIRCRAFTDataGridView.DataSource = this.aIRCRAFTBindingSource;
            this.aIRCRAFTDataGridView.Location = new System.Drawing.Point(15, 359);
            this.aIRCRAFTDataGridView.Name = "aIRCRAFTDataGridView";
            this.aIRCRAFTDataGridView.Size = new System.Drawing.Size(443, 156);
            this.aIRCRAFTDataGridView.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TYPE";
            this.dataGridViewTextBoxColumn6.HeaderText = "TYPE";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MODEL";
            this.dataGridViewTextBoxColumn7.HeaderText = "MODEL";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CAPACITY";
            this.dataGridViewTextBoxColumn8.HeaderText = "CAPACITY";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Azure;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(817, 395);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 57);
            this.button3.TabIndex = 36;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 57;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // modifyFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1302, 551);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.aIRCRAFTDataGridView);
            this.Controls.Add(this.aIRPORTDataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.departure);
            this.Controls.Add(this.arrive);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(aIRPORT_SOURCELabel);
            this.Controls.Add(this.aIRPORT_SOURCETextBox);
            this.Controls.Add(aIRPORT_DESTINATIONLabel);
            this.Controls.Add(this.aIRPORT_DESTINATIONTextBox);
            this.Controls.Add(aIRCRAFT_IDLabel);
            this.Controls.Add(this.aIRCRAFT_IDTextBox);
            this.Controls.Add(aRRIVALLabel);
            this.Controls.Add(dEPARTURELabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Name = "modifyFlight";
            this.Text = "Modify Flight";
            this.Load += new System.EventHandler(this.modifyFlight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLIGHTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESTDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRPORTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRPORTDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRCRAFTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRCRAFTDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private TESTDataSet2 tESTDataSet2;
        private System.Windows.Forms.BindingSource fLIGHTBindingSource;
        private TESTDataSet2TableAdapters.FLIGHTTableAdapter fLIGHTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aIRPORTSOURCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aIRPORTDESTINATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aIRCRAFTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRRIVALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPARTUREDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private TESTDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox aIRPORT_SOURCETextBox;
        private System.Windows.Forms.TextBox aIRPORT_DESTINATIONTextBox;
        private System.Windows.Forms.TextBox aIRCRAFT_IDTextBox;
        private System.Windows.Forms.TextBox arrive;
        private System.Windows.Forms.TextBox departure;
        private System.Windows.Forms.Button button2;
        private TESTDataSet2TableAdapters.AIRPORTTableAdapter aIRPORTTableAdapter;
        private System.Windows.Forms.BindingSource aIRPORTBindingSource;
        private TESTDataSet2TableAdapters.AIRCRAFTTableAdapter aIRCRAFTTableAdapter;
        private System.Windows.Forms.DataGridView aIRPORTDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource aIRCRAFTBindingSource;
        private System.Windows.Forms.DataGridView aIRCRAFTDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}