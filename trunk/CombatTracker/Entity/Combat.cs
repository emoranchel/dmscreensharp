using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CombatTracker.Entity {
  public delegate void CombatOrderDelegate(Combat source, List<Combatant> newOrder);
  public delegate void CombatModifiedDelegate(Combat source, Combat.CombatProperties property);
  public delegate void CombatantDelegate(Combat source, Combatant combatant);

  public class Combat {
    public enum CombatProperties { currentInitiative, gridSize, bgImage, bgImageTile }
    private List<Combatant> combatants = new List<Combatant>();

    public event CombatModifiedDelegate CombatModified;
    public event CombatOrderDelegate CombatOrderChanged;
    public event CombatantDelegate CombatantAdded;
    public event CombatantDelegate CombatantRemoved;

    private int currentInitiative;
    private int gridSize;
    private Image originalImage;
    private int imageRez;
    private Image bgImage;
    private bool tileImage;

    private List<int> initiatives = new List<int>();

    CombatantUpdatedModifiedDelegate combatantDelegate;

    public Combat() {
      gridSize = 25;
      imageRez = 128;
      tileImage = true;
      originalImage = CombatTracker.Properties.Resources.defaultTile;
      combatantDelegate = new CombatantUpdatedModifiedDelegate(combatant_Updated);
      recalculateBg();
    }

    public List<Combatant> Combatants {
      get { return new List<Combatant>(combatants); }
    }

    public int GridSize {
      get { return gridSize; }
      set {
        value = value < 25 ? 25 : value > 300 ? 300 : value;
        if (gridSize == value) return;
        this.gridSize = value;
        onCombatModified(CombatProperties.gridSize);
        recalculateBg();
      }
    }

    public int CurrentInitiative {
      get { return currentInitiative; }
    }

    public void nextInit() {
      //reduce 1 turn the initiative
      if (initiatives.Count > 0) {
        int i = 0;
        while (i < initiatives.Count) {
          if (initiatives[i] >= currentInitiative) {
            break;
          }
          i++;
        }
        if (i == 0)
          currentInitiative = initiatives[initiatives.Count - 1];
        else
          currentInitiative = initiatives[i - 1];
        onCombatModified(CombatProperties.currentInitiative);
        onCombatOrderChanged();
      }
    }

    public void prevInit() {
      //increase 1 the initiative
      if (initiatives.Count > 0) {
        int i = initiatives.Count - 1;
        while (i >= 0) {
          if (initiatives[i] < currentInitiative) {
            break;
          }
          i--;
        }
        if (i < 0)
          currentInitiative = initiatives[initiatives.Count - 1];
        else
          currentInitiative = initiatives[i];
        onCombatModified(CombatProperties.currentInitiative);
        onCombatOrderChanged();
      }
    }

    public void addCombatant(Combatant combatant) {
      this.combatants.Add(combatant);
      combatants.Sort(new Comparison<Combatant>(compareCombatants));
      onCombatantAdded(combatant);
      onCombatOrderChanged();
      combatant.Updated += combatantDelegate;
    }

    public Image OriginalImage {
      get { return originalImage; }
      set { this.originalImage = value; recalculateBg(); }
    }
    public int OriginalImageResolution {
      get { return imageRez; }
      set { this.imageRez = value; recalculateBg(); }
    }

    public Image BackgroundImage {
      get { return bgImage; }
    }

    public bool BackgroundTileImage {
      get { return tileImage; }
      set { this.tileImage = value; onCombatModified(CombatProperties.bgImageTile); }
    }


    public void removeCombatant(Combatant combatant) {
      this.combatants.Remove(combatant);
      combatants.Sort(new Comparison<Combatant>(compareCombatants));
      onCombatantRemoved(combatant);
      onCombatOrderChanged();
      combatant.Updated -= combatantDelegate;
    }

    private void recalculateBg() {
      if (originalImage == null)
        return;
      //an square of imageRez x ImageRez should be resized to gridSize x gridSize in order for this to work.
      double resizeFactor = (double)gridSize / (double)imageRez;
      int width = (int)(originalImage.Width * resizeFactor);
      int height = (int)(originalImage.Height * resizeFactor);
      Image bg = new Bitmap(width, height);
      Graphics g = Graphics.FromImage(bg);
      g.DrawImage(originalImage, new Rectangle(0, 0, width, height));
      bgImage = bg;
      onCombatModified(CombatProperties.bgImage);
    }

    private void combatant_Updated(Combatant source, Combatant.CombatantProperty property) {
      if (property == Combatant.CombatantProperty.initiative || property == Combatant.CombatantProperty.ALL) {
        initiatives = new List<int>();
        combatants.Sort(new Comparison<Combatant>(compareCombatants));
        foreach (Combatant c in combatants) {
          initiatives.Add(c.Initiative);
        }
        onCombatOrderChanged();
      }
    }

    private void onCombatModified(CombatProperties property) {
      if (CombatModified != null) {
        CombatModified(this, property);
      }
    }
    private void onCombatantAdded(Combatant c) {
      if (CombatantAdded != null) {
        CombatantAdded(this, c);
      }
    }
    private void onCombatantRemoved(Combatant c) {
      if (CombatantRemoved != null) {
        CombatantRemoved(this, c);
      }
    }
    private void onCombatOrderChanged() {
      if (CombatOrderChanged != null) {
        List<Combatant> combatants = new List<Combatant>();
        List<Combatant> thisTurn = new List<Combatant>();
        List<Combatant> nextTurn = new List<Combatant>();
        foreach (Combatant c in this.combatants) {
          if (c.Initiative > currentInitiative) {
            nextTurn.Add(c);
          } else {
            thisTurn.Add(c);
          }
        }
        combatants.AddRange(nextTurn);
        combatants.AddRange(thisTurn);
        CombatOrderChanged(this, combatants);
      }
    }

    private int compareCombatants(Combatant c1, Combatant c2) {
      if (c1.Initiative == c2.Initiative)
        return c1.Id - c2.Id;
      return c1.Initiative - c2.Initiative;
    }
  }
}
