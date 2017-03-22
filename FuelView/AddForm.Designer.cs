namespace FuelView
{
    partial class AddForm
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
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TrentTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.InsurTextBox = new System.Windows.Forms.TextBox();
            this.RentTextBox = new System.Windows.Forms.TextBox();
            this.TimeTextBox = new System.Windows.Forms.TextBox();
            this.ChargingCoastTextBox = new System.Windows.Forms.TextBox();
            this.ConsuptionTextBox = new System.Windows.Forms.TextBox();
            this.DistanceTextBox = new System.Windows.Forms.TextBox();
            this.CoastofTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Машина",
            "Гибрид",
            "Вертолет"});
            this.typeComboBox.Location = new System.Drawing.Point(268, 24);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(121, 21);
            this.typeComboBox.TabIndex = 0;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(88, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тип средства передвижения";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TrentTextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.InsurTextBox);
            this.groupBox1.Controls.Add(this.RentTextBox);
            this.groupBox1.Controls.Add(this.TimeTextBox);
            this.groupBox1.Controls.Add(this.ChargingCoastTextBox);
            this.groupBox1.Controls.Add(this.ConsuptionTextBox);
            this.groupBox1.Controls.Add(this.DistanceTextBox);
            this.groupBox1.Controls.Add(this.CoastofTextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 225);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры расчета";
            // 
            // TrentTextBox
            // 
            this.TrentTextBox.Location = new System.Drawing.Point(424, 198);
            this.TrentTextBox.MaxLength = 100;
            this.TrentTextBox.Name = "TrentTextBox";
            this.TrentTextBox.Size = new System.Drawing.Size(100, 20);
            this.TrentTextBox.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(7, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(331, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Растояние, которое можно проехать на одной батарее";
            // 
            // InsurTextBox
            // 
            this.InsurTextBox.Location = new System.Drawing.Point(424, 172);
            this.InsurTextBox.MaxLength = 100;
            this.InsurTextBox.Name = "InsurTextBox";
            this.InsurTextBox.Size = new System.Drawing.Size(100, 20);
            this.InsurTextBox.TabIndex = 14;
            this.InsurTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CoastofTextBox_KeyPress);
            // 
            // RentTextBox
            // 
            this.RentTextBox.Location = new System.Drawing.Point(424, 144);
            this.RentTextBox.MaxLength = 100;
            this.RentTextBox.Name = "RentTextBox";
            this.RentTextBox.Size = new System.Drawing.Size(100, 20);
            this.RentTextBox.TabIndex = 13;
            this.RentTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CoastofTextBox_KeyPress);
            // 
            // TimeTextBox
            // 
            this.TimeTextBox.Location = new System.Drawing.Point(424, 118);
            this.TimeTextBox.MaxLength = 100;
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.TimeTextBox.TabIndex = 12;
            this.TimeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CoastofTextBox_KeyPress);
            // 
            // ChargingCoastTextBox
            // 
            this.ChargingCoastTextBox.Location = new System.Drawing.Point(424, 92);
            this.ChargingCoastTextBox.MaxLength = 100;
            this.ChargingCoastTextBox.Name = "ChargingCoastTextBox";
            this.ChargingCoastTextBox.Size = new System.Drawing.Size(100, 20);
            this.ChargingCoastTextBox.TabIndex = 11;
            this.ChargingCoastTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CoastofTextBox_KeyPress);
            // 
            // ConsuptionTextBox
            // 
            this.ConsuptionTextBox.Location = new System.Drawing.Point(424, 40);
            this.ConsuptionTextBox.MaxLength = 100;
            this.ConsuptionTextBox.Name = "ConsuptionTextBox";
            this.ConsuptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.ConsuptionTextBox.TabIndex = 10;
            this.ConsuptionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CoastofTextBox_KeyPress);
            // 
            // DistanceTextBox
            // 
            this.DistanceTextBox.Location = new System.Drawing.Point(424, 66);
            this.DistanceTextBox.MaxLength = 100;
            this.DistanceTextBox.Name = "DistanceTextBox";
            this.DistanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.DistanceTextBox.TabIndex = 9;
            this.DistanceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CoastofTextBox_KeyPress);
            // 
            // CoastofTextBox
            // 
            this.CoastofTextBox.Location = new System.Drawing.Point(424, 15);
            this.CoastofTextBox.MaxLength = 100;
            this.CoastofTextBox.Name = "CoastofTextBox";
            this.CoastofTextBox.Size = new System.Drawing.Size(100, 20);
            this.CoastofTextBox.TabIndex = 8;
            this.CoastofTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CoastofTextBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(7, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Время аренды";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(7, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Стоимость страховки";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(278, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Стоимость аренды вертолета за 1 час полета";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Стоимость заряда одной батареи";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Расход бензина на 100 км";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Расстояние";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Цена бензина за литр";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(13, 296);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "Ок";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(102, 296);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(396, 296);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(141, 23);
            this.generateButton.TabIndex = 5;
            this.generateButton.Text = "Сгенерировать";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 333);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typeComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AddForm";
            this.Text = "Добавить информацию";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox InsurTextBox;
        private System.Windows.Forms.TextBox RentTextBox;
        private System.Windows.Forms.TextBox TimeTextBox;
        private System.Windows.Forms.TextBox ChargingCoastTextBox;
        private System.Windows.Forms.TextBox ConsuptionTextBox;
        private System.Windows.Forms.TextBox DistanceTextBox;
        private System.Windows.Forms.TextBox CoastofTextBox;
        private System.Windows.Forms.TextBox TrentTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button generateButton;
    }
}