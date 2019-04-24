namespace VelibClient
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numStation = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nameLabel = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bank = new System.Windows.Forms.TextBox();
            this.search_bikes = new System.Windows.Forms.Label();
            this.num_bikes = new System.Windows.Forms.TextBox();
            this.no_res = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numOfStation = new System.Windows.Forms.TextBox();
            this.bikeStands = new System.Windows.Forms.TextBox();
            this.available_stands = new System.Windows.Forms.TextBox();
            this.available_bikes = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.list = new System.Windows.Forms.ListBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.title = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.total = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numStation
            // 
            this.numStation.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numStation.Location = new System.Drawing.Point(744, 57);
            this.numStation.Name = "numStation";
            this.numStation.Size = new System.Drawing.Size(174, 28);
            this.numStation.TabIndex = 0;
            this.numStation.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nameLabel.Location = new System.Drawing.Point(422, 51);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(207, 35);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name of Station:";
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.Location = new System.Drawing.Point(373, 328);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(0, 18);
            this.answer.TabIndex = 5;
            this.answer.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 493);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 21);
            this.label3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(3, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 35);
            this.label4.TabIndex = 12;
            this.label4.Text = "Bike stands";
            // 
            // bank
            // 
            this.bank.Location = new System.Drawing.Point(317, 225);
            this.bank.Name = "bank";
            this.bank.Size = new System.Drawing.Size(171, 28);
            this.bank.TabIndex = 15;
            // 
            // search_bikes
            // 
            this.search_bikes.AutoSize = true;
            this.search_bikes.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_bikes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.search_bikes.Location = new System.Drawing.Point(422, 114);
            this.search_bikes.Name = "search_bikes";
            this.search_bikes.Size = new System.Drawing.Size(316, 35);
            this.search_bikes.TabIndex = 16;
            this.search_bikes.Text = "Number of available bikes:";
            this.search_bikes.Click += new System.EventHandler(this.label6_Click);
            // 
            // num_bikes
            // 
            this.num_bikes.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_bikes.Location = new System.Drawing.Point(744, 120);
            this.num_bikes.Name = "num_bikes";
            this.num_bikes.Size = new System.Drawing.Size(174, 28);
            this.num_bikes.TabIndex = 17;
            this.num_bikes.TextChanged += new System.EventHandler(this.num_bikes_TextChanged);
            // 
            // no_res
            // 
            this.no_res.AutoSize = true;
            this.no_res.Location = new System.Drawing.Point(759, 197);
            this.no_res.Name = "no_res";
            this.no_res.Size = new System.Drawing.Size(0, 18);
            this.no_res.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 35);
            this.label6.TabIndex = 6;
            this.label6.Text = "N. Station";
            this.label6.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(3, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 35);
            this.label7.TabIndex = 7;
            this.label7.Text = "Available bikes";
            this.label7.Click += new System.EventHandler(this.label2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(3, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(249, 35);
            this.label8.TabIndex = 8;
            this.label8.Text = "Available bike stands";
            // 
            // numOfStation
            // 
            this.numOfStation.Location = new System.Drawing.Point(317, 3);
            this.numOfStation.Name = "numOfStation";
            this.numOfStation.Size = new System.Drawing.Size(171, 28);
            this.numOfStation.TabIndex = 9;
            // 
            // bikeStands
            // 
            this.bikeStands.Location = new System.Drawing.Point(317, 53);
            this.bikeStands.Name = "bikeStands";
            this.bikeStands.Size = new System.Drawing.Size(171, 28);
            this.bikeStands.TabIndex = 10;
            // 
            // available_stands
            // 
            this.available_stands.Location = new System.Drawing.Point(317, 111);
            this.available_stands.Name = "available_stands";
            this.available_stands.Size = new System.Drawing.Size(171, 28);
            this.available_stands.TabIndex = 11;
            // 
            // available_bikes
            // 
            this.available_bikes.Location = new System.Drawing.Point(317, 171);
            this.available_bikes.Name = "available_bikes";
            this.available_bikes.Size = new System.Drawing.Size(171, 28);
            this.available_bikes.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(3, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(233, 35);
            this.label10.TabIndex = 14;
            this.label10.Text = "Bank card payment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 23;
            // 
            // table
            // 
            this.table.ColumnCount = 2;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.15479F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.84521F));
            this.table.Controls.Add(this.label6, 0, 0);
            this.table.Controls.Add(this.label4, 0, 1);
            this.table.Controls.Add(this.label8, 0, 2);
            this.table.Controls.Add(this.label7, 0, 3);
            this.table.Controls.Add(this.label10, 0, 4);
            this.table.Controls.Add(this.available_stands, 1, 2);
            this.table.Controls.Add(this.bank, 1, 4);
            this.table.Controls.Add(this.available_bikes, 1, 3);
            this.table.Controls.Add(this.bikeStands, 1, 1);
            this.table.Controls.Add(this.numOfStation, 1, 0);
            this.table.Location = new System.Drawing.Point(427, 194);
            this.table.Name = "table";
            this.table.RowCount = 5;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.4F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.6F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.table.Size = new System.Drawing.Size(491, 271);
            this.table.TabIndex = 24;
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.ItemHeight = 18;
            this.list.Location = new System.Drawing.Point(41, 54);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(350, 418);
            this.list.TabIndex = 25;
            this.list.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(140)))), ((int)(((byte)(191)))));
            this.title.Location = new System.Drawing.Point(445, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(175, 83);
            this.title.TabIndex = 29;
            this.title.Text = "Vélib";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(951, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(363, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(175)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.total);
            this.panel1.Controls.Add(this.table);
            this.panel1.Controls.Add(this.list);
            this.panel1.Controls.Add(this.numStation);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.search_bikes);
            this.panel1.Controls.Add(this.num_bikes);
            this.panel1.Location = new System.Drawing.Point(34, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 483);
            this.panel1.TabIndex = 32;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(41, 23);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(48, 28);
            this.total.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(95, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 22);
            this.label5.TabIndex = 28;
            this.label5.Text = "stations";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1094, 635);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.no_res);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.answer);
            this.Name = "Form1";
            this.Text = "g";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numStation;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label answer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bank;
        private System.Windows.Forms.Label search_bikes;
        private System.Windows.Forms.TextBox num_bikes;
        private System.Windows.Forms.Label no_res;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox numOfStation;
        private System.Windows.Forms.TextBox bikeStands;
        private System.Windows.Forms.TextBox available_stands;
        private System.Windows.Forms.TextBox available_bikes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.ListBox list;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox total;
    }
}

