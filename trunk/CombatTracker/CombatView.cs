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
        container.Controls.Remove(viz);
      }
      foreach (Combatant c in newOrder) {
        container.Controls.Add((CharacterCombatVisualizer)vizCollection[c]);
      }
    }


    void combat_CombatantAdded(Combat source, Combatant combatant) {
      CharacterCombatVisualizer viz = new CharacterCombatVisualizer(combatant, combat);
      CombatantPictureBox pic = new CombatantPictureBox(combatant, combat.GridSize);
      map.Controls.Add(pic);
      container.Controls.Add(viz);
      vizCollection.Add(combatant, viz);
      picCollection.Add(combatant, pic);
      gridPanel1.SendToBack();
    }

    void combat_CombatantRemoved(Combat source, Combatant combatant) {
      CharacterCombatVisualizer viz = (CharacterCombatVisualizer)vizCollection[combatant];
      CombatantPictureBox pic = (CombatantPictureBox)picCollection[combatant];
      pic.clean();
      viz.clean();
      map.Controls.Remove(pic);
      container.Controls.Remove(viz);
      vizCollection.Remove(combatant);
      picCollection.Remove(combatant);
      gridPanel1.SendToBack();
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
          resizeGrid();
          gridPanel1.BackgroundImage = combat.BackgroundImage(combat.GridSize);
          break;
        case Combat.CombatProperties.bgImage:
          gridPanel1.BackgroundImage = combat.BackgroundImage(combat.GridSize);
          break;
        case Combat.CombatProperties.bgImageTile:
          gridPanel1.BackgroundImageLayout = combat.BackgroundTileImage ? ImageLayout.Tile : ImageLayout.None;
          break;
        case Combat.CombatProperties.size:
          resizeGrid();
          break;
      }
    }
    private void resizeGrid() {
      gridPanel1.Size = new Size(combat.Width * combat.GridSize, combat.Height * combat.GridSize);
      gridPanel1.GridSize = combat.GridSize;
    }
  }
}
