using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CombatTracker.Entity;

namespace CombatTracker.Components {
  public partial class CombatantEditor : UserControl {
    Combatant combatant;
    Combat combat;
    CombatantUpdatedModifiedDelegate combatantDelegate;
    public CombatantEditor(Combatant combatant, Combat combat) {
      InitializeComponent();
      this.combatant = combatant;
      this.combat = combat;
      this.textName.Text = combatant.Name;
      this.numCurrHp.Value = combatant.CurrentHp;
      this.numMaxHp.Value = combatant.MaxHp;
      this.numInit.Value = combatant.Initiative;
      this.checkPlayer.Checked = combatant.Player;
      this.pictureBox1.Image = combatant.CharacterPortrait;
      combatantDelegate = new CombatantUpdatedModifiedDelegate(combatant_Updated);
      combatant.Updated += combatantDelegate;
    }

    void combatant_Updated(object source, Combatant.CombatantProperty property) {
      if (property == Combatant.CombatantProperty.portrait) {
        this.pictureBox1.Image = combatant.CharacterPortrait;
      }
    }

    private void button1_Click(object sender, EventArgs e) {
      openFileDialog1.ShowDialog();
      Image image = new Bitmap(openFileDialog1.FileName);
    }

    private void button2_Click(object sender, EventArgs e) {
      combat.removeCombatant(combatant);
    }

    private void numericUpDown_Enter(object sender, EventArgs e) {
      if (sender is NumericUpDown) {
        ((NumericUpDown)sender).Select(0, 1000);
      }
    }

    private void button1_Click_1(object sender, EventArgs e) {
      try {
        openFileDialog1.ShowDialog();
        combatant.CharacterPortrait = new Bitmap(openFileDialog1.FileName);
      } catch (System.Exception) { }
    }

    private void numericUpDown1_ValueChanged(object sender, EventArgs e) {
      combatant.CurrentHp = (int)numCurrHp.Value;
    }

    private void numericUpDown2_ValueChanged(object sender, EventArgs e) {
      combatant.MaxHp = (int)numMaxHp.Value;
    }

    private void textBox1_TextChanged(object sender, EventArgs e) {
      combatant.Name = textName.Text;
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e) {
      combatant.Player = checkPlayer.Checked;
    }

    private void numericUpDown5_ValueChanged(object sender, EventArgs e) {
      combatant.Initiative = (int)numInit.Value;
    }

    public void clean() {
      combatant.Updated -= combatantDelegate;
    }
  }
}
