/* --------------------------
 *
 * UpdateWeapon.cs
 *
 * Description: Updates a weapon variable with the currently equiped weapon
 *
 * Author: Jeremy Smellie
 *
 * Editors:
 *
 * 4/3/2016 - Starvoxel
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

namespace BehaviorDesigner.Runtime.Tasks.BiteMe.Weapon
{
    [TaskCategory("Bite Me/Weapon")]
    [TaskDescription("Updates the value of the equiped weapon")]
	public class UpdateWeapon : Action
	{
		#region Fields & Properties
		//const
	
		//public
        [Tooltip("The weapon that will be updated")]
        [SharedRequired]
        public SharedWeapon equipedWeapon;
		//protected
	
		//private
        private Inventory m_Inventory;
	
		//properties
		#endregion
	
		#region Public Methods
        public override TaskStatus OnUpdate()
        {
            if (m_Inventory == null)
            {
                BiteMeCharacter character = this.gameObject.GetComponent<BiteMeCharacter>();

                if (character != null)
                {
                    m_Inventory = character.Inventory;
                }
            }

            // If we don't have a inventory, then we can't have a weapon
            if (m_Inventory == null)
            {
                return TaskStatus.Failure;
            }

            equipedWeapon.Value = m_Inventory.EquipedWeapon;

            return TaskStatus.Success;
        }
		#endregion
	
		#region Protected Methods
		#endregion
	
		#region Private Methods
		#endregion
	}
	
}