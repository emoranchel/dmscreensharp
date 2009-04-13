using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using DmScreenSharp.Entity;
using DmScreenSharp.Components;

namespace DmScreenSharp {
  public class ApplicationControl {
    private PlayersView playersView;
    private DMScreen dmScreen;
    private Hashtable dmCombatantEditors = new Hashtable();
    public event FormClosedEventHandler Closing;
    public ApplicationControl(PlayersView playersView, DMScreen dmScreen) {
      this.playersView = playersView;
      this.dmScreen = dmScreen;
      this.dmScreen.FormClosed += new FormClosedEventHandler(dmScreen_FormClosed);
    }

    void dmScreen_FormClosed(object sender, FormClosedEventArgs e) {
      if (Closing != null) {
        Closing(sender, e);
      }
    }

    public void init() {
      dmScreen.Show();
    }

    public void showPlayersView() {
      playersView.Show();
      playersView.Focus();
    }

    public void showCombatantEditor(Combatant combatant){
      DMCombatantEditor editor;
      if (dmCombatantEditors.Contains(combatant.Id)) {
        editor = (DMCombatantEditor)dmCombatantEditors[combatant.Id];
      } else {
        editor = new DMCombatantEditor(combatant);
        dmCombatantEditors[combatant.Id] = editor;
      }
      editor.Show();
      editor.Focus();
    }

    public void removeCombatantEditor(Combatant combatant) {
      dmCombatantEditors.Remove(combatant.Id);
    }

  }
}
