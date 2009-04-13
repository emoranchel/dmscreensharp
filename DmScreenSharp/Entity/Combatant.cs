using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DmScreenSharp.Entity {
  public delegate void CombatantUpdatedModifiedDelegate(Combatant source, Combatant.CombatantProperty property);

  public class Combatant {
    public enum CombatantProperty { name, hp, position, portrait, initiative, player, visible, size };
    private static int counter;
    private string name;
    private int maxHp;
    private int currentHp;
    private Point position;
    private Image characterPortrait;
    private bool player;
    private int initiative;
    private int id;
    private bool visible;
    private Size size;

    public event CombatantUpdatedModifiedDelegate Updated;

    public int Initiative {
      get { return initiative; }
      set { initiative = value; onUpdate(CombatantProperty.initiative); }
    }

    public int Id {
      get { return id; }
    }

    public Point Position {
      get { return position; }
      set {
        if (position == value) return;
        position = value;
        onUpdate(CombatantProperty.position);
        Console.WriteLine("combatant new position now at: " + position.ToString());
      }
    }

    public Size Size {
      get { return size; }
      set {
        if (this.size == value) return;
        this.size = value;
        onUpdate(CombatantProperty.size);
      }
    }

    public bool Visible {
      get { return visible; }
      set { visible = value; onUpdate(CombatantProperty.visible); }
    }

    public Combatant(string name, int maxHp, int init, bool player, bool visible, Size size) {
      this.id = counter++;
      this.name = name;
      this.maxHp = maxHp;
      this.currentHp = maxHp;
      this.player = player;
      this.initiative = init;
      this.position = new Point(0, 0);
      this.visible = visible;
      this.size = size;
      this.characterPortrait = getPortrait(id);
    }

    private static Image getPortrait(int id) {
      int magik = id % 22;
      switch (magik) {
        case 0:
          return DmScreenSharp.Properties.Resources.Pin_001;
        case 1:
          return DmScreenSharp.Properties.Resources.Pin_030;
        case 2:
          return DmScreenSharp.Properties.Resources.Pin_034;
        case 3:
          return DmScreenSharp.Properties.Resources.Pin_057;
        case 4:
          return DmScreenSharp.Properties.Resources.Pin_062;
        case 5:
          return DmScreenSharp.Properties.Resources.Pin_071;
        case 6:
          return DmScreenSharp.Properties.Resources.Pin_082;
        case 7:
          return DmScreenSharp.Properties.Resources.Pin_087;
        case 8:
          return DmScreenSharp.Properties.Resources.Pin_088;
        case 9:
          return DmScreenSharp.Properties.Resources.Pin_089;
        case 10:
          return DmScreenSharp.Properties.Resources.Pin_090;
        case 11:
          return DmScreenSharp.Properties.Resources.Pin_108;
        case 12:
          return DmScreenSharp.Properties.Resources.Pin_124;
        case 13:
          return DmScreenSharp.Properties.Resources.Pin_131;
        case 14:
          return DmScreenSharp.Properties.Resources.Pin_132;
        case 15:
          return DmScreenSharp.Properties.Resources.Pin_158;
        case 16:
          return DmScreenSharp.Properties.Resources.Pin_175;
        case 17:
          return DmScreenSharp.Properties.Resources.Pin_177;
        case 18:
          return DmScreenSharp.Properties.Resources.Pin_189;
        case 19:
          return DmScreenSharp.Properties.Resources.Pin_247;
        case 20:
          return DmScreenSharp.Properties.Resources.Pin_280;
        case 21:
          return DmScreenSharp.Properties.Resources.Pin_289;
      }
      return DmScreenSharp.Properties.Resources.Pin_001;
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
