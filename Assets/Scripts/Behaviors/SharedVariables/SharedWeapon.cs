using UnityEngine;
using System.Collections;
using Starvoxel.BiteMe;

namespace BehaviorDesigner.Runtime
{
    [System.Serializable]
    public class SharedWeapon : SharedVariable<Weapon>
    {
        public static implicit operator SharedWeapon(Weapon value) { return new SharedWeapon { Value = value }; }
    }
}
