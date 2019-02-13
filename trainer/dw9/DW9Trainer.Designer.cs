namespace dw9
{
    partial class DW9Trainer
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btn_points_save = new System.Windows.Forms.Button();
            this.lbl_points_title = new System.Windows.Forms.Label();
            this.lbl_character = new System.Windows.Forms.Label();
            this.lbl_character_title = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_status_title = new System.Windows.Forms.Label();
            this.btn_status = new System.Windows.Forms.Button();
            this.btn_read_character = new System.Windows.Forms.Button();
            this.tb_points = new System.Windows.Forms.TextBox();
            this.btn_points_load = new System.Windows.Forms.Button();
            this.lbl_money_title = new System.Windows.Forms.Label();
            this.tb_money = new System.Windows.Forms.TextBox();
            this.btn_money_load = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.Controls.Add(this.button1, 3, 3);
            this.tableLayoutPanel.Controls.Add(this.btn_money_load, 2, 3);
            this.tableLayoutPanel.Controls.Add(this.tb_money, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.lbl_money_title, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.btn_points_save, 3, 2);
            this.tableLayoutPanel.Controls.Add(this.lbl_points_title, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.lbl_character, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.lbl_character_title, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.lbl_status, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.lbl_status_title, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.btn_status, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.btn_read_character, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.tb_points, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.btn_points_load, 2, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(895, 448);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // btn_points_save
            // 
            this.btn_points_save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_points_save.Location = new System.Drawing.Point(807, 123);
            this.btn_points_save.Name = "btn_points_save";
            this.btn_points_save.Size = new System.Drawing.Size(85, 34);
            this.btn_points_save.TabIndex = 9;
            this.btn_points_save.Text = "保存";
            this.btn_points_save.UseVisualStyleBackColor = true;
            this.btn_points_save.Click += new System.EventHandler(this.btn_points_save_Click);
            // 
            // lbl_points_title
            // 
            this.lbl_points_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_points_title.Location = new System.Drawing.Point(3, 120);
            this.lbl_points_title.Name = "lbl_points_title";
            this.lbl_points_title.Size = new System.Drawing.Size(83, 40);
            this.lbl_points_title.TabIndex = 6;
            this.lbl_points_title.Text = "强化点数";
            this.lbl_points_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_character
            // 
            this.lbl_character.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_character.Location = new System.Drawing.Point(92, 60);
            this.lbl_character.Name = "lbl_character";
            this.lbl_character.Size = new System.Drawing.Size(620, 60);
            this.lbl_character.TabIndex = 4;
            this.lbl_character.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_character_title
            // 
            this.lbl_character_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_character_title.Location = new System.Drawing.Point(3, 60);
            this.lbl_character_title.Name = "lbl_character_title";
            this.lbl_character_title.Size = new System.Drawing.Size(83, 60);
            this.lbl_character_title.TabIndex = 3;
            this.lbl_character_title.Text = "当前人物";
            this.lbl_character_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_status
            // 
            this.lbl_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_status.Location = new System.Drawing.Point(92, 0);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(620, 60);
            this.lbl_status.TabIndex = 2;
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_status_title
            // 
            this.lbl_status_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_status_title.Location = new System.Drawing.Point(3, 0);
            this.lbl_status_title.Name = "lbl_status_title";
            this.lbl_status_title.Size = new System.Drawing.Size(83, 60);
            this.lbl_status_title.TabIndex = 0;
            this.lbl_status_title.Text = "游戏状态";
            this.lbl_status_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_status
            // 
            this.tableLayoutPanel.SetColumnSpan(this.btn_status, 2);
            this.btn_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_status.Location = new System.Drawing.Point(718, 3);
            this.btn_status.Name = "btn_status";
            this.btn_status.Size = new System.Drawing.Size(174, 54);
            this.btn_status.TabIndex = 1;
            this.btn_status.Text = "加载进程";
            this.btn_status.UseVisualStyleBackColor = true;
            this.btn_status.Click += new System.EventHandler(this.btn_status_Click);
            // 
            // btn_read_character
            // 
            this.tableLayoutPanel.SetColumnSpan(this.btn_read_character, 2);
            this.btn_read_character.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_read_character.Location = new System.Drawing.Point(718, 63);
            this.btn_read_character.Name = "btn_read_character";
            this.btn_read_character.Size = new System.Drawing.Size(174, 54);
            this.btn_read_character.TabIndex = 5;
            this.btn_read_character.Text = "加载人物ID";
            this.btn_read_character.UseVisualStyleBackColor = true;
            this.btn_read_character.Click += new System.EventHandler(this.btn_read_character_Click);
            // 
            // tb_points
            // 
            this.tb_points.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_points.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_points.HideSelection = false;
            this.tb_points.Location = new System.Drawing.Point(92, 123);
            this.tb_points.Name = "tb_points";
            this.tb_points.Size = new System.Drawing.Size(620, 33);
            this.tb_points.TabIndex = 7;
            this.tb_points.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_points_load
            // 
            this.btn_points_load.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_points_load.Location = new System.Drawing.Point(718, 123);
            this.btn_points_load.Name = "btn_points_load";
            this.btn_points_load.Size = new System.Drawing.Size(83, 34);
            this.btn_points_load.TabIndex = 8;
            this.btn_points_load.Text = "加载";
            this.btn_points_load.UseVisualStyleBackColor = true;
            this.btn_points_load.Click += new System.EventHandler(this.btn_points_load_Click);
            // 
            // lbl_money_title
            // 
            this.lbl_money_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_money_title.Location = new System.Drawing.Point(3, 160);
            this.lbl_money_title.Name = "lbl_money_title";
            this.lbl_money_title.Size = new System.Drawing.Size(83, 40);
            this.lbl_money_title.TabIndex = 10;
            this.lbl_money_title.Text = "金钱";
            this.lbl_money_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_money
            // 
            this.tb_money.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_money.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_money.HideSelection = false;
            this.tb_money.Location = new System.Drawing.Point(92, 163);
            this.tb_money.Name = "tb_money";
            this.tb_money.Size = new System.Drawing.Size(620, 33);
            this.tb_money.TabIndex = 11;
            this.tb_money.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_money_load
            // 
            this.btn_money_load.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_money_load.Location = new System.Drawing.Point(718, 163);
            this.btn_money_load.Name = "btn_money_load";
            this.btn_money_load.Size = new System.Drawing.Size(83, 34);
            this.btn_money_load.TabIndex = 12;
            this.btn_money_load.Text = "加载";
            this.btn_money_load.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(807, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 34);
            this.button1.TabIndex = 13;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DW9Trainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 448);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DW9Trainer";
            this.Text = "DW9 Trainer";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label lbl_status_title;
        private System.Windows.Forms.Button btn_status;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_character_title;
        private System.Windows.Forms.Label lbl_character;
        private System.Windows.Forms.Button btn_read_character;
        private System.Windows.Forms.Button btn_points_save;
        private System.Windows.Forms.TextBox tb_points;
        private System.Windows.Forms.Button btn_points_load;
        private System.Windows.Forms.Label lbl_points_title;
        private System.Windows.Forms.TextBox tb_money;
        private System.Windows.Forms.Label lbl_money_title;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_money_load;
    }
}

