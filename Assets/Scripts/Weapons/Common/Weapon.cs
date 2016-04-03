/* --------------------------
 *
 * Weapon.cs
 *
 * Description: Base class of all weapons
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

#endregion
#endregion

 namespace Starvoxel.BiteMe
{
	public class Weapon : CustomMono
	{
		#region Fields & Properties
		//const
	
		//public
	
		//protected
        [Header("Attacking")]
        [SerializeField] protected float m_AttackRange;
        [SerializeField] protected float m_AttackDamage;
	    
        [Header("GameObjects")]
        [SerializeField]
        protected Transform m_BulletSpawnLocation;
        [SerializeField]
        protected Transform m_BaseLocation;
        [SerializeField]
        protected Transform m_TipLocation;
		//private
	
		//properties
        public float AttackRange
        {
            get { return m_AttackRange; }
        }
        public float AttackDamage
        {
            get { return m_AttackDamage; }
        }

        protected Vector2 Direction
        {
            get { return ((Vector2)(m_TipLocation.position - m_BaseLocation.position)).normalized; }
        }
		#endregion
	
		#region Unity Methods
		#endregion
	
		#region Public Methods
		#endregion
	
		#region Protected Methods
		#endregion
	
		#region Private Methods
		#endregion
	}
	
}