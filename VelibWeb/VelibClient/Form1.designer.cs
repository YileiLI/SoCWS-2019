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
            this.numStation = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.title = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bank = new System.Windows.Forms.TextBox();
            this.search_bikes = new System.Windows.Forms.Label();
            this.num_bikes = new System.Windows.Forms.TextBox();
            this.no_res = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
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
            this.label2 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // numStation
            // 
            this.numStation.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numStation.Location = new System.Drawing.Point(292, 224);
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
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial Narrow", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(306, 38);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(371, 52);
            this.title.TabIndex = 2;
            this.title.Text = "The  service of Vélib";
            this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(328, 148);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(138, 38);
            this.submit.TabIndex = 3;
            this.submit.Text = "search";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(25, 223);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(157, 29);
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
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Bike stands";
            // 
            // bank
            // 
            this.bank.Location = new System.Drawing.Point(264, 225);
            this.bank.Name = "bank";
            this.bank.Size = new System.Drawing.Size(100, 28);
            this.bank.TabIndex = 15;
            // 
            // search_bikes
            // 
            this.search_bikes.AutoSize = true;
            this.search_bikes.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_bikes.Location = new System.Drawing.Point(25, 284);
            this.search_bikes.Name = "search_bikes";
            this.search_bikes.Size = new System.Drawing.Size(242, 29);
            this.search_bikes.TabIndex = 16;
            this.search_bikes.Text = "Number of available bikes:";
            this.search_bikes.Click += new System.EventHandler(this.label6_Click);
            // 
            // num_bikes
            // 
            this.num_bikes.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_bikes.Location = new System.Drawing.Point(292, 285);
            this.num_bikes.Name = "num_bikes";
            this.num_bikes.Size = new System.Drawing.Size(174, 28);
            this.num_bikes.TabIndex = 17;
            // 
            // no_res
            // 
            this.no_res.AutoSize = true;
            this.no_res.Location = new System.Drawing.Point(759, 197);
            this.no_res.Name = "no_res";
            this.no_res.Size = new System.Drawing.Size(0, 18);
            this.no_res.TabIndex = 20;
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.Location = new System.Drawing.Point(35, 145);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(88, 37);
            this.city.TabIndex = 21;
            this.city.Text = "City:";
            this.city.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "N. Station";
            this.label6.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Available bikes";
            this.label7.Click += new System.EventHandler(this.label2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "Available bike stands";
            // 
            // numOfStation
            // 
            this.numOfStation.Location = new System.Drawing.Point(264, 3);
            this.numOfStation.Name = "numOfStation";
            this.numOfStation.Size = new System.Drawing.Size(100, 28);
            this.numOfStation.TabIndex = 9;
            // 
            // bikeStands
            // 
            this.bikeStands.Location = new System.Drawing.Point(264, 53);
            this.bikeStands.Name = "bikeStands";
            this.bikeStands.Size = new System.Drawing.Size(100, 28);
            this.bikeStands.TabIndex = 10;
            // 
            // available_stands
            // 
            this.available_stands.Location = new System.Drawing.Point(264, 111);
            this.available_stands.Name = "available_stands";
            this.available_stands.Size = new System.Drawing.Size(100, 28);
            this.available_stands.TabIndex = 11;
            // 
            // available_bikes
            // 
            this.available_bikes.Location = new System.Drawing.Point(264, 171);
            this.available_bikes.Name = "available_bikes";
            this.available_bikes.Size = new System.Drawing.Size(100, 28);
            this.available_bikes.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 21);
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
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.25893F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.74107F));
            this.table.Controls.Add(this.label6, 0, 0);
            this.table.Controls.Add(this.numOfStation, 1, 0);
            this.table.Controls.Add(this.label4, 0, 1);
            this.table.Controls.Add(this.label8, 0, 2);
            this.table.Controls.Add(this.label7, 0, 3);
            this.table.Controls.Add(this.label10, 0, 4);
            this.table.Controls.Add(this.bikeStands, 1, 1);
            this.table.Controls.Add(this.available_stands, 1, 2);
            this.table.Controls.Add(this.bank, 1, 4);
            this.table.Controls.Add(this.available_bikes, 1, 3);
            this.table.Location = new System.Drawing.Point(30, 352);
            this.table.Name = "table";
            this.table.RowCount = 5;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.4F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.6F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.table.Size = new System.Drawing.Size(448, 271);
            this.table.TabIndex = 24;
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.ItemHeight = 18;
            this.list.Location = new System.Drawing.Point(548, 187);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(444, 436);
            this.list.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(543, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 29);
            this.label2.TabIndex = 26;
            this.label2.Text = "List of stations :";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 150);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 28);
            this.textBox1.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 635);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.list);
            this.Controls.Add(this.table);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.city);
            this.Controls.Add(this.no_res);
            this.Controls.Add(this.num_bikes);
            this.Controls.Add(this.search_bikes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.title);
            this.Controls.Add(this.numStation);
            this.Name = "Form1";
            this.Text = "g";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numStation;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label answer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bank;
        private System.Windows.Forms.Label search_bikes;
        private System.Windows.Forms.TextBox num_bikes;
        private System.Windows.Forms.Label no_res;
        private System.Windows.Forms.Label city;
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
        private System.Windows.Forms.Label label2;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

