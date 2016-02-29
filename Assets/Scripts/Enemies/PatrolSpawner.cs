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

        private static readonly Color PATROL_POINT_GIZMO_COLOR = Color.cyan;
		//public
	
		//protected
	
		//private
        [SerializeField]
        private List<GameObject> m_PatrolPoints = new List<GameObject>();
	
		//properties
		#endregion
	
		#region Unity Methods
        protected override void OnDrawGizmosSelected()
        {
            base.OnDrawGizmosSelected();

            if (m_PatrolPoints != null && m_PatrolPoints.Count > 0)
            {
                for (int pointCounter = 0; pointCounter < m_PatrolPoints.Count; ++pointCounter)
                {
                    Color oldColor = Gizmos.color;
                    Gizmos.color = PATROL_POINT_GIZMO_COLOR;
                    Gizmos.DrawCube(m_PatrolPoints[pointCounter].transform.position, Vector3.one);
                    Gizmos.color = oldColor;
                }
            }
        }
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