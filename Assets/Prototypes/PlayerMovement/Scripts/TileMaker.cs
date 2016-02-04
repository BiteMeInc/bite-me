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
        [ContextMenu("Populate Grid")]
        private void PopulateGrid()
        {
            ClearGrid();

            if (m_OriginalTile != null)
            {
                m_TileGrid = new BoxCollider2D[(int)m_TileGridSize.x, (int)m_TileGridSize.y];

                Vector2 tileSize = m_OriginalTile.size;
                Vector2 gridDimesions = new Vector2(tileSize.x * m_TileGridSize.x, tileSize.y * m_TileGridSize.y);
                Vector2 halfTileSize = tileSize * 0.5f;

                BoxCollider2D curTile;
                for(int x = 0; x < m_TileGrid.GetLength(0); ++x)
                {
                    for (int y = 0; y < m_TileGrid.GetLength(1); ++y)
                    {
                        curTile = m_TileGrid[x, y] = GameObject.Instantiate<BoxCollider2D>(m_OriginalTile);
                        Vector3 tilePos = Vector3.zero;
                        tilePos.x = (-gridDimesions.x / 2) + (tileSize.x * x) + halfTileSize.x;
                        tilePos.y = (-gridDimesions.y / 2) + (tileSize.x * y) + halfTileSize.y;
                        tilePos.z = m_OriginalTile.transform.position.z;
                        curTile.transform.position = tilePos;
                        curTile.transform.parent = this.transform;
                        curTile.name = string.Format("Tile[{0},{1}]", x, y);
                    }
                }
            }


        }

        private void ClearGrid()
        {
            if (m_TileGrid != null && m_TileGrid.GetLength(0) > 0)
            {
                BoxCollider2D curTile = null;

                for (int x = 0; x < m_TileGrid.GetLength(0); ++x)
                {
                    for (int y = 0; y < m_TileGrid.GetLength(1); ++y)
                    {
                        curTile = m_TileGrid[x, y];

                        if (curTile != null)
                        {
#if UNITY_EDITOR
                            DestroyImmediate(curTile.gameObject);
#else
                            Destroy(curTile.gameObject);
#endif
                        }
                    }
                }
            }
        }
		#endregion
	}
	
}