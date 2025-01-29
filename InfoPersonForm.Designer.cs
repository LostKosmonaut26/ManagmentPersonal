namespace ManagmentPersonal
{
    partial class InfoPersonForm
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
            this.TablePerson = new System.Windows.Forms.DataGridView();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnEvents = new System.Windows.Forms.Button();
            this.BtnDismiss = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TablePerson)).BeginInit();
            this.SuspendLayout();
            // 
            // TablePerson
            // 
            this.TablePerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablePerson.Location = new System.Drawing.Point(13, 3);
            this.TablePerson.Name = "TablePerson";
            this.TablePerson.Size = new System.Drawing.Size(641, 63);
            this.TablePerson.TabIndex = 0;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(13, 164);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(188, 31);
            this.BtnSave.TabIndex = 1;
            this.BtnSave.Text = "Сохранить";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(12, 127);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(188, 31);
            this.BtnEdit.TabIndex = 2;
            this.BtnEdit.Text = " Редактирование";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnEvents
            // 
            this.BtnEvents.Location = new System.Drawing.Point(466, 164);
            this.BtnEvents.Name = "BtnEvents";
            this.BtnEvents.Size = new System.Drawing.Size(188, 31);
            this.BtnEvents.TabIndex = 3;
            this.BtnEvents.Text = "Список событий";
            this.BtnEvents.UseVisualStyleBackColor = true;
            this.BtnEvents.Click += new System.EventHandler(this.BtnEvents_Click);
            // 
            // BtnDismiss
            // 
            this.BtnDismiss.Location = new System.Drawing.Point(466, 127);
            this.BtnDismiss.Name = "BtnDismiss";
            this.BtnDismiss.Size = new System.Drawing.Size(188, 31);
            this.BtnDismiss.TabIndex = 4;
            this.BtnDismiss.Text = "Уволить";
            this.BtnDismiss.UseVisualStyleBackColor = true;
            this.BtnDismiss.Click += new System.EventHandler(this.BtnDismiss_Click);
            // 
            // InfoPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 207);
            this.Controls.Add(this.BtnDismiss);
            this.Controls.Add(this.BtnEvents);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TablePerson);
            this.Name = "InfoPersonForm";
            this.Text = "Карточка сотрудника";
            this.Load += new System.EventHandler(this.InfoPersonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablePerson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TablePerson;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnEvents;
        private System.Windows.Forms.Button BtnDismiss;
    }
}