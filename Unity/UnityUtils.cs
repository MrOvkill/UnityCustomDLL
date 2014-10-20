using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace EpicKnife.Games
{
    public class UnityUtils
    {
        public static GameObject createCamera(string name, Vector3 pos)
        {
            GameObject cam = new GameObject();
            cam.name = name;
            cam.AddComponent<Camera>();
            cam.transform.position = pos;
            cam.transform.localEulerAngles = new Vector3(0, 0, 0);
            return cam;
        }
    }
}
