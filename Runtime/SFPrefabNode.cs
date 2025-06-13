using System;
using SFramework.Configs.Runtime;
using UnityEngine;

namespace SFramework.Pools.Runtime
{
    [Serializable]
    public class SFPrefabNode : SFConfigNode
    {
        [SFAsset(typeof(GameObject))]
        public string Path;
        
        [Min(0)]
        public int PreloadAmount;
        public override ISFConfigNode[] Children => null;
    }
}