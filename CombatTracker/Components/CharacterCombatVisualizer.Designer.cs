namespace CombatTracker {
  partial class CharacterCombatVisualizer {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.lblName = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.bar1 = new CombatTracker.Components.Bar();
      this.lblHp = new System.Windows.Forms.Label();
      this.panel2 = new System.Windows.Forms.Panel();
      this.lblInit = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.panel1.SuspendLayout();
      this.bar1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblName
      // 
      this.lblName.BackColor = System.Drawing.Color.Transparent;
      this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblName.Location = new System.Drawing.Point(35, 0);
      this.lblName.Name = "lblName";
      this.lblName.Size = new System.Drawing.Size(86, 25);
      this.lblName.TabIndex = 0;
      this.lblName.Text = "Momiji Kazue";
      this.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // pictureBox1
      // 
      this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
      this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
      this.pictureBox1.Image = global::CombatTracker.Properties.Resources.Pin_057;
      this.pictureBox1.Location = new System.Drawing.Point(0, 0);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(50, 50);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 4;
      this.pictureBox1.TabStop = false;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.bar1);
      this.panel1.Controls.Add(this.panel2);
      this.panel1.Controls.Add(this.pictureBox1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(171, 50);
      this.panel1.TabIndex = 6;
      // 
      // bar1
      // 
      this.bar1.BackBar = System.Drawing.Color.DarkGray;
      this.bar1.BackColor = System.Drawing.Color.Transparent;
      this.bar1.Controls.Add(this.lblHp);
      this.bar1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.bar1.ForeBar = System.Drawing.Color.Green;
      this.bar1.ForeColor = System.Drawing.Color.White;
      this.bar1.Location = new System.Drawing.Point(50, 25);
      this.bar1.Name = "bar1";
      this.bar1.Size = new System.Drawing.Size(121, 25);
      this.bar1.TabIndex = 5;
      this.bar1.Value = 10;
      // 
      // lblHp
      // 
      this.lblHp.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblHp.Location = new System.Drawing.Point(0, 0);
      this.lblHp.Name = "lblHp";
      this.lblHp.Size = new System.Drawing.Size(121, 25);
      this.lblHp.TabIndex = 0;
      this.lblHp.Text = "label2";
      this.lblHp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.lblName);
      this.panel2.Controls.Add(this.lblInit);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(50, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(121, 25);
      this.panel2.TabIndex = 7;
      // 
      // lblInit
      // 
      this.lblInit.Dock = System.Windows.Forms.DockStyle.Left;
      this.lblInit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblInit.Location = new System.Drawing.Point(0, 0);
      this.lblInit.Name = "lblInit";
      this.lblInit.Size = new System.Drawing.Size(35, 25);
      this.lblInit.TabIndex = 6;
      this.lblInit.Text = "10";
      this.lblInit.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
      // 
      // CharacterCombatVisualizer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.Controls.Add(this.panel1);
      this.MinimumSize = new System.Drawing.Size(175, 50);
      this.Name = "CharacterCombatVisualizer";
      this.Size = new System.Drawing.Size(171, 50);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.panel1.ResumeLayout(false);
      this.bar1.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label lblName;
    private System.Windows.Forms.Label lblHp;
    private System.Windows.Forms.PictureBox pictureBox1;
    private CombatTracker.Components.Bar bar1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label lblInit;
  }
}
