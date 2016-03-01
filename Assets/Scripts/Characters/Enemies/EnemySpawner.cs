/* --------------------------
 *
 * EnemySpawner.cs
 *
 * Description: Simple spawner used for instantiating prefabs
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
#endregion

#region Other Includes
using BehaviorTree = BehaviorDesigner.Runtime.BehaviorTree;
#endregion
#endregion

 namespace Starvoxel.BiteMe
{
	public class EnemySpawner : CustomMono
	{
		#region Fields & Properties
		//const
        private static readonly Color RADIOUS_GIZMO_COLOR = Color.yellow;
	
		//public
	
		//protected
	
		//private
        [SerializeField]
        private BehaviorTree m_EnemyPrefab;
        [SerializeField]
        private int m_SpawnCount;
        [SerializeField]
        private float m_SpawnRadius;
	
		//properties
		#endregion
	
		#region Unity Methods
        private void Awake()
        {
            if (m_EnemyPrefab != null && m_SpawnCount > 0)
            {
                for(int spawnCounter = 0; spawnCounter < m_SpawnCount; ++spawnCounter)
                {
                    BehaviorTree instance = Instantiate<BehaviorTree>(m_EnemyPrefab);
                    instance.transform.parent = this.transform;

                    InitializeInstance(instance);
                }
            }
        }

        protected virtual void OnDrawGizmosSelected()
        {
            DrawRadiousGizmo();
        }
		#endregion
	
		#region Public Methods
		#endregion

        #region Protected Methods
        protected virtual void InitializeInstance(BehaviorTree instance)
        {
            Vector2 direction = new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f)).normalized;
            Vector2 position = direction * Random.Range(0.0f, m_SpawnRadius);
            instance.transform.localPosition = position;
        }

        protected void DrawRadiousGizmo()
        {
            Color oldColor = Gizmos.color;
            Gizmos.color = RADIOUS_GIZMO_COLOR;
            Gizmos.DrawWireSphere(this.transform.position, m_SpawnRadius);
            Gizmos.color = oldColor;
        }
		#endregion
	
		#region Private Methods
		#endregion
	}
	
}