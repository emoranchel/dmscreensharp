using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CombatTracker.Entity;

namespace CombatTracker {
  public partial class CharacterCombatVisualizer : UserControl {
    private Combatant combatant;
    private Combat combat;
    CombatantUpdatedModifiedDelegate combatantUpdatedDelegate;
    CombatModifiedDelegate combatDelegate;
    public CharacterCombatVisualizer(Combatant combatant, Combat combat) {
      InitializeComponent();
      this.Dock = DockStyle.Top;
      this.combatant = combatant;
      this.combat = combat;
      combatant_Updated(combatant, Combatant.CombatantProperty.ALL);
      combatantUpdatedDelegate = new CombatantUpdatedModifiedDelegate(combatant_Updated);
      combatDelegate = new CombatModifiedDelegate(combat_CombatModified);
      combatant.Updated += combatantUpdatedDelegate;
      combat.CombatModified += combatDelegate;
    }

    void combat_CombatModified(Combat source, Combat.CombatProperties property) {
      this.BackColor = combatant.Initiative == source.CurrentInitiative ? Color.FromArgb(151, 255, 125) : Color.FromArgb(236, 237, 240);
    }

    public void clean() {
      combatant.Updated -= combatantUpdatedDelegate;
      combat.CombatModified -= combatDelegate;
    }

    void combatant_Updated(object source, Combatant.CombatantProperty property) {
      int percent = (int)combatant.Percent;
      Color foreBar = Color.Green;
      Color backBar = Color.White;
      if (percent > 50)
        foreBar = Color.Green;
      else if (percent > 25)
        foreBar = Color.Green;
      else if (percent > 0)
        foreBar = Color.Orange;
      else
        foreBar = Color.DarkRed;
      if (percent > 50)
        backBar = Color.DarkGray;
      else if (percent > 25)
        backBar = Color.Orange;
      else if (percent > 10)
        backBar = Color.DarkOrange;
      else if (percent > 0)
        backBar = Color.Red;
      else
        backBar = Color.DarkRed;
      bar1.ForeBar = foreBar;
      bar1.BackBar = backBar;
      bar1.Value = combatant.Percent;
      lblHp.Text = combatant.CurrentHp.ToString() + "/" + combatant.MaxHp.ToString();
      lblHp.Visible = combatant.Player;
      lblInit.Text = combatant.Initiative.ToString();
      lblName.Text = combatant.Name;
      pictureBox1.Image = combatant.CharacterPortrait;
    }
  }
}
