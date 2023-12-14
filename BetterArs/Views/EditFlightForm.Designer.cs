namespace BetterArs.Views {
    partial class EditFlightForm {
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
            this._destinationCityTextBox = new System.Windows.Forms.TextBox();
            this._originCityTextBox = new System.Windows.Forms.TextBox();
            this._originCodeTextBox = new System.Windows.Forms.TextBox();
            this._destinationSelectButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this._originSelectButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this._destinationCodeTextBox = new System.Windows.Forms.TextBox();
            this._departureDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._selectPlaneButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this._planeNameTextBox = new System.Windows.Forms.TextBox();
            this._planesGridView = new System.Windows.Forms.DataGridView();
            this._nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._availableSeatcColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._okButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this._departureTimePicker = new System.Windows.Forms.MaskedTextBox();
            this._flightDurationPicker = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._planesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this._destinationCityTextBox);
            this.groupBox1.Controls.Add(this._originCityTextBox);
            this.groupBox1.Controls.Add(this._originCodeTextBox);
            this.groupBox1.Controls.Add(this._destinationSelectButton);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this._originSelectButton);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this._destinationCodeTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 73);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Маршрут";
            // 
            // _destinationCityTextBox
            // 
            this._destinationCityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._destinationCityTextBox.Location = new System.Drawing.Point(185, 48);
            this._destinationCityTextBox.Name = "_destinationCityTextBox";
            this._destinationCityTextBox.ReadOnly = true;
            this._destinationCityTextBox.Size = new System.Drawing.Size(298, 20);
            this._destinationCityTextBox.TabIndex = 16;
            this._destinationCityTextBox.Text = "(Выберите аэропорт)";
            // 
            // _originCityTextBox
            // 
            this._originCityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._originCityTextBox.Location = new System.Drawing.Point(185, 22);
            this._originCityTextBox.Name = "_originCityTextBox";
            this._originCityTextBox.ReadOnly = true;
            this._originCityTextBox.Size = new System.Drawing.Size(298, 20);
            this._originCityTextBox.TabIndex = 15;
            this._originCityTextBox.Text = "(Выберите аэропорт)";
            // 
            // _originCodeTextBox
            // 
            this._originCodeTextBox.Location = new System.Drawing.Point(132, 22);
            this._originCodeTextBox.Name = "_originCodeTextBox";
            this._originCodeTextBox.Size = new System.Drawing.Size(47, 20);
            this._originCodeTextBox.TabIndex = 10;
            this._originCodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._originCodeTextBox.TextChanged += new System.EventHandler(this._originCodeTextBox_TextChanged);
            this._originCodeTextBox.Enter += new System.EventHandler(this._originCodeTextBox_Enter);
            // 
            // _destinationSelectButton
            // 
            this._destinationSelectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._destinationSelectButton.Location = new System.Drawing.Point(489, 46);
            this._destinationSelectButton.Name = "_destinationSelectButton";
            this._destinationSelectButton.Size = new System.Drawing.Size(25, 23);
            this._destinationSelectButton.TabIndex = 14;
            this._destinationSelectButton.Text = "...";
            this._destinationSelectButton.UseVisualStyleBackColor = true;
            this._destinationSelectButton.Click += new System.EventHandler(this._destinationSelectButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Аэропорт отпраления:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _originSelectButton
            // 
            this._originSelectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._originSelectButton.Location = new System.Drawing.Point(489, 20);
            this._originSelectButton.Name = "_originSelectButton";
            this._originSelectButton.Size = new System.Drawing.Size(25, 23);
            this._originSelectButton.TabIndex = 13;
            this._originSelectButton.Text = "...";
            this._originSelectButton.UseVisualStyleBackColor = true;
            this._originSelectButton.Click += new System.EventHandler(this._originSelectButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Аэропорт прибытия:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _destinationCodeTextBox
            // 
            this._destinationCodeTextBox.Location = new System.Drawing.Point(132, 48);
            this._destinationCodeTextBox.Name = "_destinationCodeTextBox";
            this._destinationCodeTextBox.Size = new System.Drawing.Size(47, 20);
            this._destinationCodeTextBox.TabIndex = 12;
            this._destinationCodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._destinationCodeTextBox.TextChanged += new System.EventHandler(this._destinationCodeTextBox_TextChanged);
            this._destinationCodeTextBox.Enter += new System.EventHandler(this._destinationCodeTextBox_Enter);
            // 
            // _departureDatePicker
            // 
            this._departureDatePicker.CustomFormat = "dd MMMM yyyy г.";
            this._departureDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._departureDatePicker.Location = new System.Drawing.Point(141, 266);
            this._departureDatePicker.Name = "_departureDatePicker";
            this._departureDatePicker.Size = new System.Drawing.Size(140, 20);
            this._departureDatePicker.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Дата и время вылета:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Время в пути:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this._selectPlaneButton);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this._planeNameTextBox);
            this.groupBox2.Controls.Add(this._planesGridView);
            this.groupBox2.Location = new System.Drawing.Point(12, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 165);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Борт";
            // 
            // _selectPlaneButton
            // 
            this._selectPlaneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._selectPlaneButton.Location = new System.Drawing.Point(439, 136);
            this._selectPlaneButton.Name = "_selectPlaneButton";
            this._selectPlaneButton.Size = new System.Drawing.Size(75, 23);
            this._selectPlaneButton.TabIndex = 3;
            this._selectPlaneButton.Text = "Выбрать";
            this._selectPlaneButton.UseVisualStyleBackColor = true;
            this._selectPlaneButton.Click += new System.EventHandler(this._selectPlaneButton_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Информация о борте:";
            // 
            // _planeNameTextBox
            // 
            this._planeNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._planeNameTextBox.Location = new System.Drawing.Point(129, 138);
            this._planeNameTextBox.Name = "_planeNameTextBox";
            this._planeNameTextBox.ReadOnly = true;
            this._planeNameTextBox.Size = new System.Drawing.Size(304, 20);
            this._planeNameTextBox.TabIndex = 1;
            // 
            // _planesGridView
            // 
            this._planesGridView.AllowUserToAddRows = false;
            this._planesGridView.AllowUserToDeleteRows = false;
            this._planesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._planesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._planesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._nameColumn,
            this._availableSeatcColumn});
            this._planesGridView.Location = new System.Drawing.Point(6, 19);
            this._planesGridView.MultiSelect = false;
            this._planesGridView.Name = "_planesGridView";
            this._planesGridView.ReadOnly = true;
            this._planesGridView.Size = new System.Drawing.Size(508, 111);
            this._planesGridView.TabIndex = 0;
            // 
            // _nameColumn
            // 
            this._nameColumn.DataPropertyName = "Name";
            this._nameColumn.HeaderText = "Название";
            this._nameColumn.Name = "_nameColumn";
            this._nameColumn.ReadOnly = true;
            // 
            // _availableSeatcColumn
            // 
            this._availableSeatcColumn.DataPropertyName = "AvailableSeats";
            this._availableSeatcColumn.HeaderText = "Кол-во мест";
            this._availableSeatcColumn.Name = "_availableSeatcColumn";
            this._availableSeatcColumn.ReadOnly = true;
            // 
            // _okButton
            // 
            this._okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._okButton.Location = new System.Drawing.Point(457, 303);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(75, 23);
            this._okButton.TabIndex = 9;
            this._okButton.Text = "Применить";
            this._okButton.UseVisualStyleBackColor = true;
            this._okButton.Click += new System.EventHandler(this._okButton_Click);
            // 
            // _cancelButton
            // 
            this._cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Location = new System.Drawing.Point(370, 303);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(75, 23);
            this._cancelButton.TabIndex = 10;
            this._cancelButton.Text = "Отмена";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // _departureTimePicker
            // 
            this._departureTimePicker.Location = new System.Drawing.Point(287, 266);
            this._departureTimePicker.Mask = "00:00";
            this._departureTimePicker.Name = "_departureTimePicker";
            this._departureTimePicker.Size = new System.Drawing.Size(54, 20);
            this._departureTimePicker.TabIndex = 12;
            this._departureTimePicker.ValidatingType = typeof(System.DateTime);
            // 
            // _flightDurationPicker
            // 
            this._flightDurationPicker.Location = new System.Drawing.Point(141, 292);
            this._flightDurationPicker.Mask = "00:00";
            this._flightDurationPicker.Name = "_flightDurationPicker";
            this._flightDurationPicker.Size = new System.Drawing.Size(200, 20);
            this._flightDurationPicker.TabIndex = 13;
            this._flightDurationPicker.ValidatingType = typeof(System.DateTime);
            // 
            // EditFlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 338);
            this.Controls.Add(this._flightDurationPicker);
            this.Controls.Add(this._departureTimePicker);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._departureDatePicker);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditFlightForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование информации о рейсе";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._planesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker _departureDatePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button _selectPlaneButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _planeNameTextBox;
        private System.Windows.Forms.DataGridView _planesGridView;
        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.TextBox _destinationCityTextBox;
        private System.Windows.Forms.TextBox _originCityTextBox;
        private System.Windows.Forms.TextBox _originCodeTextBox;
        private System.Windows.Forms.Button _destinationSelectButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button _originSelectButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox _destinationCodeTextBox;
        private System.Windows.Forms.MaskedTextBox _departureTimePicker;
        private System.Windows.Forms.MaskedTextBox _flightDurationPicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn _nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _availableSeatcColumn;
    }
}