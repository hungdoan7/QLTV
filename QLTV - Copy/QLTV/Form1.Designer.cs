namespace QLTV
{
    partial class Form1
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
            this.xem = new System.Windows.Forms.Button();
            this.dtg1 = new System.Windows.Forms.DataGridView();
            this.sua = new System.Windows.Forms.Button();
            this.dsNgmuon = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Lay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dk = new System.Windows.Forms.Button();
            this.Muonsach = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sap_xep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xem
            // 
            this.xem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xem.Location = new System.Drawing.Point(970, 147);
            this.xem.Name = "xem";
            this.xem.Size = new System.Drawing.Size(205, 54);
            this.xem.TabIndex = 0;
            this.xem.Text = "Tra cứu";
            this.xem.UseVisualStyleBackColor = true;
            this.xem.Click += new System.EventHandler(this.xem_Click);
            // 
            // dtg1
            // 
            this.dtg1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg1.Location = new System.Drawing.Point(12, 184);
            this.dtg1.Name = "dtg1";
            this.dtg1.Size = new System.Drawing.Size(891, 372);
            this.dtg1.TabIndex = 1;
            this.dtg1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg1_CellContentClick);
            // 
            // sua
            // 
            this.sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sua.Location = new System.Drawing.Point(970, 292);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(205, 54);
            this.sua.TabIndex = 2;
            this.sua.Text = "DS Độc Giả";
            this.sua.UseVisualStyleBackColor = true;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // dsNgmuon
            // 
            this.dsNgmuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dsNgmuon.Location = new System.Drawing.Point(970, 220);
            this.dsNgmuon.Name = "dsNgmuon";
            this.dsNgmuon.Size = new System.Drawing.Size(205, 54);
            this.dsNgmuon.TabIndex = 3;
            this.dsNgmuon.Text = "DS Mượn";
            this.dsNgmuon.UseVisualStyleBackColor = true;
            this.dsNgmuon.Click += new System.EventHandler(this.dsNgmuon_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(81, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // adToolStripMenuItem
            // 
            this.adToolStripMenuItem.Name = "adToolStripMenuItem";
            this.adToolStripMenuItem.Size = new System.Drawing.Size(80, 22);
            this.adToolStripMenuItem.Text = "1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem2.Text = "2";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem3.Text = "3";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "KhoaHoc",
            "ThamKhao",
            "GiaoTrinh"});
            this.comboBox1.Location = new System.Drawing.Point(970, 109);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // Lay
            // 
            this.Lay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lay.Location = new System.Drawing.Point(970, 12);
            this.Lay.Name = "Lay";
            this.Lay.Size = new System.Drawing.Size(208, 54);
            this.Lay.TabIndex = 6;
            this.Lay.Text = "Lấy dữ liệu";
            this.Lay.UseVisualStyleBackColor = true;
            this.Lay.Click += new System.EventHandler(this.Lay_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1002, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Chọn loại sách";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dk
            // 
            this.dk.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dk.Location = new System.Drawing.Point(970, 368);
            this.dk.Name = "dk";
            this.dk.Size = new System.Drawing.Size(205, 54);
            this.dk.TabIndex = 8;
            this.dk.Text = "Đăng kí";
            this.dk.UseVisualStyleBackColor = true;
            this.dk.Click += new System.EventHandler(this.dk_Click);
            // 
            // Muonsach
            // 
            this.Muonsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Muonsach.Location = new System.Drawing.Point(970, 441);
            this.Muonsach.Name = "Muonsach";
            this.Muonsach.Size = new System.Drawing.Size(205, 54);
            this.Muonsach.TabIndex = 9;
            this.Muonsach.Text = "Thành Viên";
            this.Muonsach.UseVisualStyleBackColor = true;
            this.Muonsach.Click += new System.EventHandler(this.Muonsach_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Sylfaen", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(236, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(551, 99);
            this.label2.TabIndex = 10;
            this.label2.Text = "QUẢN LÝ THƯ VIỆN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sap_xep
            // 
            this.sap_xep.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sap_xep.Location = new System.Drawing.Point(970, 512);
            this.sap_xep.Name = "sap_xep";
            this.sap_xep.Size = new System.Drawing.Size(205, 54);
            this.sap_xep.TabIndex = 11;
            this.sap_xep.Text = "Sắp Xếp";
            this.sap_xep.UseVisualStyleBackColor = true;
            this.sap_xep.Click += new System.EventHandler(this.sap_xep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 597);
            this.Controls.Add(this.sap_xep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Muonsach);
            this.Controls.Add(this.dk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lay);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dsNgmuon);
            this.Controls.Add(this.sua);
            this.Controls.Add(this.dtg1);
            this.Controls.Add(this.xem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button xem;
        private System.Windows.Forms.DataGridView dtg1;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button dsNgmuon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Lay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dk;
        private System.Windows.Forms.Button Muonsach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sap_xep;
    }
}

