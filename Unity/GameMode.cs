using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EpicKnife.Games
{
    public abstract class GameMode
    {
		public abstract void OnStart();

		public abstract void OnUpdate();

		public abstract void OnGUI();
    }
}
