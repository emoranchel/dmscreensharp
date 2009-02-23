using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CombatTracker.Entity;
using CombatTracker.Components;
using System.Collections;

namespace CombatTracker {
  public partial class CombatScreen : Form {
    private Combat combat;
    private Hashtable combatantControls = new Hashtable();

    public CombatScreen(Combat combat) {
      InitializeComponent();
      this.combat = combat;
      combat.CombatantAdded += new CombatantDelegate(combat_CombatantAdded);
      combat.CombatantRemoved += new CombatantDelegate(combat_CombatantRemoved);
      combat.CombatModified += new CombatModifiedDelegate(combat_CombatModified);
    }

    void combat_CombatModified(Combat source, Combat.CombatProperties property) {
      switch (property) {
        case Combat.CombatProperties.currentInitiative:
          this.label3.Text = combat.CurrentInitiative.ToString();
          break;
      }
    }

    void combat_CombatantRemoved(Combat source, Combatant combatant) {
      CombatantEditor edit = (CombatantEditor)combatantControls[combatant];
      edit.clean();
      combatantControls.Remove(combatant);
      container.Controls.Remove(edit);
    }


    void combat_CombatantAdded(Combat source, Combatant combatant) {
      CombatantEditor edit = new CombatantEditor(combatant, combat);
      container.Controls.Add(edit);
      combatantControls.Add(combatant, edit);
    }


    private void btnAddPlayer_Click(object sender, EventArgs e) {
      int hp = (int)newPlayerHp.Value;
      int init = (int)newPlayerInit.Value;
      string name = newPlayerName.Text;
      bool isPlayer = newPlayerIsPlayer.Checked;
      Combatant combatant = new Combatant(name, hp, init, isPlayer);
      newPlayerIsPlayer.Checked = false;
      newPlayerHp.Value = 0;
      newPlayerInit.Value = 0;
      newPlayerName.Text = "";
      combat.addCombatant(combatant);
    }

    private void newPlayerHp_Enter(object sender, EventArgs e) {
      newPlayerHp.Select(0, 100);
    }

    private void button1_Click(object sender, EventArgs e) {
      combat.nextInit();
    }

    private void button2_Click(object sender, EventArgs e) {
      combat.prevInit();
    }

    private void newPlayerInit_Enter(object sender, EventArgs e) {
      newPlayerInit.Select(0, 100);
    }

    private void trackBar1_Scroll(object sender, EventArgs e) {
      combat.GridSize = trackBar1.Value * 25;
    }

    private void numericUpDown1_Leave(object sender, EventArgs e) {
      combat.OriginalImageResolution = (int)numericUpDown1.Value;
    }

    private void button3_Click(object sender, EventArgs e) {
      try {
        openFileDialog1.ShowDialog();
        combat.OriginalImage = new Bitmap(openFileDialog1.FileName);
      } catch (System.Exception) { }
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e) {
      combat.BackgroundTileImage = checkBox1.Checked;
    }
  }
}
