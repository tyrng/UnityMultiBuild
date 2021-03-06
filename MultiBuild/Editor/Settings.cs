using UnityEngine;
using System.IO;
using System.Collections.Generic;

namespace MultiBuild {

    // Our own enumeration of targets so we can serialize with confidence
    // in case Unity changes the values of their internal targets
    public enum Target {
        Win32 = 0,
        Win64 = 1,
        Mac32 = 2,
        Mac64 = 3,
        Mac = 3, // now the default
        MacUniversal = 4,
        Linux64 = 6,
        iOS = 7,
        Android = 8,
        WebGL = 9,
        WinStore = 10,
        PS4 = 11,
        XboxOne = 12,
        tvOS = 13,
#if UNITY_5_6_OR_NEWER
        Switch = 14,
#endif
    }

    public class Settings : ScriptableObject {

        public string outputFolder;
        public bool useProductName;
        public string overrideName;
        public bool developmentBuild;
        public List<Target> targets;

        public void Reset() {
            outputFolder = Directory.GetParent(Application.dataPath).FullName;
            useProductName = true;
            overrideName = string.Empty;
            developmentBuild = false;
            targets = new List<Target>();
        }

    }


}
