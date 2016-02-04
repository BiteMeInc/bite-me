/* --------------------------
 *
 * TileMaker.cs
 *
 * Description: 
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
	public class TileMaker : CustomMono
	{
		#region Fields & Properties
		//const
	
		//public
	
		//protected
	
		//private
        [SerializeField] BoxCollider2D m_OriginalTile;
        [SerializeField] Vector2 m_TileGridSize = Vector2.one;
        [SerializeField] BoxCollider2D[,] m_TileGrid;
	
		//properties
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