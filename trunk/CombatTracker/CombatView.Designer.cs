namespace CombatTracker {
  partial class CombatView {
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
      this.mapGroup = new System.Windows.Forms.GroupBox();
      this.map = new System.Windows.Forms.Panel();
      this.combatants = new System.Windows.Forms.GroupBox();
      this.container = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.label1 = new System.Windows.Forms.Label();
      this.gridPanel1 = new CombatTracker.Components.GridPanel();
      this.mapGroup.SuspendLayout();
      this.map.SuspendLayout();
      this.combatants.SuspendLayout();
      this.panel2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.SuspendLayout();
      // 
      // mapGroup
      // 
      this.mapGroup.Controls.Add(this.map);
      this.mapGroup.Dock = System.Windows.Forms.DockStyle.Fill;
      this.mapGroup.Location = new System.Drawing.Point(258, 0);
      this.mapGroup.Name = "mapGroup";
      this.mapGroup.Size = new System.Drawing.Size(328, 306);
      this.mapGroup.TabIndex = 0;
      this.mapGroup.TabStop = false;
      this.mapGroup.Text = "Map";
      // 
      // map
      // 
      this.map.AutoScroll = true;
      this.map.BackColor = System.Drawing.Color.GhostWhite;
      this.map.Controls.Add(this.gridPanel1);
      this.map.Dock = System.Windows.Forms.DockStyle.Fill;
      this.map.Location = new System.Drawing.Point(3, 16);
      this.map.Name = "map";
      this.map.Size = new System.Drawing.Size(322, 287);
      this.map.TabIndex = 0;
      // 
      // combatants
      // 
      this.combatants.BackColor = System.Drawing.Color.Transparent;
      this.combatants.Controls.Add(this.container);
      this.combatants.Controls.Add(this.panel2);
      this.combatants.Dock = System.Windows.Forms.DockStyle.Left;
      this.combatants.Location = new System.Drawing.Point(0, 0);
      this.combatants.Name = "combatants";
      this.combatants.Size = new System.Drawing.Size(258, 306);
      this.combatants.TabIndex = 1;
      this.combatants.TabStop = false;
      // 
      // container
      // 
      this.container.Dock = System.Windows.Forms.DockStyle.Fill;
      this.container.Location = new System.Drawing.Point(3, 60);
      this.container.Name = "container";
      this.container.Size = new System.Drawing.Size(252, 243);
      this.container.TabIndex = 0;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.groupBox3);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(3, 16);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(252, 44);
      this.panel2.TabIndex = 0;
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.label1);
      this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
      this.groupBox3.Location = new System.Drawing.Point(169, 0);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(83, 44);
      this.groupBox3.TabIndex = 0;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Current Turn";
      // 
      // label1
      // 
      this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(3, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(77, 25);
      this.label1.TabIndex = 0;
      this.label1.Text = "label1";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // gridPanel1
      // 
      this.gridPanel1.BackColor = System.Drawing.Color.Transparent;
      this.gridPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.gridPanel1.GridSize = 25;
      this.gridPanel1.Location = new System.Drawing.Point(0, 0);
      this.gridPanel1.Name = "gridPanel1";
      this.gridPanel1.Size = new System.Drawing.Size(500, 500);
      this.gridPanel1.TabIndex = 0;
      // 
      // CombatView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(586, 306);
      this.Controls.Add(this.mapGroup);
      this.Controls.Add(this.combatants);
      this.Name = "CombatView";
      this.Text = "Combatants";
      this.mapGroup.ResumeLayout(false);
      this.map.ResumeLayout(false);
      this.combatants.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox mapGroup;
    private System.Windows.Forms.GroupBox combatants;
    private CombatTracker.Components.GridPanel gridPanel1;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel map;
    private System.Windows.Forms.Panel container;
  }
}