using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle2023_IT2B
{
  public class Unit
  {
    public int HP { get; private set; }
    public int DMG { get; private set; }

    public Action? Died;
    
    public Unit(int hp, int dmg)
    {
      HP = hp;
      DMG = dmg;
    }

    public void GetHit(int dmg)
    {
      HP -= DMG;
      if(HP <= 0)
      {
        HP = 0;
        // generovaní události
        Died?.Invoke();
      }
    }
  }
}
