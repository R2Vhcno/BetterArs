namespace BetterArs.Views {
    partial class AvailabilityForm {
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
            this._flightsGridView = new System.Windows.Forms.DataGridView();
            this._originDataColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._destinationDataColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._departureTimeDataColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._arrivalTimeDataColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._availableSeatsDataColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this._originCodeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._destinationCodeTextBox = new System.Windows.Forms.TextBox();
            this._originSelectButton = new System.Windows.Forms.Button();
            this._destinationSelectButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._destinationCityTextBox = new System.Windows.Forms.TextBox();
            this._originCityTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._departureDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._personCountTextBox = new System.Windows.Forms.TextBox();
            this._searchButton = new System.Windows.Forms.Button();
            this._bookButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this._newButton = new System.Windows.Forms.Button();
            this._editButton = new System.Windows.Forms.Button();
            this._deleteButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this._pnrButton = new System.Windows.Forms.Button();
            this._showAllButton = new System.Windows.Forms.Button();
            this._planesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._flightsGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _flightsGridView
            // 
            this._flightsGridView.AllowUserToAddRows = false;
            this._flightsGridView.AllowUserToDeleteRows = false;
            this._flightsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._flightsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._flightsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._originDataColumn,
            this._destinationDataColumn,
            this._departureTimeDataColumn,
            this._arrivalTimeDataColumn,
            this._availableSeatsDataColumn});
            this._flightsGridView.Location = new System.Drawing.Point(12, 95);
            this._flightsGridView.MultiSelect = false;
            this._flightsGridView.Name = "_flightsGridView";
            this._flightsGridView.ReadOnly = true;
            this._flightsGridView.Size = new System.Drawing.Size(791, 364);
            this._flightsGridView.TabIndex = 0;
            // 
            // _originDataColumn
            // 
            this._originDataColumn.DataPropertyName = "Origin";
            this._originDataColumn.HeaderText = "Аэропорт отправления";
            this._originDataColumn.Name = "_originDataColumn";
            this._originDataColumn.ReadOnly = true;
            // 
            // _destinationDataColumn
            // 
            this._destinationDataColumn.DataPropertyName = "Destination";
            this._destinationDataColumn.HeaderText = "Аэропорт прибытия";
            this._destinationDataColumn.Name = "_destinationDataColumn";
            this._destinationDataColumn.ReadOnly = true;
            // 
            // _departureTimeDataColumn
            // 
            this._departureTimeDataColumn.DataPropertyName = "DepartureTime";
            this._departureTimeDataColumn.HeaderText = "Время отправления";
            this._departureTimeDataColumn.Name = "_departureTimeDataColumn";
            this._departureTimeDataColumn.ReadOnly = true;
            // 
            // _arrivalTimeDataColumn
            // 
            this._arrivalTimeDataColumn.DataPropertyName = "ArrivalTime";
            this._arrivalTimeDataColumn.HeaderText = "Время прилёта";
            this._arrivalTimeDataColumn.Name = "_arrivalTimeDataColumn";
            this._arrivalTimeDataColumn.ReadOnly = true;
            // 
            // _availableSeatsDataColumn
            // 
            this._availableSeatsDataColumn.DataPropertyName = "AvailableSeats";
            this._availableSeatsDataColumn.HeaderText = "Кол-во свободных мест";
            this._availableSeatsDataColumn.Name = "_availableSeatsDataColumn";
            this._availableSeatsDataColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Аэропорт отпраления:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _originCodeTextBox
            // 
            this._originCodeTextBox.Location = new System.Drawing.Point(132, 19);
            this._originCodeTextBox.Name = "_originCodeTextBox";
            this._originCodeTextBox.Size = new System.Drawing.Size(47, 20);
            this._originCodeTextBox.TabIndex = 2;
            this._originCodeTextBox.Text = "*";
            this._originCodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._originCodeTextBox.Click += new System.EventHandler(this._originCodeTextBox_Click);
            this._originCodeTextBox.TextChanged += new System.EventHandler(this._originCodeTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Аэропорт прибытия:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _destinationCodeTextBox
            // 
            this._destinationCodeTextBox.Location = new System.Drawing.Point(132, 45);
            this._destinationCodeTextBox.Name = "_destinationCodeTextBox";
            this._destinationCodeTextBox.Size = new System.Drawing.Size(47, 20);
            this._destinationCodeTextBox.TabIndex = 4;
            this._destinationCodeTextBox.Text = "*";
            this._destinationCodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._destinationCodeTextBox.Click += new System.EventHandler(this._destinationCodeTextBox_Click);
            this._destinationCodeTextBox.TextChanged += new System.EventHandler(this._destinationCodeTextBox_TextChanged);
            // 
            // _originSelectButton
            // 
            this._originSelectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._originSelectButton.Location = new System.Drawing.Point(387, 17);
            this._originSelectButton.Name = "_originSelectButton";
            this._originSelectButton.Size = new System.Drawing.Size(25, 23);
            this._originSelectButton.TabIndex = 5;
            this._originSelectButton.Text = "...";
            this._originSelectButton.UseVisualStyleBackColor = true;
            this._originSelectButton.Click += new System.EventHandler(this._originSelectButton_Click);
            // 
            // _destinationSelectButton
            // 
            this._destinationSelectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._destinationSelectButton.Location = new System.Drawing.Point(387, 43);
            this._destinationSelectButton.Name = "_destinationSelectButton";
            this._destinationSelectButton.Size = new System.Drawing.Size(25, 23);
            this._destinationSelectButton.TabIndex = 6;
            this._destinationSelectButton.Text = "...";
            this._destinationSelectButton.UseVisualStyleBackColor = true;
            this._destinationSelectButton.Click += new System.EventHandler(this._destinationSelectButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(708, 77);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._destinationCityTextBox);
            this.groupBox1.Controls.Add(this._originCityTextBox);
            this.groupBox1.Controls.Add(this._originCodeTextBox);
            this.groupBox1.Controls.Add(this._destinationSelectButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this._originSelectButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this._destinationCodeTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Маршрут";
            // 
            // _destinationCityTextBox
            // 
            this._destinationCityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._destinationCityTextBox.Location = new System.Drawing.Point(185, 45);
            this._destinationCityTextBox.Name = "_destinationCityTextBox";
            this._destinationCityTextBox.ReadOnly = true;
            this._destinationCityTextBox.Size = new System.Drawing.Size(196, 20);
            this._destinationCityTextBox.TabIndex = 8;
            this._destinationCityTextBox.Text = "Все аэропорты";
            // 
            // _originCityTextBox
            // 
            this._originCityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._originCityTextBox.Location = new System.Drawing.Point(185, 19);
            this._originCityTextBox.Name = "_originCityTextBox";
            this._originCityTextBox.ReadOnly = true;
            this._originCityTextBox.Size = new System.Drawing.Size(196, 20);
            this._originCityTextBox.TabIndex = 7;
            this._originCityTextBox.Text = "Все аэропорты";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._departureDatePicker);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this._personCountTextBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(427, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 71);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация";
            // 
            // _departureDatePicker
            // 
            this._departureDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._departureDatePicker.Location = new System.Drawing.Point(48, 46);
            this._departureDatePicker.Name = "_departureDatePicker";
            this._departureDatePicker.Size = new System.Drawing.Size(224, 20);
            this._departureDatePicker.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Дата:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Количество человек:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _personCountTextBox
            // 
            this._personCountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._personCountTextBox.Location = new System.Drawing.Point(125, 19);
            this._personCountTextBox.Name = "_personCountTextBox";
            this._personCountTextBox.Size = new System.Drawing.Size(147, 20);
            this._personCountTextBox.TabIndex = 7;
            this._personCountTextBox.Text = "1";
            // 
            // _searchButton
            // 
            this._searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._searchButton.Location = new System.Drawing.Point(726, 12);
            this._searchButton.Name = "_searchButton";
            this._searchButton.Size = new System.Drawing.Size(77, 23);
            this._searchButton.TabIndex = 8;
            this._searchButton.Text = "Поиск";
            this._searchButton.UseVisualStyleBackColor = true;
            this._searchButton.Click += new System.EventHandler(this._searchButton_Click);
            // 
            // _bookButton
            // 
            this._bookButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._bookButton.Location = new System.Drawing.Point(3, 3);
            this._bookButton.Name = "_bookButton";
            this._bookButton.Size = new System.Drawing.Size(110, 23);
            this._bookButton.TabIndex = 9;
            this._bookButton.Text = "Оформить билет";
            this._bookButton.UseVisualStyleBackColor = true;
            this._bookButton.Click += new System.EventHandler(this._bookButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this._bookButton);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this._newButton);
            this.flowLayoutPanel1.Controls.Add(this._editButton);
            this.flowLayoutPanel1.Controls.Add(this._deleteButton);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this._pnrButton);
            this.flowLayoutPanel1.Controls.Add(this._planesButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 465);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(791, 29);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(119, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "|";
            // 
            // _newButton
            // 
            this._newButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._newButton.Location = new System.Drawing.Point(139, 3);
            this._newButton.Name = "_newButton";
            this._newButton.Size = new System.Drawing.Size(110, 23);
            this._newButton.TabIndex = 11;
            this._newButton.Text = "Создать рейс";
            this._newButton.UseVisualStyleBackColor = true;
            this._newButton.Click += new System.EventHandler(this._newButton_Click);
            // 
            // _editButton
            // 
            this._editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._editButton.Location = new System.Drawing.Point(255, 3);
            this._editButton.Name = "_editButton";
            this._editButton.Size = new System.Drawing.Size(129, 23);
            this._editButton.TabIndex = 12;
            this._editButton.Text = "Редактировать рейс";
            this._editButton.UseVisualStyleBackColor = true;
            this._editButton.Click += new System.EventHandler(this._editButton_Click);
            // 
            // _deleteButton
            // 
            this._deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._deleteButton.Location = new System.Drawing.Point(390, 3);
            this._deleteButton.Name = "_deleteButton";
            this._deleteButton.Size = new System.Drawing.Size(110, 23);
            this._deleteButton.TabIndex = 13;
            this._deleteButton.Text = "Удалить рейс";
            this._deleteButton.UseVisualStyleBackColor = true;
            this._deleteButton.Click += new System.EventHandler(this._deleteButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(506, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "|";
            // 
            // _pnrButton
            // 
            this._pnrButton.Location = new System.Drawing.Point(526, 3);
            this._pnrButton.Name = "_pnrButton";
            this._pnrButton.Size = new System.Drawing.Size(75, 23);
            this._pnrButton.TabIndex = 15;
            this._pnrButton.Text = "PNR";
            this._pnrButton.UseVisualStyleBackColor = true;
            this._pnrButton.Click += new System.EventHandler(this._pnrButton_Click);
            // 
            // _showAllButton
            // 
            this._showAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._showAllButton.Location = new System.Drawing.Point(726, 41);
            this._showAllButton.Name = "_showAllButton";
            this._showAllButton.Size = new System.Drawing.Size(77, 48);
            this._showAllButton.TabIndex = 11;
            this._showAllButton.Text = "Показать все";
            this._showAllButton.UseVisualStyleBackColor = true;
            this._showAllButton.Click += new System.EventHandler(this._showAllButton_Click);
            // 
            // _planesButton
            // 
            this._planesButton.Location = new System.Drawing.Point(607, 3);
            this._planesButton.Name = "_planesButton";
            this._planesButton.Size = new System.Drawing.Size(75, 23);
            this._planesButton.TabIndex = 16;
            this._planesButton.Text = "Авиапарк";
            this._planesButton.UseVisualStyleBackColor = true;
            this._planesButton.Click += new System.EventHandler(this._planesButton_Click);
            // 
            // AvailabilityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 506);
            this.Controls.Add(this._showAllButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this._searchButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this._flightsGridView);
            this.Name = "AvailabilityForm";
            this.Text = "АИС Авиалиния | Рейсы";
            this.Load += new System.EventHandler(this.AvailabilityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._flightsGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _flightsGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _originCodeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _destinationCodeTextBox;
        private System.Windows.Forms.Button _originSelectButton;
        private System.Windows.Forms.Button _destinationSelectButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _personCountTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button _searchButton;
        private System.Windows.Forms.DateTimePicker _departureDatePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button _bookButton;
        private System.Windows.Forms.TextBox _destinationCityTextBox;
        private System.Windows.Forms.TextBox _originCityTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn _originDataColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _destinationDataColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _departureTimeDataColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _arrivalTimeDataColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _availableSeatsDataColumn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button _newButton;
        private System.Windows.Forms.Button _editButton;
        private System.Windows.Forms.Button _deleteButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button _showAllButton;
        private System.Windows.Forms.Button _pnrButton;
        private System.Windows.Forms.Button _planesButton;
    }
}