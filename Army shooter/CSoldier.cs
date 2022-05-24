using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Army_shooter.Properties;
using System.Drawing;

namespace Army_shooter
{
    class CSoldier : CImageBase
    {
        private Rectangle _soldierHotSpot = new Rectangle();
        
        public CSoldier()
            : base(Resources.sniper2)
    {
            //These create the area that would be registered as a hit
        _soldierHotSpot.X = 20;
        _soldierHotSpot.Y = 1;
        _soldierHotSpot.Width = 50;
        _soldierHotSpot.Height = 60;

    }
    

    public void Update (int X, int Y)
{
        //These update the coordinates of the the hotpots
    Left = X - Resources.sniper2.Width;
    Top = Y - Resources.sniper2.Height;
    _soldierHotSpot.X = X - Resources.sniper2.Width;
    _soldierHotSpot.Y = Y - Resources.sniper2.Height;

}
    public bool Hit(int X, int Y)
{
    Rectangle c = new Rectangle(X, Y, 1, 1);
        //These lines confirm if the shots was within the hotspots
    if (_soldierHotSpot.Contains(c))
{
    return true;
}
    return false;
}

}
}
