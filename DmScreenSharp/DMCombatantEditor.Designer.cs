namespace DmScreenSharp.Components {
  partial class DMCombatantEditor {
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.label1 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.txtName = new System.Windows.Forms.TextBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.numMaxHp = new System.Windows.Forms.NumericUpDown();
      this.label6 = new System.Windows.Forms.Label();
      this.numCurrHp = new System.Windows.Forms.NumericUpDown();
      this.label2 = new System.Windows.Forms.Label();
      this.panel3 = new System.Windows.Forms.Panel();
      this.numPosY = new System.Windows.Forms.NumericUpDown();
      this.label7 = new System.Windows.Forms.Label();
      this.numPosX = new System.Windows.Forms.NumericUpDown();
      this.label3 = new System.Windows.Forms.Label();
      this.panel4 = new System.Windows.Forms.Panel();
      this.numSizeH = new System.Windows.Forms.NumericUpDown();
      this.label8 = new System.Windows.Forms.Label();
      this.numSizeW = new System.Windows.Forms.NumericUpDown();
      this.label4 = new System.Windows.Forms.Label();
      this.panel5 = new System.Windows.Forms.Panel();
      this.chkVisible = new System.Windows.Forms.CheckBox();
      this.chkPlayer = new System.Windows.Forms.CheckBox();
      this.numInit = new System.Windows.Forms.NumericUpDown();
      this.label5 = new System.Windows.Forms.Label();
      this.panel6 = new System.Windows.Forms.Panel();
      this.panel7 = new System.Windows.Forms.Panel();
      this.imgPortrait = new System.Windows.Forms.PictureBox();
      this.button1 = new System.Windows.Forms.Button();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numMaxHp)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numCurrHp)).BeginInit();
      this.panel3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numPosY)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numPosX)).BeginInit();
      this.panel4.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numSizeH)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numSizeW)).BeginInit();
      this.panel5.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numInit)).BeginInit();
      this.panel6.SuspendLayout();
      this.panel7.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.imgPortrait)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Dock = System.Windows.Forms.DockStyle.Left;
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "Name:";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.txtName);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(234, 20);
      this.panel1.TabIndex = 1;
      // 
      // txtName
      // 
      this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtName.Location = new System.Drawing.Point(35, 0);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(199, 20);
      this.txtName.TabIndex = 2;
      this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.numMaxHp);
      this.panel2.Controls.Add(this.label6);
      this.panel2.Controls.Add(this.numCurrHp);
      this.panel2.Controls.Add(this.label2);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(0, 20);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(234, 20);
      this.panel2.TabIndex = 2;
      // 
      // numMaxHp
      // 
      this.numMaxHp.Dock = System.Windows.Forms.DockStyle.Left;
      this.numMaxHp.Location = new System.Drawing.Point(134, 0);
      this.numMaxHp.Name = "numMaxHp";
      this.numMaxHp.Size = new System.Drawing.Size(64, 20);
      this.numMaxHp.TabIndex = 3;
      this.numMaxHp.ValueChanged += new System.EventHandler(this.numMaxHp_ValueChanged);
      // 
      // label6
      // 
      this.label6.Dock = System.Windows.Forms.DockStyle.Left;
      this.label6.Location = new System.Drawing.Point(119, 0);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(15, 20);
      this.label6.TabIndex = 4;
      this.label6.Text = "/";
      this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // numCurrHp
      // 
      this.numCurrHp.Dock = System.Windows.Forms.DockStyle.Left;
      this.numCurrHp.Location = new System.Drawing.Point(55, 0);
      this.numCurrHp.Name = "numCurrHp";
      this.numCurrHp.Size = new System.Drawing.Size(64, 20);
      this.numCurrHp.TabIndex = 2;
      this.numCurrHp.ValueChanged += new System.EventHandler(this.numCurrHp_ValueChanged);
      // 
      // label2
      // 
      this.label2.Dock = System.Windows.Forms.DockStyle.Left;
      this.label2.Location = new System.Drawing.Point(0, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(55, 20);
      this.label2.TabIndex = 0;
      this.label2.Text = "HP:";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.numPosY);
      this.panel3.Controls.Add(this.label7);
      this.panel3.Controls.Add(this.numPosX);
      this.panel3.Controls.Add(this.label3);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel3.Location = new System.Drawing.Point(0, 60);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(234, 20);
      this.panel3.TabIndex = 3;
      // 
      // numPosY
      // 
      this.numPosY.Dock = System.Windows.Forms.DockStyle.Left;
      this.numPosY.Location = new System.Drawing.Point(134, 0);
      this.numPosY.Name = "numPosY";
      this.numPosY.Size = new System.Drawing.Size(64, 20);
      this.numPosY.TabIndex = 6;
      this.numPosY.ValueChanged += new System.EventHandler(this.numPosY_ValueChanged);
      // 
      // label7
      // 
      this.label7.Dock = System.Windows.Forms.DockStyle.Left;
      this.label7.Location = new System.Drawing.Point(119, 0);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(15, 20);
      this.label7.TabIndex = 7;
      this.label7.Text = ",";
      this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // numPosX
      // 
      this.numPosX.Dock = System.Windows.Forms.DockStyle.Left;
      this.numPosX.Location = new System.Drawing.Point(55, 0);
      this.numPosX.Name = "numPosX";
      this.numPosX.Size = new System.Drawing.Size(64, 20);
      this.numPosX.TabIndex = 5;
      this.numPosX.ValueChanged += new System.EventHandler(this.numPosX_ValueChanged);
      // 
      // label3
      // 
      this.label3.Dock = System.Windows.Forms.DockStyle.Left;
      this.label3.Location = new System.Drawing.Point(0, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(55, 20);
      this.label3.TabIndex = 0;
      this.label3.Text = "Position:";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // panel4
      // 
      this.panel4.Controls.Add(this.numSizeH);
      this.panel4.Controls.Add(this.label8);
      this.panel4.Controls.Add(this.numSizeW);
      this.panel4.Controls.Add(this.label4);
      this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel4.Location = new System.Drawing.Point(0, 80);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(234, 20);
      this.panel4.TabIndex = 4;
      // 
      // numSizeH
      // 
      this.numSizeH.Dock = System.Windows.Forms.DockStyle.Left;
      this.numSizeH.Location = new System.Drawing.Point(134, 0);
      this.numSizeH.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numSizeH.Name = "numSizeH";
      this.numSizeH.Size = new System.Drawing.Size(64, 20);
      this.numSizeH.TabIndex = 6;
      this.numSizeH.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numSizeH.ValueChanged += new System.EventHandler(this.numSizeH_ValueChanged);
      // 
      // label8
      // 
      this.label8.Dock = System.Windows.Forms.DockStyle.Left;
      this.label8.Location = new System.Drawing.Point(119, 0);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(15, 20);
      this.label8.TabIndex = 7;
      this.label8.Text = "x";
      this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // numSizeW
      // 
      this.numSizeW.Dock = System.Windows.Forms.DockStyle.Left;
      this.numSizeW.Location = new System.Drawing.Point(55, 0);
      this.numSizeW.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numSizeW.Name = "numSizeW";
      this.numSizeW.Size = new System.Drawing.Size(64, 20);
      this.numSizeW.TabIndex = 5;
      this.numSizeW.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numSizeW.ValueChanged += new System.EventHandler(this.numSizeW_ValueChanged);
      // 
      // label4
      // 
      this.label4.Dock = System.Windows.Forms.DockStyle.Left;
      this.label4.Location = new System.Drawing.Point(0, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(55, 20);
      this.label4.TabIndex = 0;
      this.label4.Text = "Size:";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // panel5
      // 
      this.panel5.Controls.Add(this.chkVisible);
      this.panel5.Controls.Add(this.chkPlayer);
      this.panel5.Controls.Add(this.numInit);
      this.panel5.Controls.Add(this.label5);
      this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel5.Location = new System.Drawing.Point(0, 40);
      this.panel5.Name = "panel5";
      this.panel5.Size = new System.Drawing.Size(234, 20);
      this.panel5.TabIndex = 5;
      // 
      // chkVisible
      // 
      this.chkVisible.AutoSize = true;
      this.chkVisible.Dock = System.Windows.Forms.DockStyle.Left;
      this.chkVisible.Location = new System.Drawing.Point(174, 0);
      this.chkVisible.Name = "chkVisible";
      this.chkVisible.Size = new System.Drawing.Size(56, 20);
      this.chkVisible.TabIndex = 2;
      this.chkVisible.Text = "Visible";
      this.chkVisible.UseVisualStyleBackColor = true;
      this.chkVisible.CheckedChanged += new System.EventHandler(this.chkVisible_CheckedChanged);
      // 
      // chkPlayer
      // 
      this.chkPlayer.AutoSize = true;
      this.chkPlayer.Dock = System.Windows.Forms.DockStyle.Left;
      this.chkPlayer.Location = new System.Drawing.Point(119, 0);
      this.chkPlayer.Name = "chkPlayer";
      this.chkPlayer.Size = new System.Drawing.Size(55, 20);
      this.chkPlayer.TabIndex = 1;
      this.chkPlayer.Text = "Player";
      this.chkPlayer.UseVisualStyleBackColor = true;
      this.chkPlayer.CheckedChanged += new System.EventHandler(this.chkPlayer_CheckedChanged);
      // 
      // numInit
      // 
      this.numInit.Dock = System.Windows.Forms.DockStyle.Left;
      this.numInit.Location = new System.Drawing.Point(55, 0);
      this.numInit.Name = "numInit";
      this.numInit.Size = new System.Drawing.Size(64, 20);
      this.numInit.TabIndex = 3;
      this.numInit.ValueChanged += new System.EventHandler(this.numInit_ValueChanged);
      // 
      // label5
      // 
      this.label5.Dock = System.Windows.Forms.DockStyle.Left;
      this.label5.Location = new System.Drawing.Point(0, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(55, 20);
      this.label5.TabIndex = 0;
      this.label5.Text = " Initiative:";
      this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // panel6
      // 
      this.panel6.Controls.Add(this.panel7);
      this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel6.Location = new System.Drawing.Point(0, 100);
      this.panel6.Name = "panel6";
      this.panel6.Size = new System.Drawing.Size(234, 108);
      this.panel6.TabIndex = 6;
      // 
      // panel7
      // 
      this.panel7.Controls.Add(this.imgPortrait);
      this.panel7.Controls.Add(this.button1);
      this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel7.Location = new System.Drawing.Point(0, 0);
      this.panel7.Name = "panel7";
      this.panel7.Size = new System.Drawing.Size(82, 108);
      this.panel7.TabIndex = 0;
      // 
      // imgPortrait
      // 
      this.imgPortrait.Dock = System.Windows.Forms.DockStyle.Fill;
      this.imgPortrait.Location = new System.Drawing.Point(0, 26);
      this.imgPortrait.Name = "imgPortrait";
      this.imgPortrait.Size = new System.Drawing.Size(82, 82);
      this.imgPortrait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.imgPortrait.TabIndex = 1;
      this.imgPortrait.TabStop = false;
      // 
      // button1
      // 
      this.button1.Dock = System.Windows.Forms.DockStyle.Top;
      this.button1.Location = new System.Drawing.Point(0, 0);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(82, 26);
      this.button1.TabIndex = 1;
      this.button1.Text = "portrait";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // DMCombatantEditor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(234, 209);
      this.Controls.Add(this.panel6);
      this.Controls.Add(this.panel4);
      this.Controls.Add(this.panel3);
      this.Controls.Add(this.panel5);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "DMCombatantEditor";
      this.Text = "DMCombatantEditor";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DMCombatantEditor_FormClosing);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.numMaxHp)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numCurrHp)).EndInit();
      this.panel3.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.numPosY)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numPosX)).EndInit();
      this.panel4.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.numSizeH)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numSizeW)).EndInit();
      this.panel5.ResumeLayout(false);
      this.panel5.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numInit)).EndInit();
      this.panel6.ResumeLayout(false);
      this.panel7.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.imgPortrait)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Panel panel5;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.NumericUpDown numMaxHp;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.NumericUpDown numCurrHp;
    private System.Windows.Forms.CheckBox chkVisible;
    private System.Windows.Forms.CheckBox chkPlayer;
    private System.Windows.Forms.NumericUpDown numInit;
    private System.Windows.Forms.Panel panel6;
    private System.Windows.Forms.Panel panel7;
    private System.Windows.Forms.PictureBox imgPortrait;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.NumericUpDown numPosY;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.NumericUpDown numPosX;
    private System.Windows.Forms.NumericUpDown numSizeH;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.NumericUpDown numSizeW;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
  }
}