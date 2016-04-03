/* --------------------------
 *
 * UpdateVitals.cs
 *
 * Description: 
 *
 * Author: Jeremy Smellie
 *
 * Editors:
 *
 * 3/1/2016 - Starvoxel
 *
 * All rights reserved.
 *
 * -------------------------- */

#region Includes
#region Unity Includes
using UnityEngine;
#endregion

#region System Includes
using System.Collections;
#endregion

#region Other Includes
using Starvoxel.BiteMe;
using BiteMeCharacter = Starvoxel.BiteMe.Character;
#endregion
#endregion

namespace BehaviorDesigner.Runtime.Tasks.BiteMe.Character
{
    [TaskCategory("Bite Me/Character")]
    [TaskDescription("Checks to see if a game object is alive")]
    public class IsAlive : Conditional
	{
        [Tooltip("The target that we'll be checking the health for.  If this is nuill it will use itself")]
        public SharedGameObject target;

        private Vitals m_Vitals;

        public override TaskStatus OnUpdate()
        {
            if (m_Vitals == null)
            {
                BiteMeCharacter character;
                if (target.Value != null)
                {
                    character = target.Value.GetComponent<BiteMeCharacter>();
                }
                else
                {
                    character = this.gameObject.GetComponent<BiteMeCharacter>();
                }

                m_Vitals = character.Vitals;
            }

            // If this objet doesn't have health or is dead, then it's a fail
            if (m_Vitals == null || m_Vitals.CurrentHealth <= 0)
            {
                return TaskStatus.Failure;
            }
            else
            {
                return TaskStatus.Success;
            }
        }

        public override void OnReset()
        {
            base.OnReset();

            m_Vitals = null;
        }
	}
}