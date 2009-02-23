using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CombatTracker.Entity {
  public delegate void CombatantUpdatedModifiedDelegate(Combatant source, Combatant.CombatantProperty property);

  public class Combatant {
    public enum CombatantProperty { name, hp, position, portrait, initiative, player, ALL };
    private static int counter;
    private string name;
    private int maxHp;
    private int currentHp;
    private int posX;
    private int posY;
    private Image characterPortrait;
    private bool player;
    private int initiative;
    private int id;

    public event CombatantUpdatedModifiedDelegate Updated;

    public int Initiative {
      get { return initiative; }
      set { initiative = value; onUpdate(CombatantProperty.initiative); }
    }

    public int Id {
      get { return id; }
    }

    public int PosX {
      get { return posX; }
      set { if (posX == value) return; posX = value; onUpdate(CombatantProperty.position); }
    }
    public int PosY {
      get { return posY; }
      set { if (posY == value) return; posY = value; onUpdate(CombatantProperty.position); }
    }

    public Combatant(string name, int maxHp, int init, bool player) {
      this.id = counter++;
      this.name = name;
      this.maxHp = maxHp;
      this.currentHp = maxHp;
      this.player = player;
      this.initiative = init;
      posX = 5;
      posY = 5;
      this.characterPortrait = getPortrait(id);
    }

    private static Image getPortrait(int id) {
      int magik = id % 22;
      switch (magik) {
        case 0:
          return CombatTracker.Properties.Resources.Pin_001;
        case 1:
          return CombatTracker.Properties.Resources.Pin_030;
        case 2:
          return CombatTracker.Properties.Resources.Pin_034;
        case 3:
          return CombatTracker.Properties.Resources.Pin_057;
        case 4:
          return CombatTracker.Properties.Resources.Pin_062;
        case 5:
          return CombatTracker.Properties.Resources.Pin_071;
        case 6:
          return CombatTracker.Properties.Resources.Pin_082;
        case 7:
          return CombatTracker.Properties.Resources.Pin_087;
        case 8:
          return CombatTracker.Properties.Resources.Pin_088;
        case 9:
          return CombatTracker.Properties.Resources.Pin_089;
        case 10:
          return CombatTracker.Properties.Resources.Pin_090;
        case 11:
          return CombatTracker.Properties.Resources.Pin_108;
        case 12:
          return CombatTracker.Properties.Resources.Pin_124;
        case 13:
          return CombatTracker.Properties.Resources.Pin_131;
        case 14:
          return CombatTracker.Properties.Resources.Pin_132;
        case 15:
          return CombatTracker.Properties.Resources.Pin_158;
        case 16:
          return CombatTracker.Properties.Resources.Pin_175;
        case 17:
          return CombatTracker.Properties.Resources.Pin_177;
        case 18:
          return CombatTracker.Properties.Resources.Pin_189;
        case 19:
          return CombatTracker.Properties.Resources.Pin_247;
        case 20:
          return CombatTracker.Properties.Resources.Pin_280;
        case 21:
          return CombatTracker.Properties.Resources.Pin_289;
      }
      return CombatTracker.Properties.Resources.Pin_001;
    }

    public string Name {
      get { return name; }
      set { this.name = value; onUpdate(CombatantProperty.name); }
    }
    public int MaxHp {
      get { return maxHp; }
      set { maxHp = value; onUpdate(CombatantProperty.hp); }
    }
    public int CurrentHp {
      get { return currentHp; }
      set { currentHp = value; onUpdate(CombatantProperty.hp); }
    }
    public double Percent {
      get {
        double percent = (((double)currentHp / maxHp) * 100);
        return percent > 100.0 ? 100.0 : percent < 0.0 ? 0.0 : percent;
      }
    }

    public Image CharacterPortrait {
      get { return characterPortrait; }
      set { this.characterPortrait = value; onUpdate(CombatantProperty.portrait); }
    }

    public bool Player {
      get { return player; }
      set { this.player = value; onUpdate(CombatantProperty.player); }
    }

    private void onUpdate(CombatantProperty property) {
      if (Updated != null) {
        Updated(this, property);
      }
    }
  }
}
