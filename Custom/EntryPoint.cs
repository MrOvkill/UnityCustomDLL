using EpicKnife.Games;
using UnityEngine;

namespace GameMode
{
    public class EntryPoint : EpicKnife.Games.GameMode
    {
        public override void OnStart()
        {
            GameObject obj = UnityUtils.createCamera(
                "rootCam", 
                new Vector3(0, 0, 0)
            );
            
        }

		public override void OnUpdate()
		{

		}

		public override void OnGUI()
		{
			GUI.Box(new Rect(10, 10, 100, 100), "BAWX");
		}
    }
}
