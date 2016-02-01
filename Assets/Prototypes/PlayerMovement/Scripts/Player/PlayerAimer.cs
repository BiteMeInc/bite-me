/* --------------------------
 *
 * PlayerAimer.cs
 *
 * Description: Basic class used to aim the player
 *
 * Author: Jeremy Smellie
 *
 * Editors:
 *
 * 2/1/2016 - Starvoxel
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

#endregion
#endregion

 namespace Starvoxel.BiteMe
{
	public class PlayerAimer : CustomMono
	{
		#region Fields & Properties
		//const
	
		//public
	
		//protected
	
		//private
	
		//properties
		#endregion
	
		#region Unity Methods
        protected virtual void Update()
        {
            Vector3 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            cursorPos.z = this.transform.position.z;
            Vector3 lookAtDir = cursorPos - this.transform.position;
            lookAtDir.Normalize();
            float angle = Mathf.Atan2(lookAtDir.x, -lookAtDir.y) * Mathf.Rad2Deg;
            this.transform.rotation = Quaternion.Euler(0, 0, angle - 90);
        }
		#endregion
	
		#region Public Methods
		#endregion
	
		#region Protected Methods
		#endregion
	
		#region Private Methods
		#endregion
	}
	
}