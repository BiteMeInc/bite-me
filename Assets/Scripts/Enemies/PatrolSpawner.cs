/* --------------------------
 *
 * PatrolSpawner.cs
 *
 * Description: Specific spawner for patrols.  Sets the patrol specific variables.
 *
 * Author: Jeremy Smellie
 *
 * Editors:
 *
 * 2/28/2016 - Starvoxel
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
using System.Collections.Generic;
#endregion

#region Other Includes
using BehaviorTree = BehaviorDesigner.Runtime.BehaviorTree;
#endregion
#endregion

 namespace Starvoxel.BiteMe
{
	public class PatrolSpawner : EnemySpawner
	{
		#region Fields & Properties
		//const
        private const string PATROL_POINTS_VARIABLE_NAME = "PatrolPoints";

		//public
	
		//protected
	
		//private
        [SerializeField]
        private List<GameObject> m_PatrolPoints = new List<GameObject>();
	
		//properties
		#endregion
	
		#region Unity Methods
		#endregion
	
		#region Public Methods
		#endregion
	
		#region Protected Methods
        protected override void InitializeInstance(BehaviorTree instance)
        {
            instance.SetVariableValue(PATROL_POINTS_VARIABLE_NAME, m_PatrolPoints);

            base.InitializeInstance(instance);
        }
		#endregion
	
		#region Private Methods
		#endregion
	}
	
}