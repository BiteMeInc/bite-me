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
    [TaskDescription("Sets a float value")]
    public class UpdateVitals : Conditional
	{
        [Tooltip("The float value representing health")]
        [SharedRequired]
        public SharedFloat healthValue;
        [Tooltip("The float value representing armor")]
        [SharedRequired]
        public SharedFloat armorValue;

        private Vitals m_Vitals;

        public override TaskStatus OnUpdate()
        {
            if (m_Vitals == null)
            {
                BiteMeCharacter character = this.gameObject.GetComponent<BiteMeCharacter>();

                if (character != null)
                {
                    m_Vitals = character.Vitals;
                }
            }

            // If this objet doesn't have health, then this task can't be done!
            if (m_Vitals == null)
            {
                return TaskStatus.Failure;
            }

            healthValue.Value = m_Vitals.CurrentHealth;
            armorValue.Value = m_Vitals.CurrentArmor;

            return TaskStatus.Success;
        }

        public override void OnReset()
        {
            base.OnReset();

            m_Vitals = null;
        }
	}
}