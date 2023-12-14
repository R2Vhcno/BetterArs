namespace BetterArs.Views {
    partial class EditPlaneForm {
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
            this._planeIdTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this._planeSeatIdTextBox = new System.Windows.Forms.TextBox();
            this._planeSeatRemoveButton = new System.Windows.Forms.Button();
            this._planeSeatEditButton = new System.Windows.Forms.Button();
            this._planeSeatAddButton = new System.Windows.Forms.Button();
            this._planeSeatFareTextBox = new System.Windows.Forms.TextBox();
            this._planeSeatClassComboBox = new System.Windows.Forms.ComboBox();
            this._planeSeatNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._planeSeatsGridView = new System.Windows.Forms.DataGridView();
            this._planeSeatName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._planeSeatFare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._planeNameTextBox = new System.Windows.Forms.TextBox();
            this._okButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._planeSeatsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _planeIdTextBox
            // 
            this._planeIdTextBox.Location = new System.Drawing.Point(104, 12);
            this._planeIdTextBox.Name = "_planeIdTextBox";
            this._planeIdTextBox.ReadOnly = true;
            this._planeIdTextBox.Size = new System.Drawing.Size(215, 20);
            this._planeIdTextBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this._planeSeatIdTextBox);
            this.groupBox1.Controls.Add(this._planeSeatRemoveButton);
            this.groupBox1.Controls.Add(this._planeSeatEditButton);
            this.groupBox1.Controls.Add(this._planeSeatAddButton);
            this.groupBox1.Controls.Add(this._planeSeatFareTextBox);
            this.groupBox1.Controls.Add(this._planeSeatClassComboBox);
            this.groupBox1.Controls.Add(this._planeSeatNameTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this._planeSeatsGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 279);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пассажирские места";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ид:";
            // 
            // _planeSeatIdTextBox
            // 
            this._planeSeatIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._planeSeatIdTextBox.Location = new System.Drawing.Point(98, 175);
            this._planeSeatIdTextBox.Name = "_planeSeatIdTextBox";
            this._planeSeatIdTextBox.ReadOnly = true;
            this._planeSeatIdTextBox.Size = new System.Drawing.Size(188, 20);
            this._planeSeatIdTextBox.TabIndex = 10;
            // 
            // _planeSeatRemoveButton
            // 
            this._planeSeatRemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._planeSeatRemoveButton.Location = new System.Drawing.Point(304, 233);
            this._planeSeatRemoveButton.Name = "_planeSeatRemoveButton";
            this._planeSeatRemoveButton.Size = new System.Drawing.Size(75, 23);
            this._planeSeatRemoveButton.TabIndex = 9;
            this._planeSeatRemoveButton.Text = "Удалить";
            this._planeSeatRemoveButton.UseVisualStyleBackColor = true;
            this._planeSeatRemoveButton.Click += new System.EventHandler(this._planeSeatRemoveButton_Click);
            // 
            // _planeSeatEditButton
            // 
            this._planeSeatEditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._planeSeatEditButton.Location = new System.Drawing.Point(304, 204);
            this._planeSeatEditButton.Name = "_planeSeatEditButton";
            this._planeSeatEditButton.Size = new System.Drawing.Size(75, 23);
            this._planeSeatEditButton.TabIndex = 8;
            this._planeSeatEditButton.Text = "Изменить";
            this._planeSeatEditButton.UseVisualStyleBackColor = true;
            this._planeSeatEditButton.Click += new System.EventHandler(this._planeSeatEditButton_Click);
            // 
            // _planeSeatAddButton
            // 
            this._planeSeatAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._planeSeatAddButton.Location = new System.Drawing.Point(304, 175);
            this._planeSeatAddButton.Name = "_planeSeatAddButton";
            this._planeSeatAddButton.Size = new System.Drawing.Size(75, 23);
            this._planeSeatAddButton.TabIndex = 7;
            this._planeSeatAddButton.Text = "Добавить";
            this._planeSeatAddButton.UseVisualStyleBackColor = true;
            this._planeSeatAddButton.Click += new System.EventHandler(this._planeSeatAddButton_Click);
            // 
            // _planeSeatFareTextBox
            // 
            this._planeSeatFareTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._planeSeatFareTextBox.Location = new System.Drawing.Point(98, 254);
            this._planeSeatFareTextBox.Name = "_planeSeatFareTextBox";
            this._planeSeatFareTextBox.Size = new System.Drawing.Size(188, 20);
            this._planeSeatFareTextBox.TabIndex = 6;
            // 
            // _planeSeatClassComboBox
            // 
            this._planeSeatClassComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._planeSeatClassComboBox.DisplayMember = "ClassName";
            this._planeSeatClassComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._planeSeatClassComboBox.FormattingEnabled = true;
            this._planeSeatClassComboBox.Location = new System.Drawing.Point(98, 227);
            this._planeSeatClassComboBox.Name = "_planeSeatClassComboBox";
            this._planeSeatClassComboBox.Size = new System.Drawing.Size(188, 21);
            this._planeSeatClassComboBox.TabIndex = 5;
            this._planeSeatClassComboBox.ValueMember = "Id";
            // 
            // _planeSeatNameTextBox
            // 
            this._planeSeatNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._planeSeatNameTextBox.Location = new System.Drawing.Point(98, 201);
            this._planeSeatNameTextBox.Name = "_planeSeatNameTextBox";
            this._planeSeatNameTextBox.Size = new System.Drawing.Size(188, 20);
            this._planeSeatNameTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Такса:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Класс:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Наименование:";
            // 
            // _planeSeatsGridView
            // 
            this._planeSeatsGridView.AllowUserToAddRows = false;
            this._planeSeatsGridView.AllowUserToDeleteRows = false;
            this._planeSeatsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._planeSeatsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._planeSeatsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._planeSeatName,
            this._planeSeatFare});
            this._planeSeatsGridView.Location = new System.Drawing.Point(6, 19);
            this._planeSeatsGridView.MultiSelect = false;
            this._planeSeatsGridView.Name = "_planeSeatsGridView";
            this._planeSeatsGridView.ReadOnly = true;
            this._planeSeatsGridView.Size = new System.Drawing.Size(373, 150);
            this._planeSeatsGridView.TabIndex = 0;
            this._planeSeatsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._planeSeatsGridView_CellClick);
            // 
            // _planeSeatName
            // 
            this._planeSeatName.DataPropertyName = "SeatName";
            this._planeSeatName.HeaderText = "Наименование";
            this._planeSeatName.Name = "_planeSeatName";
            this._planeSeatName.ReadOnly = true;
            // 
            // _planeSeatFare
            // 
            this._planeSeatFare.DataPropertyName = "Fare";
            this._planeSeatFare.HeaderText = "Такса";
            this._planeSeatFare.Name = "_planeSeatFare";
            this._planeSeatFare.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ид:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Наименование:";
            // 
            // _planeNameTextBox
            // 
            this._planeNameTextBox.Location = new System.Drawing.Point(104, 40);
            this._planeNameTextBox.Name = "_planeNameTextBox";
            this._planeNameTextBox.Size = new System.Drawing.Size(215, 20);
            this._planeNameTextBox.TabIndex = 14;
            // 
            // _okButton
            // 
            this._okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._okButton.Location = new System.Drawing.Point(322, 386);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(75, 23);
            this._okButton.TabIndex = 12;
            this._okButton.Text = "Ок";
            this._okButton.UseVisualStyleBackColor = true;
            this._okButton.Click += new System.EventHandler(this._okButton_Click);
            // 
            // _cancelButton
            // 
            this._cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Location = new System.Drawing.Point(241, 386);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(75, 23);
            this._cancelButton.TabIndex = 15;
            this._cancelButton.Text = "Отмена";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // EditPlaneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 421);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this._planeNameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._planeIdTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditPlaneForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование информации о самолёте";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._planeSeatsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _planeIdTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView _planeSeatsGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _planeSeatIdTextBox;
        private System.Windows.Forms.Button _planeSeatRemoveButton;
        private System.Windows.Forms.Button _planeSeatEditButton;
        private System.Windows.Forms.Button _planeSeatAddButton;
        private System.Windows.Forms.TextBox _planeSeatFareTextBox;
        private System.Windows.Forms.ComboBox _planeSeatClassComboBox;
        private System.Windows.Forms.TextBox _planeSeatNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _planeNameTextBox;
        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn _planeSeatName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _planeSeatFare;
    }
}