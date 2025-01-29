namespace ManagmentPersonal
{
    partial class EventPersForm
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
            this.TableEvent = new System.Windows.Forms.DataGridView();
            this.BtnLast = new System.Windows.Forms.CheckBox();
            this.BtnNow = new System.Windows.Forms.CheckBox();
            this.BtnFuture = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.TypeBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddInfoBox = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TableEvent)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableEvent
            // 
            this.TableEvent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TableEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableEvent.Location = new System.Drawing.Point(13, 13);
            this.TableEvent.Name = "TableEvent";
            this.TableEvent.Size = new System.Drawing.Size(494, 425);
            this.TableEvent.TabIndex = 0;
            // 
            // BtnLast
            // 
            this.BtnLast.Appearance = System.Windows.Forms.Appearance.Button;
            this.BtnLast.AutoSize = true;
            this.BtnLast.Location = new System.Drawing.Point(15, 31);
            this.BtnLast.Name = "BtnLast";
            this.BtnLast.Size = new System.Drawing.Size(77, 23);
            this.BtnLast.TabIndex = 2;
            this.BtnLast.Text = "Прошедшие";
            this.BtnLast.UseVisualStyleBackColor = true;
            this.BtnLast.CheckedChanged += new System.EventHandler(this.BtnLast_CheckedChanged);
            // 
            // BtnNow
            // 
            this.BtnNow.Appearance = System.Windows.Forms.Appearance.Button;
            this.BtnNow.AutoSize = true;
            this.BtnNow.Location = new System.Drawing.Point(113, 31);
            this.BtnNow.Name = "BtnNow";
            this.BtnNow.Size = new System.Drawing.Size(62, 23);
            this.BtnNow.TabIndex = 3;
            this.BtnNow.Text = "Текущие";
            this.BtnNow.UseVisualStyleBackColor = true;
            this.BtnNow.CheckedChanged += new System.EventHandler(this.BtnNow_CheckedChanged);
            // 
            // BtnFuture
            // 
            this.BtnFuture.Appearance = System.Windows.Forms.Appearance.Button;
            this.BtnFuture.AutoSize = true;
            this.BtnFuture.Location = new System.Drawing.Point(196, 31);
            this.BtnFuture.Name = "BtnFuture";
            this.BtnFuture.Size = new System.Drawing.Size(61, 23);
            this.BtnFuture.TabIndex = 4;
            this.BtnFuture.Text = "Будущие";
            this.BtnFuture.UseVisualStyleBackColor = true;
            this.BtnFuture.CheckedChanged += new System.EventHandler(this.BtnFuture_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnFuture);
            this.groupBox1.Controls.Add(this.BtnLast);
            this.groupBox1.Controls.Add(this.BtnNow);
            this.groupBox1.Location = new System.Drawing.Point(513, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 79);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтр";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnAdd);
            this.groupBox2.Controls.Add(this.AddInfoBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TypeBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.EndDate);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.StartDate);
            this.groupBox2.Location = new System.Drawing.Point(513, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 153);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Добавить мероприятие";
            // 
            // StartDate
            // 
            this.StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartDate.Location = new System.Drawing.Point(138, 19);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(131, 20);
            this.StartDate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Начало";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Окончания";
            // 
            // EndDate
            // 
            this.EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndDate.Location = new System.Drawing.Point(138, 45);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(131, 20);
            this.EndDate.TabIndex = 2;
            // 
            // TypeBox
            // 
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.Items.AddRange(new object[] {
            "Обучение",
            "Отгул/Остутствие",
            "Отпуск"});
            this.TypeBox.Location = new System.Drawing.Point(138, 72);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(131, 21);
            this.TypeBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Тип мероприятия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Доп. информация";
            // 
            // AddInfoBox
            // 
            this.AddInfoBox.Location = new System.Drawing.Point(138, 100);
            this.AddInfoBox.Name = "AddInfoBox";
            this.AddInfoBox.Size = new System.Drawing.Size(131, 20);
            this.AddInfoBox.TabIndex = 7;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(138, 127);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(131, 23);
            this.BtnAdd.TabIndex = 8;
            this.BtnAdd.Text = "Добавить";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // EventPersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TableEvent);
            this.Name = "EventPersForm";
            this.Text = "EventPersForm";
            this.Load += new System.EventHandler(this.EventPersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableEvent)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TableEvent;
        private System.Windows.Forms.CheckBox BtnLast;
        private System.Windows.Forms.CheckBox BtnNow;
        private System.Windows.Forms.CheckBox BtnFuture;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox AddInfoBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TypeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.Label label1;
    }
}