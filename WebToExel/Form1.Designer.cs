namespace WebToExel
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
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.button_ToExel = new System.Windows.Forms.Button();
      this.textBox_web = new System.Windows.Forms.TextBox();
      this.button_Scrap = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(37, 57);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.Size = new System.Drawing.Size(722, 347);
      this.dataGridView1.TabIndex = 0;
      // 
      // button_ToExel
      // 
      this.button_ToExel.Location = new System.Drawing.Point(350, 415);
      this.button_ToExel.Name = "button_ToExel";
      this.button_ToExel.Size = new System.Drawing.Size(75, 23);
      this.button_ToExel.TabIndex = 1;
      this.button_ToExel.Text = "Copy to Exel";
      this.button_ToExel.UseVisualStyleBackColor = true;
      this.button_ToExel.Click += new System.EventHandler(this.button_ToExel_Click);
      // 
      // textBox_web
      // 
      this.textBox_web.Location = new System.Drawing.Point(37, 22);
      this.textBox_web.Name = "textBox_web";
      this.textBox_web.Size = new System.Drawing.Size(641, 20);
      this.textBox_web.TabIndex = 2;
      this.textBox_web.Text = "https://e.seb.lt/mainib/web.p?act=currencyrates&lang=LIT";
      this.textBox_web.TextChanged += new System.EventHandler(this.textBox_web_TextChanged);
      // 
      // button_Scrap
      // 
      this.button_Scrap.Location = new System.Drawing.Point(684, 20);
      this.button_Scrap.Name = "button_Scrap";
      this.button_Scrap.Size = new System.Drawing.Size(75, 23);
      this.button_Scrap.TabIndex = 3;
      this.button_Scrap.Text = "Scrap";
      this.button_Scrap.UseVisualStyleBackColor = true;
      this.button_Scrap.Click += new System.EventHandler(this.button_Scrap_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.button_Scrap);
      this.Controls.Add(this.textBox_web);
      this.Controls.Add(this.button_ToExel);
      this.Controls.Add(this.dataGridView1);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Button button_ToExel;
    private System.Windows.Forms.TextBox textBox_web;
    private System.Windows.Forms.Button button_Scrap;
  }
}

