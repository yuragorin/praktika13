namespace studenti2
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
        this.dataGridView1 = new System.Windows.Forms.DataGridView();
        this.txtBrand = new System.Windows.Forms.TextBox();
        this.txtModel = new System.Windows.Forms.TextBox();
        this.txtYear = new System.Windows.Forms.TextBox();
        this.txtColor = new System.Windows.Forms.TextBox();
        this.txtVIN = new System.Windows.Forms.TextBox();
        this.btnAdd = new System.Windows.Forms.Button();
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.label4 = new System.Windows.Forms.Label();
        this.label5 = new System.Windows.Forms.Label();
        this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
        this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
        this.contextMenuStrip1.SuspendLayout();
        this.SuspendLayout();
        // 
        // dataGridView1
        // 
        this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
        this.dataGridView1.Location = new System.Drawing.Point(12, 12);
        this.dataGridView1.Name = "dataGridView1";
        this.dataGridView1.RowHeadersWidth = 51;
        this.dataGridView1.RowTemplate.Height = 29;
        this.dataGridView1.Size = new System.Drawing.Size(600, 300);
        this.dataGridView1.TabIndex = 0;
        // 
        // txtBrand
        // 
        this.txtBrand.Location = new System.Drawing.Point(650, 50);
        this.txtBrand.Name = "txtBrand";
        this.txtBrand.Size = new System.Drawing.Size(200, 27);
        this.txtBrand.TabIndex = 1;
        // 
        // txtModel
        // 
        this.txtModel.Location = new System.Drawing.Point(650, 100);
        this.txtModel.Name = "txtModel";
        this.txtModel.Size = new System.Drawing.Size(200, 27);
        this.txtModel.TabIndex = 2;
        // 
        // txtYear
        // 
        this.txtYear.Location = new System.Drawing.Point(650, 150);
        this.txtYear.Name = "txtYear";
        this.txtYear.Size = new System.Drawing.Size(200, 27);
        this.txtYear.TabIndex = 3;
        // 
        // txtColor
        // 
        this.txtColor.Location = new System.Drawing.Point(650, 200);
        this.txtColor.Name = "txtColor";
        this.txtColor.Size = new System.Drawing.Size(200, 27);
        this.txtColor.TabIndex = 4;
        // 
        // txtVIN
        // 
        this.txtVIN.Location = new System.Drawing.Point(650, 250);
        this.txtVIN.Name = "txtVIN";
        this.txtVIN.Size = new System.Drawing.Size(200, 27);
        this.txtVIN.TabIndex = 5;
        // 
        // btnAdd
        // 
        this.btnAdd.Location = new System.Drawing.Point(650, 300);
        this.btnAdd.Name = "btnAdd";
        this.btnAdd.Size = new System.Drawing.Size(200, 40);
        this.btnAdd.TabIndex = 6;
        this.btnAdd.Text = "Добавить";
        this.btnAdd.UseVisualStyleBackColor = true;
        this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(650, 27);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(54, 20);
        this.label1.TabIndex = 7;
        this.label1.Text = "Марка:";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(650, 77);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(61, 20);
        this.label2.TabIndex = 8;
        this.label2.Text = "Модель:";
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(650, 127);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(96, 20);
        this.label3.TabIndex = 9;
        this.label3.Text = "Год выпуска:";
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(650, 177);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(45, 20);
        this.label4.TabIndex = 10;
        this.label4.Text = "Цвет:";
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Location = new System.Drawing.Point(650, 227);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(69, 20);
        this.label5.TabIndex = 11;
        this.label5.Text = "VIN-код:";
        // 
        // contextMenuStrip1
        // 
        this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
        this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
        this.contextMenuStrip1.Name = "contextMenuStrip1";
        this.contextMenuStrip1.Size = new System.Drawing.Size(138, 28);
        // 
        // deleteToolStripMenuItem
        // 
        this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
        this.deleteToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
        this.deleteToolStripMenuItem.Text = "Удалить";
        this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(900, 450);
        this.Controls.Add(this.label5);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.btnAdd);
        this.Controls.Add(this.txtVIN);
        this.Controls.Add(this.txtColor);
        this.Controls.Add(this.txtYear);
        this.Controls.Add(this.txtModel);
        this.Controls.Add(this.txtBrand);
        this.Controls.Add(this.dataGridView1);
        this.Name = "Form1";
        this.Text = "Управление автомобилями";
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
        this.contextMenuStrip1.ResumeLayout(false);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.TextBox txtBrand;
    private System.Windows.Forms.TextBox txtModel;
    private System.Windows.Forms.TextBox txtYear;
    private System.Windows.Forms.TextBox txtColor;
    private System.Windows.Forms.TextBox txtVIN;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
}
}