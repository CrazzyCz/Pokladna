namespace Pokladna
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.čísloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.výdajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.příjmyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zůstatekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poznámkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 24);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(800, 426);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datumToolStripMenuItem,
            this.čísloToolStripMenuItem,
            this.popisToolStripMenuItem,
            this.výdajeToolStripMenuItem,
            this.příjmyToolStripMenuItem,
            this.zůstatekToolStripMenuItem,
            this.poznámkaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // datumToolStripMenuItem
            // 
            this.datumToolStripMenuItem.Name = "datumToolStripMenuItem";
            this.datumToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.datumToolStripMenuItem.Text = "Datum";
            // 
            // čísloToolStripMenuItem
            // 
            this.čísloToolStripMenuItem.Name = "čísloToolStripMenuItem";
            this.čísloToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.čísloToolStripMenuItem.Text = "Číslo";
            // 
            // popisToolStripMenuItem
            // 
            this.popisToolStripMenuItem.Name = "popisToolStripMenuItem";
            this.popisToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.popisToolStripMenuItem.Text = "Popis";
            // 
            // výdajeToolStripMenuItem
            // 
            this.výdajeToolStripMenuItem.Name = "výdajeToolStripMenuItem";
            this.výdajeToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.výdajeToolStripMenuItem.Text = "Výdaje";
            // 
            // příjmyToolStripMenuItem
            // 
            this.příjmyToolStripMenuItem.Name = "příjmyToolStripMenuItem";
            this.příjmyToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.příjmyToolStripMenuItem.Text = " Příjmy";
            // 
            // zůstatekToolStripMenuItem
            // 
            this.zůstatekToolStripMenuItem.Name = "zůstatekToolStripMenuItem";
            this.zůstatekToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.zůstatekToolStripMenuItem.Text = "Zůstatek";
            // 
            // poznámkaToolStripMenuItem
            // 
            this.poznámkaToolStripMenuItem.Name = "poznámkaToolStripMenuItem";
            this.poznámkaToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.poznámkaToolStripMenuItem.Text = "Poznámka";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

  }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem čísloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem popisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem výdajeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem příjmyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zůstatekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poznámkaToolStripMenuItem;
    }
}

