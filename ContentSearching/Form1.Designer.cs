namespace ContentSearching
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnGetDirectory = new System.Windows.Forms.Button();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvResualts = new System.Windows.Forms.DataGridView();
            this.path = new System.Windows.Forms.DataGridViewLinkColumn();
            this.content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.بازکردنفولدردرپنجرهجدیدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtPhrase = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResualts)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetDirectory
            // 
            this.btnGetDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetDirectory.BackColor = System.Drawing.SystemColors.Control;
            this.btnGetDirectory.Location = new System.Drawing.Point(409, 12);
            this.btnGetDirectory.Name = "btnGetDirectory";
            this.btnGetDirectory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnGetDirectory.Size = new System.Drawing.Size(122, 23);
            this.btnGetDirectory.TabIndex = 0;
            this.btnGetDirectory.Text = "دایرکتوری را بگیر!";
            this.btnGetDirectory.UseVisualStyleBackColor = false;
            this.btnGetDirectory.Click += new System.EventHandler(this.btnGetDirectory_Click);
            // 
            // txtDirectory
            // 
            this.txtDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDirectory.Location = new System.Drawing.Point(12, 14);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(364, 21);
            this.txtDirectory.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.dgvResualts);
            this.panel1.Controls.Add(this.txtPhrase);
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 220);
            this.panel1.TabIndex = 2;
            // 
            // dgvResualts
            // 
            this.dgvResualts.AllowUserToAddRows = false;
            this.dgvResualts.AllowUserToDeleteRows = false;
            this.dgvResualts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResualts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResualts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvResualts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResualts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.path,
            this.content});
            this.dgvResualts.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvResualts.GridColor = System.Drawing.Color.White;
            this.dgvResualts.Location = new System.Drawing.Point(12, 69);
            this.dgvResualts.MultiSelect = false;
            this.dgvResualts.Name = "dgvResualts";
            this.dgvResualts.ReadOnly = true;
            this.dgvResualts.Size = new System.Drawing.Size(519, 137);
            this.dgvResualts.TabIndex = 2;
            this.dgvResualts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResualts_CellContentClick);
            this.dgvResualts.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResualts_CellContentDoubleClick);
            this.dgvResualts.SelectionChanged += new System.EventHandler(this.dgvResualts_SelectionChanged);
            // 
            // path
            // 
            this.path.HeaderText = "مسیر";
            this.path.Name = "path";
            this.path.ReadOnly = true;
            // 
            // content
            // 
            this.content.HeaderText = "محتوا";
            this.content.Name = "content";
            this.content.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.بازکردنفولدردرپنجرهجدیدToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(200, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // بازکردنفولدردرپنجرهجدیدToolStripMenuItem
            // 
            this.بازکردنفولدردرپنجرهجدیدToolStripMenuItem.Enabled = false;
            this.بازکردنفولدردرپنجرهجدیدToolStripMenuItem.Name = "بازکردنفولدردرپنجرهجدیدToolStripMenuItem";
            this.بازکردنفولدردرپنجرهجدیدToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.بازکردنفولدردرپنجرهجدیدToolStripMenuItem.Text = "باز کردن فولدر در پنجره جدید";
            this.بازکردنفولدردرپنجرهجدیدToolStripMenuItem.Click += new System.EventHandler(this.بازکردنفولدردرپنجرهجدیدToolStripMenuItem_Click);
            // 
            // txtPhrase
            // 
            this.txtPhrase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhrase.Location = new System.Drawing.Point(12, 24);
            this.txtPhrase.Name = "txtPhrase";
            this.txtPhrase.Size = new System.Drawing.Size(355, 21);
            this.txtPhrase.TabIndex = 1;
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.BackColor = System.Drawing.SystemColors.Control;
            this.btnFind.Location = new System.Drawing.Point(409, 15);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(122, 36);
            this.btnFind.TabIndex = 0;
            this.btnFind.Text = "عبارت روبرو را پیدا کن";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(555, 273);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDirectory);
            this.Controls.Add(this.btnGetDirectory);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Content Finder by Mohsenr1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResualts)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetDirectory;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtPhrase;
        private System.Windows.Forms.DataGridView dgvResualts;
        private System.Windows.Forms.DataGridViewLinkColumn path;
        private System.Windows.Forms.DataGridViewTextBoxColumn content;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem بازکردنفولدردرپنجرهجدیدToolStripMenuItem;
    }
}

