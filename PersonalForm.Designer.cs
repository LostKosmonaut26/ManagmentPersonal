namespace ManagmentPersonal
{
    partial class PersonalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalForm));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Административный департамент");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Академия Умные дороги");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Аппарат управления");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Департамент коммуникаций");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Департамент маркетинга и партнерских отношений");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Департамент по организации корпоративов");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Департамент по работе с персоналом");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Департамент по работе с промышленностью");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Департамент стратегии и планирования");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Управление Финансового планирования и контроля");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Финансово-экономический департамент");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Юридический департамент");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Дороги России", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TablePersonal = new System.Windows.Forms.DataGridView();
            this.TreeDepartment = new System.Windows.Forms.TreeView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablePersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-7, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1181, 100);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(148, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Организационная структура";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel3.Controls.Add(this.TablePersonal);
            this.panel3.Location = new System.Drawing.Point(389, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(768, 512);
            this.panel3.TabIndex = 3;
            // 
            // TablePersonal
            // 
            this.TablePersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablePersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablePersonal.Location = new System.Drawing.Point(3, 3);
            this.TablePersonal.Name = "TablePersonal";
            this.TablePersonal.Size = new System.Drawing.Size(762, 506);
            this.TablePersonal.TabIndex = 0;
            this.TablePersonal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablePersonal_CellContentClick);
            // 
            // TreeDepartment
            // 
            this.TreeDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TreeDepartment.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TreeDepartment.Location = new System.Drawing.Point(12, 105);
            this.TreeDepartment.Name = "TreeDepartment";
            treeNode1.Name = "Branch1";
            treeNode1.Text = "Административный департамент";
            treeNode2.Name = "Branch2";
            treeNode2.Text = "Академия Умные дороги";
            treeNode3.Name = "Branch3";
            treeNode3.Text = "Аппарат управления";
            treeNode4.Name = "Branch4";
            treeNode4.Text = "Департамент коммуникаций";
            treeNode5.Name = "Branch5";
            treeNode5.Text = "Департамент маркетинга и партнерских отношений";
            treeNode6.Name = "Branch6";
            treeNode6.Text = "Департамент по организации корпоративов";
            treeNode7.Name = "Branch7";
            treeNode7.Text = "Департамент по работе с персоналом";
            treeNode8.Name = "Branch8";
            treeNode8.Text = "Департамент по работе с промышленностью";
            treeNode9.Name = "Branch9";
            treeNode9.Text = "Департамент стратегии и планирования";
            treeNode10.Name = "Branch10";
            treeNode10.Text = "Управление Финансового планирования и контроля";
            treeNode11.Name = "Branch11";
            treeNode11.Text = "Финансово-экономический департамент";
            treeNode12.Name = "Branch12";
            treeNode12.Text = "Юридический департамент";
            treeNode13.Name = "NameDepartment";
            treeNode13.Text = "Дороги России";
            this.TreeDepartment.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13});
            this.TreeDepartment.Size = new System.Drawing.Size(353, 512);
            this.TreeDepartment.TabIndex = 13;
            this.TreeDepartment.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeDepartment_AfterSelect);
            this.TreeDepartment.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeDepartment_NodeMouseClick);
            // 
            // PersonalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 630);
            this.Controls.Add(this.TreeDepartment);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "PersonalForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TablePersonal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TreeView TreeDepartment;
        private System.Windows.Forms.DataGridView TablePersonal;
    }
}