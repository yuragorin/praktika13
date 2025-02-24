namespace studentys
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtRecordBookNumber = new TextBox();
            btnAdd = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Location = new Point(10, 9);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(438, 225);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(119, 26);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(118, 22);
            deleteToolStripMenuItem.Text = "Удалить";
            // 
            // txtName
            // 
            txtName.Location = new Point(481, 38);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(176, 23);
            txtName.TabIndex = 1;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(481, 75);
            txtSurname.Margin = new Padding(3, 2, 3, 2);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(176, 23);
            txtSurname.TabIndex = 2;
            // 
            // txtRecordBookNumber
            // 
            txtRecordBookNumber.Location = new Point(481, 112);
            txtRecordBookNumber.Margin = new Padding(3, 2, 3, 2);
            txtRecordBookNumber.Name = "txtRecordBookNumber";
            txtRecordBookNumber.Size = new Size(176, 23);
            txtRecordBookNumber.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(481, 150);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(175, 30);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(481, 20);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 5;
            label1.Text = "Имя:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(481, 58);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 6;
            label2.Text = "Фамилия:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(481, 95);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 7;
            label3.Text = "Номер зачетки:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 338);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(txtRecordBookNumber);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Список студентов";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtRecordBookNumber;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}