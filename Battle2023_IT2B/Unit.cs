using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle2023_IT2B
{
  public class Unit
  {
    private int hp;
    public int HP
    {
      get => hp;
      set => hp = Math.Max(Math.Min(value, 200), 50);
    }

    private int dmg;
    public int DMG
    {
      get
      {
        return dmg;
      }
      set
      {
        dmg = Math.Max(Math.Min(value, 20), 5);
      }
    }

    public Unit(int hp, int dmg)
    {

    }

   
  }
}
