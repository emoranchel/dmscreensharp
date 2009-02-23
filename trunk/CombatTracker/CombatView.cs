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
  public partial class CombatView : Form {
    private Combat combat;
    private Hashtable vizCollection = new Hashtable();
    private Hashtable picCollection = new Hashtable();
    private CombatantUpdatedModifiedDelegate combatantModified;

    public CombatView(CombatTracker.Entity.Combat combat) {
      InitializeComponent();
      this.combat = combat;
      combatantModified = new CombatantUpdatedModifiedDelegate(combatant_Updated);
      combat.CombatModified += new CombatModifiedDelegate(combat_CombatModified);
      combat.CombatantRemoved += new CombatantDelegate(combat_CombatantRemoved);
      combat.CombatantAdded += new CombatantDelegate(combat_CombatantAdded);
      combat.CombatOrderChanged += new CombatOrderDelegate(combat_CombatOrderChanged);
      combat_CombatModified(combat, Combat.CombatProperties.gridSize);
      combat_CombatModified(combat, Combat.CombatProperties.currentInitiative);
      combat_CombatModified(combat, Combat.CombatProperties.bgImageTile);
      combat_CombatModified(combat, Combat.CombatProperties.bgImage);
    }

    void combat_CombatOrderChanged(Combat source, List<Combatant> newOrder) {
      foreach (CharacterCombatVisualizer viz in vizCollection.Values) {
        combatants.Controls.Remove(viz);
      }
      foreach (Combatant c in newOrder) {
        combatants.Controls.Add((CharacterCombatVisualizer)vizCollection[c]);
      }
    }


    void combat_CombatantAdded(Combat source, Combatant combatant) {
      CharacterCombatVisualizer viz = new CharacterCombatVisualizer(combatant, combat);
      CombatantPictureBox pic = new CombatantPictureBox(combatant, combat.GridSize);
      map.Controls.Add(pic);
      combatants.Controls.Add(viz);
      vizCollection.Add(combatant, viz);
      picCollection.Add(combatant, pic);
      gridPanel1.SendToBack();
      combatant.Updated += combatant_Updated;
    }

    void combat_CombatantRemoved(Combat source, Combatant combatant) {
      CharacterCombatVisualizer viz = (CharacterCombatVisualizer)vizCollection[combatant];
      CombatantPictureBox pic = (CombatantPictureBox)picCollection[combatant];
      pic.clean();
      viz.clean();
      map.Controls.Remove(pic);
      combatants.Controls.Remove(viz);
      vizCollection.Remove(combatant);
      picCollection.Remove(combatant);
      gridPanel1.SendToBack();
      combatant.Updated -= combatant_Updated;
    }

    private void combat_CombatModified(Combat source, Combat.CombatProperties property) {
      switch (property) {
        case Combat.CombatProperties.currentInitiative:
          label1.Text = combat.CurrentInitiative.ToString();
          break;
        case Combat.CombatProperties.gridSize:
          foreach (CombatantPictureBox pic in picCollection.Values) {
            pic.Zoom = combat.GridSize;
          }
          gridPanel1.GridSize = combat.GridSize;
          repositionMapKeeper();
          break;
        case Combat.CombatProperties.bgImage:
          gridPanel1.BackgroundImage = combat.BackgroundImage;
          break;
        case Combat.CombatProperties.bgImageTile:
          gridPanel1.BackgroundImageLayout = combat.BackgroundTileImage ? ImageLayout.Tile : ImageLayout.None;
          break;
      }
    }

    private void combatant_Updated(Combatant source, Combatant.CombatantProperty property) {
      repositionMapKeeper();
    }

    private void repositionMapKeeper() {
      int maxX = 0;
      int maxY = 0;
      foreach (Combatant c in combat.Combatants) {
        maxX = Math.Max(c.PosX, maxX);
        maxY = Math.Max(c.PosY, maxY);
      }
      maxX += 10;
      maxY += 10;
      mapSizeKeeper.Location = new Point(combat.GridSize * maxX, combat.GridSize * maxY);

    }
  }
}
