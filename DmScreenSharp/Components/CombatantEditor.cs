using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DmScreenSharp.Entity;

namespace DmScreenSharp.Components {
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
      this.pictureBox1.Image = combatant.CharacterPortrait;
      combatantDelegate = new CombatantUpdatedModifiedDelegate(combatant_Updated);
      combatant.Updated += combatantDelegate;
    }

    void combatant_Updated(object source, Combatant.CombatantProperty property) {
      if (property == Combatant.CombatantProperty.portrait) {
        this.pictureBox1.Image = combatant.CharacterPortrait;
      }
      if (property == Combatant.CombatantProperty.name) {
        textName.Text = combatant.Name;
      }
      if (property == Combatant.CombatantProperty.hp) {
        numCurrHp.Value = combatant.CurrentHp;
        numMaxHp.Value = combatant.MaxHp;
      }
    }

    private void numericUpDown_Enter(object sender, EventArgs e) {
      if (sender is NumericUpDown) {
        ((NumericUpDown)sender).Select(0, 1000);
      }
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

    public void clean() {
      combatant.Updated -= combatantDelegate;
    }

    private void pictureBox1_Click(object sender, EventArgs e) {
      Program.Control.showCombatantEditor(combatant);
    }
  }
}
