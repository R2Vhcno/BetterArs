﻿namespace BetterArs.Views {
    partial class BookForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this._passengerEmailTextBox = new System.Windows.Forms.TextBox();
            this._passengerPhoneTextBox = new System.Windows.Forms.TextBox();
            this._passengerNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._passengerSurnameTextBox = new System.Windows.Forms.TextBox();
            this._passengerLastNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this._birthDatePicker = new System.Windows.Forms.DateTimePicker();
            this._passengerIdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._newRecordRadioButton = new System.Windows.Forms.RadioButton();
            this._infoFromDbRadioButton = new System.Windows.Forms.RadioButton();
            this._flightIdTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this._originNameLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this._destinationNameLabel = new System.Windows.Forms.Label();
            this._bookButton = new System.Windows.Forms.Button();
            this._bookAndContinueButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._seatsDataGridView = new System.Windows.Forms.DataGridView();
            this.SeatName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeatFare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._seatsClassesComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._seatsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Controls.Add(this._passengerIdTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this._newRecordRadioButton);
            this.groupBox1.Controls.Add(this._infoFromDbRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(17, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пассажир";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this._passengerEmailTextBox, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this._passengerPhoneTextBox, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this._passengerNameTextBox, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this._passengerSurnameTextBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this._passengerLastNameTextBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label5, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this._birthDatePicker, 3, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(9, 98);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(515, 79);
            this.tableLayoutPanel3.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Дата рождения:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _passengerEmailTextBox
            // 
            this._passengerEmailTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._passengerEmailTextBox.Location = new System.Drawing.Point(343, 55);
            this._passengerEmailTextBox.Name = "_passengerEmailTextBox";
            this._passengerEmailTextBox.Size = new System.Drawing.Size(169, 20);
            this._passengerEmailTextBox.TabIndex = 7;
            this._passengerEmailTextBox.Validating += new System.ComponentModel.CancelEventHandler(this._passengerEmailTextBox_Validating);
            // 
            // _passengerPhoneTextBox
            // 
            this._passengerPhoneTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._passengerPhoneTextBox.Location = new System.Drawing.Point(68, 55);
            this._passengerPhoneTextBox.Name = "_passengerPhoneTextBox";
            this._passengerPhoneTextBox.Size = new System.Drawing.Size(169, 20);
            this._passengerPhoneTextBox.TabIndex = 8;
            this._passengerPhoneTextBox.Validating += new System.ComponentModel.CancelEventHandler(this._passengerPhoneTextBox_Validating);
            // 
            // _passengerNameTextBox
            // 
            this._passengerNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._passengerNameTextBox.Location = new System.Drawing.Point(343, 3);
            this._passengerNameTextBox.Name = "_passengerNameTextBox";
            this._passengerNameTextBox.Size = new System.Drawing.Size(169, 20);
            this._passengerNameTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Фамилия:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _passengerSurnameTextBox
            // 
            this._passengerSurnameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._passengerSurnameTextBox.Location = new System.Drawing.Point(68, 3);
            this._passengerSurnameTextBox.Name = "_passengerSurnameTextBox";
            this._passengerSurnameTextBox.Size = new System.Drawing.Size(169, 20);
            this._passengerSurnameTextBox.TabIndex = 5;
            // 
            // _passengerLastNameTextBox
            // 
            this._passengerLastNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._passengerLastNameTextBox.Location = new System.Drawing.Point(68, 29);
            this._passengerLastNameTextBox.Name = "_passengerLastNameTextBox";
            this._passengerLastNameTextBox.Size = new System.Drawing.Size(169, 20);
            this._passengerLastNameTextBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Имя:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Телефон:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Эл. почта:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Отчество:";
            // 
            // _birthDatePicker
            // 
            this._birthDatePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this._birthDatePicker.Location = new System.Drawing.Point(343, 29);
            this._birthDatePicker.Name = "_birthDatePicker";
            this._birthDatePicker.Size = new System.Drawing.Size(169, 20);
            this._birthDatePicker.TabIndex = 14;
            // 
            // _passengerIdTextBox
            // 
            this._passengerIdTextBox.Enabled = false;
            this._passengerIdTextBox.Location = new System.Drawing.Point(118, 42);
            this._passengerIdTextBox.Name = "_passengerIdTextBox";
            this._passengerIdTextBox.Size = new System.Drawing.Size(100, 20);
            this._passengerIdTextBox.TabIndex = 3;
            this._passengerIdTextBox.Text = "1";
            this._passengerIdTextBox.Validating += new System.ComponentModel.CancelEventHandler(this._passengerIdTextBox_Validating);
            this._passengerIdTextBox.Validated += new System.EventHandler(this._passengerIdTextBox_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ид пассажира:";
            // 
            // _newRecordRadioButton
            // 
            this._newRecordRadioButton.AutoSize = true;
            this._newRecordRadioButton.Checked = true;
            this._newRecordRadioButton.Location = new System.Drawing.Point(6, 75);
            this._newRecordRadioButton.Name = "_newRecordRadioButton";
            this._newRecordRadioButton.Size = new System.Drawing.Size(96, 17);
            this._newRecordRadioButton.TabIndex = 1;
            this._newRecordRadioButton.TabStop = true;
            this._newRecordRadioButton.Text = "Новая запись";
            this._newRecordRadioButton.UseVisualStyleBackColor = true;
            this._newRecordRadioButton.CheckedChanged += new System.EventHandler(this._newRecordRadioButton_CheckedChanged);
            // 
            // _infoFromDbRadioButton
            // 
            this._infoFromDbRadioButton.AutoSize = true;
            this._infoFromDbRadioButton.Location = new System.Drawing.Point(6, 19);
            this._infoFromDbRadioButton.Name = "_infoFromDbRadioButton";
            this._infoFromDbRadioButton.Size = new System.Drawing.Size(175, 17);
            this._infoFromDbRadioButton.TabIndex = 0;
            this._infoFromDbRadioButton.Text = "Информация из базы данных";
            this._infoFromDbRadioButton.UseVisualStyleBackColor = true;
            this._infoFromDbRadioButton.CheckedChanged += new System.EventHandler(this._infoFromDbRadioButton_CheckedChanged);
            // 
            // _flightIdTextBox
            // 
            this._flightIdTextBox.Location = new System.Drawing.Point(67, 12);
            this._flightIdTextBox.Name = "_flightIdTextBox";
            this._flightIdTextBox.ReadOnly = true;
            this._flightIdTextBox.Size = new System.Drawing.Size(100, 20);
            this._flightIdTextBox.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ид рейса:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.label8);
            this.flowLayoutPanel1.Controls.Add(this._originNameLabel);
            this.flowLayoutPanel1.Controls.Add(this.label10);
            this.flowLayoutPanel1.Controls.Add(this._destinationNameLabel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(191, 15);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(361, 17);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Аэропорт отправления:";
            // 
            // _originNameLabel
            // 
            this._originNameLabel.AutoSize = true;
            this._originNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._originNameLabel.Location = new System.Drawing.Point(135, 0);
            this._originNameLabel.Name = "_originNameLabel";
            this._originNameLabel.Size = new System.Drawing.Size(32, 13);
            this._originNameLabel.TabIndex = 1;
            this._originNameLabel.Text = "AOC";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(182, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(12, 0, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Аэропорт прибытия:";
            // 
            // _destinationNameLabel
            // 
            this._destinationNameLabel.AutoSize = true;
            this._destinationNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._destinationNameLabel.Location = new System.Drawing.Point(298, 0);
            this._destinationNameLabel.Name = "_destinationNameLabel";
            this._destinationNameLabel.Size = new System.Drawing.Size(32, 13);
            this._destinationNameLabel.TabIndex = 3;
            this._destinationNameLabel.Text = "ADC";
            // 
            // _bookButton
            // 
            this._bookButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._bookButton.Location = new System.Drawing.Point(477, 486);
            this._bookButton.Name = "_bookButton";
            this._bookButton.Size = new System.Drawing.Size(75, 23);
            this._bookButton.TabIndex = 7;
            this._bookButton.Text = "Оформить";
            this._bookButton.UseVisualStyleBackColor = true;
            this._bookButton.Click += new System.EventHandler(this._bookButton_Click);
            // 
            // _bookAndContinueButton
            // 
            this._bookAndContinueButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._bookAndContinueButton.Location = new System.Drawing.Point(325, 486);
            this._bookAndContinueButton.Name = "_bookAndContinueButton";
            this._bookAndContinueButton.Size = new System.Drawing.Size(146, 23);
            this._bookAndContinueButton.TabIndex = 8;
            this._bookAndContinueButton.Text = "Оформить и продолжить";
            this._bookAndContinueButton.UseVisualStyleBackColor = true;
            this._bookAndContinueButton.Click += new System.EventHandler(this._bookAndContinueButton_Click);
            // 
            // _cancelButton
            // 
            this._cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._cancelButton.Location = new System.Drawing.Point(245, 486);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(75, 23);
            this._cancelButton.TabIndex = 9;
            this._cancelButton.Text = "Отмена";
            this._cancelButton.UseVisualStyleBackColor = true;
            this._cancelButton.Click += new System.EventHandler(this._cancelButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this._seatsDataGridView);
            this.groupBox2.Controls.Add(this._seatsClassesComboBox);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(17, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(535, 229);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Место";
            // 
            // _seatsDataGridView
            // 
            this._seatsDataGridView.AllowUserToAddRows = false;
            this._seatsDataGridView.AllowUserToDeleteRows = false;
            this._seatsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._seatsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._seatsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SeatName,
            this.SeatFare});
            this._seatsDataGridView.Location = new System.Drawing.Point(6, 46);
            this._seatsDataGridView.MultiSelect = false;
            this._seatsDataGridView.Name = "_seatsDataGridView";
            this._seatsDataGridView.ReadOnly = true;
            this._seatsDataGridView.Size = new System.Drawing.Size(523, 177);
            this._seatsDataGridView.TabIndex = 2;
            // 
            // SeatName
            // 
            this.SeatName.DataPropertyName = "SeatName";
            this.SeatName.HeaderText = "Имя";
            this.SeatName.Name = "SeatName";
            this.SeatName.ReadOnly = true;
            // 
            // SeatFare
            // 
            this.SeatFare.DataPropertyName = "Fare";
            this.SeatFare.HeaderText = "Такса";
            this.SeatFare.Name = "SeatFare";
            this.SeatFare.ReadOnly = true;
            // 
            // _seatsClassesComboBox
            // 
            this._seatsClassesComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._seatsClassesComboBox.DisplayMember = "ClassName";
            this._seatsClassesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._seatsClassesComboBox.FormattingEnabled = true;
            this._seatsClassesComboBox.Location = new System.Drawing.Point(53, 19);
            this._seatsClassesComboBox.Name = "_seatsClassesComboBox";
            this._seatsClassesComboBox.Size = new System.Drawing.Size(476, 21);
            this._seatsClassesComboBox.TabIndex = 1;
            this._seatsClassesComboBox.ValueMember = "Id";
            this._seatsClassesComboBox.SelectedIndexChanged += new System.EventHandler(this._seatsClassesComboBox_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Класс:";
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 521);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._bookAndContinueButton);
            this.Controls.Add(this._bookButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this._flightIdTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Оформление билета";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._seatsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton _newRecordRadioButton;
        private System.Windows.Forms.RadioButton _infoFromDbRadioButton;
        private System.Windows.Forms.TextBox _passengerIdTextBox;
        private System.Windows.Forms.TextBox _flightIdTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label _originNameLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label _destinationNameLabel;
        private System.Windows.Forms.Button _bookButton;
        private System.Windows.Forms.Button _bookAndContinueButton;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView _seatsDataGridView;
        private System.Windows.Forms.ComboBox _seatsClassesComboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeatName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeatFare;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _passengerEmailTextBox;
        private System.Windows.Forms.TextBox _passengerPhoneTextBox;
        private System.Windows.Forms.TextBox _passengerNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _passengerSurnameTextBox;
        private System.Windows.Forms.TextBox _passengerLastNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker _birthDatePicker;
    }
}