namespace CombatTracker {
  partial class CombatScreen {
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
      this.container = new System.Windows.Forms.FlowLayoutPanel();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.newPlayerName = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.newPlayerHp = new System.Windows.Forms.NumericUpDown();
      this.label4 = new System.Windows.Forms.Label();
      this.newPlayerInit = new System.Windows.Forms.NumericUpDown();
      this.newPlayerIsPlayer = new System.Windows.Forms.CheckBox();
      this.btnAddPlayer = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.button2 = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.label3 = new System.Windows.Forms.Label();
      this.panel2 = new System.Windows.Forms.Panel();
      this.groupBox6 = new System.Windows.Forms.GroupBox();
      this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.label5 = new System.Windows.Forms.Label();
      this.button3 = new System.Windows.Forms.Button();
      this.groupBox5 = new System.Windows.Forms.GroupBox();
      this.trackBar1 = new System.Windows.Forms.TrackBar();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.newPlayerHp)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.newPlayerInit)).BeginInit();
      this.panel1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.panel2.SuspendLayout();
      this.groupBox6.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
      this.groupBox5.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
      this.SuspendLayout();
      // 
      // container
      // 
      this.container.Dock = System.Windows.Forms.DockStyle.Fill;
      this.container.Location = new System.Drawing.Point(3, 16);
      this.container.Name = "container";
      this.container.Size = new System.Drawing.Size(716, 477);
      this.container.TabIndex = 0;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.newPlayerName);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.newPlayerHp);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.newPlayerInit);
      this.groupBox1.Controls.Add(this.newPlayerIsPlayer);
      this.groupBox1.Controls.Add(this.btnAddPlayer);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox1.Location = new System.Drawing.Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(722, 41);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Add new";
      // 
      // newPlayerName
      // 
      this.newPlayerName.Dock = System.Windows.Forms.DockStyle.Fill;
      this.newPlayerName.Location = new System.Drawing.Point(38, 16);
      this.newPlayerName.Name = "newPlayerName";
      this.newPlayerName.Size = new System.Drawing.Size(302, 20);
      this.newPlayerName.TabIndex = 0;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Dock = System.Windows.Forms.DockStyle.Right;
      this.label2.Location = new System.Drawing.Point(340, 16);
      this.label2.Name = "label2";
      this.label2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
      this.label2.Size = new System.Drawing.Size(31, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Hp";
      // 
      // newPlayerHp
      // 
      this.newPlayerHp.Dock = System.Windows.Forms.DockStyle.Right;
      this.newPlayerHp.Location = new System.Drawing.Point(371, 16);
      this.newPlayerHp.Name = "newPlayerHp";
      this.newPlayerHp.Size = new System.Drawing.Size(89, 20);
      this.newPlayerHp.TabIndex = 1;
      this.newPlayerHp.Enter += new System.EventHandler(this.newPlayerHp_Enter);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Dock = System.Windows.Forms.DockStyle.Right;
      this.label4.Location = new System.Drawing.Point(460, 16);
      this.label4.Name = "label4";
      this.label4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
      this.label4.Size = new System.Drawing.Size(31, 13);
      this.label4.TabIndex = 5;
      this.label4.Text = "Init";
      // 
      // newPlayerInit
      // 
      this.newPlayerInit.Dock = System.Windows.Forms.DockStyle.Right;
      this.newPlayerInit.Location = new System.Drawing.Point(491, 16);
      this.newPlayerInit.Name = "newPlayerInit";
      this.newPlayerInit.Size = new System.Drawing.Size(89, 20);
      this.newPlayerInit.TabIndex = 2;
      this.newPlayerInit.Enter += new System.EventHandler(this.newPlayerInit_Enter);
      // 
      // newPlayerIsPlayer
      // 
      this.newPlayerIsPlayer.AutoSize = true;
      this.newPlayerIsPlayer.Dock = System.Windows.Forms.DockStyle.Right;
      this.newPlayerIsPlayer.Location = new System.Drawing.Point(580, 16);
      this.newPlayerIsPlayer.Name = "newPlayerIsPlayer";
      this.newPlayerIsPlayer.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
      this.newPlayerIsPlayer.Size = new System.Drawing.Size(64, 22);
      this.newPlayerIsPlayer.TabIndex = 3;
      this.newPlayerIsPlayer.Text = "player";
      this.newPlayerIsPlayer.UseVisualStyleBackColor = true;
      // 
      // btnAddPlayer
      // 
      this.btnAddPlayer.Dock = System.Windows.Forms.DockStyle.Right;
      this.btnAddPlayer.Location = new System.Drawing.Point(644, 16);
      this.btnAddPlayer.Name = "btnAddPlayer";
      this.btnAddPlayer.Size = new System.Drawing.Size(75, 22);
      this.btnAddPlayer.TabIndex = 4;
      this.btnAddPlayer.Text = "Add";
      this.btnAddPlayer.UseVisualStyleBackColor = true;
      this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Dock = System.Windows.Forms.DockStyle.Left;
      this.label1.Location = new System.Drawing.Point(3, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Name";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.groupBox1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(0, 545);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(722, 41);
      this.panel1.TabIndex = 2;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.container);
      this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox2.Location = new System.Drawing.Point(0, 49);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(722, 496);
      this.groupBox2.TabIndex = 0;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Combatants";
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.button2);
      this.groupBox3.Controls.Add(this.button1);
      this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox3.Location = new System.Drawing.Point(0, 0);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(186, 49);
      this.groupBox3.TabIndex = 3;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Combat";
      // 
      // button2
      // 
      this.button2.Dock = System.Windows.Forms.DockStyle.Right;
      this.button2.Enabled = false;
      this.button2.Location = new System.Drawing.Point(33, 16);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 30);
      this.button2.TabIndex = 2;
      this.button2.Text = "Prev";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button1
      // 
      this.button1.Dock = System.Windows.Forms.DockStyle.Right;
      this.button1.Location = new System.Drawing.Point(108, 16);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 30);
      this.button1.TabIndex = 1;
      this.button1.Text = "Next";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // groupBox4
      // 
      this.groupBox4.Controls.Add(this.label3);
      this.groupBox4.Dock = System.Windows.Forms.DockStyle.Right;
      this.groupBox4.Location = new System.Drawing.Point(637, 0);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(85, 49);
      this.groupBox4.TabIndex = 0;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Initiative";
      // 
      // label3
      // 
      this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(3, 16);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(79, 30);
      this.label3.TabIndex = 0;
      this.label3.Text = "label3";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.groupBox3);
      this.panel2.Controls.Add(this.groupBox6);
      this.panel2.Controls.Add(this.groupBox5);
      this.panel2.Controls.Add(this.groupBox4);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(722, 49);
      this.panel2.TabIndex = 2;
      // 
      // groupBox6
      // 
      this.groupBox6.Controls.Add(this.numericUpDown1);
      this.groupBox6.Controls.Add(this.checkBox1);
      this.groupBox6.Controls.Add(this.label5);
      this.groupBox6.Controls.Add(this.button3);
      this.groupBox6.Dock = System.Windows.Forms.DockStyle.Right;
      this.groupBox6.Location = new System.Drawing.Point(186, 0);
      this.groupBox6.Name = "groupBox6";
      this.groupBox6.Size = new System.Drawing.Size(305, 49);
      this.groupBox6.TabIndex = 3;
      this.groupBox6.TabStop = false;
      this.groupBox6.Text = "Background Image";
      // 
      // numericUpDown1
      // 
      this.numericUpDown1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.numericUpDown1.Location = new System.Drawing.Point(194, 16);
      this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numericUpDown1.Name = "numericUpDown1";
      this.numericUpDown1.Size = new System.Drawing.Size(65, 20);
      this.numericUpDown1.TabIndex = 2;
      this.numericUpDown1.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
      this.numericUpDown1.Leave += new System.EventHandler(this.numericUpDown1_Leave);
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Dock = System.Windows.Forms.DockStyle.Right;
      this.checkBox1.Location = new System.Drawing.Point(259, 16);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(43, 30);
      this.checkBox1.TabIndex = 3;
      this.checkBox1.Text = "Tile";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      // 
      // label5
      // 
      this.label5.Dock = System.Windows.Forms.DockStyle.Left;
      this.label5.Location = new System.Drawing.Point(78, 16);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(116, 30);
      this.label5.TabIndex = 1;
      this.label5.Text = "Resolution:\r\n(pixels per map square)";
      this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // button3
      // 
      this.button3.Dock = System.Windows.Forms.DockStyle.Left;
      this.button3.Location = new System.Drawing.Point(3, 16);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(75, 30);
      this.button3.TabIndex = 0;
      this.button3.Text = "browse";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // groupBox5
      // 
      this.groupBox5.Controls.Add(this.trackBar1);
      this.groupBox5.Dock = System.Windows.Forms.DockStyle.Right;
      this.groupBox5.Location = new System.Drawing.Point(491, 0);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Size = new System.Drawing.Size(146, 49);
      this.groupBox5.TabIndex = 1;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "Initiative";
      // 
      // trackBar1
      // 
      this.trackBar1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.trackBar1.LargeChange = 1;
      this.trackBar1.Location = new System.Drawing.Point(3, 16);
      this.trackBar1.Maximum = 6;
      this.trackBar1.Minimum = 1;
      this.trackBar1.Name = "trackBar1";
      this.trackBar1.Size = new System.Drawing.Size(140, 30);
      this.trackBar1.TabIndex = 3;
      this.trackBar1.Value = 1;
      this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // CombatScreen
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(722, 586);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Name = "CombatScreen";
      this.Text = "Form1";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.newPlayerHp)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.newPlayerInit)).EndInit();
      this.panel1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      this.groupBox4.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.groupBox6.ResumeLayout(false);
      this.groupBox6.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
      this.groupBox5.ResumeLayout(false);
      this.groupBox5.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.FlowLayoutPanel container;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox newPlayerName;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown newPlayerHp;
    private System.Windows.Forms.Button btnAddPlayer;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.CheckBox newPlayerIsPlayer;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.NumericUpDown newPlayerInit;
    private System.Windows.Forms.GroupBox groupBox5;
    private System.Windows.Forms.TrackBar trackBar1;
    private System.Windows.Forms.GroupBox groupBox6;
    private System.Windows.Forms.NumericUpDown numericUpDown1;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.CheckBox checkBox1;

  }
}

