/* --------------------------
 *
 * PlayerCameraController.cs
 *
 * Description: Class used to control the various states of the player camera.
 *
 * Author: Jeremy Smellie
 *
 * Editors:
 *
 * 2/3/2016 - Starvoxel
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
	public class PlayerCameraController : CustomMono
	{
		#region Fields & Properties
		//const
	
		//public
	
		//protected
	
		//private
        private Camera m_PlayerCamera = null;
	
		//properties
		#endregion
	
		#region Unity Methods
        private void Start()
        {
            Camera mainCamera = Camera.main;

            if (mainCamera != null)
            {
                m_PlayerCamera = mainCamera;
            }
        }

        private void Update()
        {
            //TODO jsmellie: Here is where we'd change the functionality of the movements based on the controllers state
            // for now it'll just follow the player
            if (m_PlayerCamera != null)
            {
                Vector3 pos = this.transform.position;
                pos.z = m_PlayerCamera.transform.position.z;
                m_PlayerCamera.transform.position = pos;
            }
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