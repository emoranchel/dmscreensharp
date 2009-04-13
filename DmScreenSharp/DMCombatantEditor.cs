using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DmScreenSharp.Entity;

namespace DmScreenSharp.Components {
  public partial class DMCombatantEditor : Form {
    private Combatant combatant;
    private CombatantUpdatedModifiedDelegate combatantUpdatedModifiedDelegate;
    public DMCombatantEditor(Combatant combatant) {
      this.combatant = combatant;
      InitializeComponent();
      combatantUpdatedModifiedDelegate = new CombatantUpdatedModifiedDelegate(combatant_Updated);
      combatant.Updated += new CombatantUpdatedModifiedDelegate(combatant_Updated);
      Combatant.sendAll(combatant, combatantUpdatedModifiedDelegate);
    }

    void combatant_Updated(Combatant source, Combatant.CombatantProperty property) {
      switch (property) {
        case Combatant.CombatantProperty.hp:
          numCurrHp.Value = source.CurrentHp;
          numMaxHp.Value = source.MaxHp;
          break;
        case Combatant.CombatantProperty.initiative:
          numInit.Value = source.Initiative;
          break;
        case Combatant.CombatantProperty.name:
          txtName.Text = source.Name;
          this.Text = source.Name;
          break;
        case Combatant.CombatantProperty.player:
          chkPlayer.Checked = source.Player;
          break;
        case Combatant.CombatantProperty.portrait:
          imgPortrait.Image = source.CharacterPortrait;
          break;
        case Combatant.CombatantProperty.position:
          numPosX.Value = source.Position.X;
          numPosY.Value = source.Position.Y;
          break;
        case Combatant.CombatantProperty.size:
          numSizeW.Value = source.Size.Width;
          numSizeH.Value = source.Size.Height;
          break;
        case Combatant.CombatantProperty.visible:
          chkVisible.Checked = source.Visible;
          break;
      }
    }

    private void DMCombatantEditor_FormClosing(object sender, FormClosingEventArgs e) {
      Program.Control.removeCombatantEditor(combatant);
    }

    private void txtName_TextChanged(object sender, EventArgs e) {
      combatant.Name = txtName.Text;
    }

    private void numCurrHp_ValueChanged(object sender, EventArgs e) {
      combatant.CurrentHp = (int)numCurrHp.Value;
    }

    private void numMaxHp_ValueChanged(object sender, EventArgs e) {
      combatant.MaxHp = (int)numMaxHp.Value;
    }

    private void numInit_ValueChanged(object sender, EventArgs e) {
      combatant.Initiative = (int)numInit.Value;
    }

    private void chkPlayer_CheckedChanged(object sender, EventArgs e) {
      combatant.Player = chkPlayer.Checked;
    }

    private void chkVisible_CheckedChanged(object sender, EventArgs e) {
      combatant.Visible = chkVisible.Checked;
    }

    private void numPosX_ValueChanged(object sender, EventArgs e) {
      combatant.Position = new Point((int)numPosX.Value, (int)numPosY.Value);
    }

    private void numPosY_ValueChanged(object sender, EventArgs e) {
      combatant.Position = new Point((int)numPosX.Value, (int)numPosY.Value);
    }

    private void numSizeW_ValueChanged(object sender, EventArgs e) {
      combatant.Size = new Size((int)numSizeW.Value, (int)numSizeH.Value);
    }

    private void numSizeH_ValueChanged(object sender, EventArgs e) {
      combatant.Size = new Size((int)numSizeW.Value, (int)numSizeH.Value);
    }

    private void button1_Click(object sender, EventArgs e) {
      try {
        openFileDialog1.ShowDialog();
        combatant.CharacterPortrait = new Bitmap(openFileDialog1.FileName);
      } catch (System.Exception) { }
    }

  }
}
