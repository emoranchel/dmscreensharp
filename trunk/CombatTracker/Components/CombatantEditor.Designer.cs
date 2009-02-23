﻿namespace CombatTracker.Components {
  partial class CombatantEditor {
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
      this.textName = new System.Windows.Forms.TextBox();
      this.numCurrHp = new System.Windows.Forms.NumericUpDown();
      this.numMaxHp = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.checkPlayer = new System.Windows.Forms.CheckBox();
      this.btnRemove = new System.Windows.Forms.Button();
      this.btnImage = new System.Windows.Forms.Button();
      this.numPosY = new System.Windows.Forms.NumericUpDown();
      this.numPosX = new System.Windows.Forms.NumericUpDown();
      this.numInit = new System.Windows.Forms.NumericUpDown();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.numCurrHp)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numMaxHp)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numPosY)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numPosX)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numInit)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // textName
      // 
      this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textName.Location = new System.Drawing.Point(107, 3);
      this.textName.Name = "textName";
      this.textName.Size = new System.Drawing.Size(171, 26);
      this.textName.TabIndex = 0;
      this.textName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // numCurrHp
      // 
      this.numCurrHp.Location = new System.Drawing.Point(251, 40);
      this.numCurrHp.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.numCurrHp.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
      this.numCurrHp.Name = "numCurrHp";
      this.numCurrHp.Size = new System.Drawing.Size(71, 20);
      this.numCurrHp.TabIndex = 2;
      this.numCurrHp.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
      this.numCurrHp.Enter += new System.EventHandler(this.numericUpDown_Enter);
      // 
      // numMaxHp
      // 
      this.numMaxHp.Location = new System.Drawing.Point(346, 40);
      this.numMaxHp.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.numMaxHp.Name = "numMaxHp";
      this.numMaxHp.Size = new System.Drawing.Size(77, 20);
      this.numMaxHp.TabIndex = 3;
      this.numMaxHp.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
      this.numMaxHp.Enter += new System.EventHandler(this.numericUpDown_Enter);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(328, 42);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(12, 13);
      this.label1.TabIndex = 11;
      this.label1.Text = "/";
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // checkPlayer
      // 
      this.checkPlayer.AutoSize = true;
      this.checkPlayer.Location = new System.Drawing.Point(284, 7);
      this.checkPlayer.Name = "checkPlayer";
      this.checkPlayer.Size = new System.Drawing.Size(54, 17);
      this.checkPlayer.TabIndex = 1;
      this.checkPlayer.Text = "player";
      this.checkPlayer.UseVisualStyleBackColor = true;
      this.checkPlayer.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      // 
      // btnRemove
      // 
      this.btnRemove.Location = new System.Drawing.Point(348, 1);
      this.btnRemove.Name = "btnRemove";
      this.btnRemove.Size = new System.Drawing.Size(75, 23);
      this.btnRemove.TabIndex = 12;
      this.btnRemove.Text = "Remove";
      this.btnRemove.UseVisualStyleBackColor = true;
      this.btnRemove.Click += new System.EventHandler(this.button2_Click);
      // 
      // btnImage
      // 
      this.btnImage.Location = new System.Drawing.Point(110, 66);
      this.btnImage.Name = "btnImage";
      this.btnImage.Size = new System.Drawing.Size(75, 23);
      this.btnImage.TabIndex = 7;
      this.btnImage.Text = "Image";
      this.btnImage.UseVisualStyleBackColor = true;
      this.btnImage.Click += new System.EventHandler(this.button1_Click_1);
      // 
      // numPosY
      // 
      this.numPosY.Location = new System.Drawing.Point(346, 71);
      this.numPosY.Name = "numPosY";
      this.numPosY.Size = new System.Drawing.Size(77, 20);
      this.numPosY.TabIndex = 5;
      this.numPosY.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
      this.numPosY.Enter += new System.EventHandler(this.numericUpDown_Enter);
      // 
      // numPosX
      // 
      this.numPosX.Location = new System.Drawing.Point(251, 71);
      this.numPosX.Name = "numPosX";
      this.numPosX.Size = new System.Drawing.Size(71, 20);
      this.numPosX.TabIndex = 4;
      this.numPosX.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
      this.numPosX.Enter += new System.EventHandler(this.numericUpDown_Enter);
      // 
      // numInit
      // 
      this.numInit.Location = new System.Drawing.Point(159, 40);
      this.numInit.Name = "numInit";
      this.numInit.Size = new System.Drawing.Size(59, 20);
      this.numInit.TabIndex = 6;
      this.numInit.ValueChanged += new System.EventHandler(this.numericUpDown5_ValueChanged);
      this.numInit.Enter += new System.EventHandler(this.numericUpDown_Enter);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(104, 42);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(49, 13);
      this.label2.TabIndex = 8;
      this.label2.Text = "Initiative:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(224, 42);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(24, 13);
      this.label3.TabIndex = 10;
      this.label3.Text = "Hp:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(198, 73);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(47, 13);
      this.label4.TabIndex = 9;
      this.label4.Text = "Position:";
      // 
      // pictureBox1
      // 
      this.pictureBox1.Location = new System.Drawing.Point(1, 1);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(100, 100);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 13;
      this.pictureBox1.TabStop = false;
      // 
      // CombatantEditor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.numInit);
      this.Controls.Add(this.numPosY);
      this.Controls.Add(this.numPosX);
      this.Controls.Add(this.btnImage);
      this.Controls.Add(this.btnRemove);
      this.Controls.Add(this.checkPlayer);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.numMaxHp);
      this.Controls.Add(this.numCurrHp);
      this.Controls.Add(this.textName);
      this.Name = "CombatantEditor";
      this.Size = new System.Drawing.Size(431, 102);
      ((System.ComponentModel.ISupportInitialize)(this.numCurrHp)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numMaxHp)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numPosY)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numPosX)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numInit)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textName;
    private System.Windows.Forms.NumericUpDown numCurrHp;
    private System.Windows.Forms.NumericUpDown numMaxHp;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.CheckBox checkPlayer;
    private System.Windows.Forms.Button btnRemove;
    private System.Windows.Forms.Button btnImage;
    private System.Windows.Forms.NumericUpDown numPosY;
    private System.Windows.Forms.NumericUpDown numPosX;
    private System.Windows.Forms.NumericUpDown numInit;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}