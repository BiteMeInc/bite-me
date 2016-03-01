/* --------------------------
 *
 * PlayerMover.cs
 *
 * Description: Simple script used for moving the player around
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
	public class PlayerMover : CustomMono
	{
		#region Fields & Properties
		//const
	
		//public
	
		//protected
        [SerializeField] protected float m_VelocityMultiplier = 10.0f;
        protected Rigidbody2D m_Rigidbody;
        protected Vector2 m_CurrentDirection;
	
		//private
	
		//properties
		#endregion
	
		#region Unity Methods
        protected virtual void Awake()
        {
            m_Rigidbody = GetComponentInChildren<Rigidbody2D>(true);
            m_Rigidbody.gravityScale = 0;
        }

        protected virtual void Update()
        {
            Vector2 direction = Vector2.zero;

            if (Input.GetKey(KeyCode.A))
            {
                direction.x = -1;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                direction.x = 1;
            }

            if (Input.GetKey(KeyCode.S))
            {
                direction.y = -1;
            }
            else if (Input.GetKey(KeyCode.W))
            {
                direction.y = 1;
            }

            ChangePlayerDirection(direction);
        }
		#endregion
	
		#region Public Methods
		#endregion
	
		#region Protected Methods
        protected virtual void ChangePlayerDirection(Vector2 direction)
        {
            m_CurrentDirection = direction.normalized;
            m_Rigidbody.velocity = m_CurrentDirection * m_VelocityMultiplier;
        }
		#endregion
	
		#region Private Methods
		#endregion
	}
	
}