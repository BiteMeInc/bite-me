/* --------------------------
 *
 * Character.cs
 *
 * Description: Base class for everything shared between all characters
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
    [ExecuteInEditMode]
    public class Character : CustomMono
    {
        #region Fields & Properties
        //const

        //public

        //protected
        [SerializeField] protected Inventory m_Inventory;
        [SerializeField] protected Vitals m_Vitals;

        //private

        //properties
        public Inventory Inventory
        {
            get { return m_Inventory; }
        }

        public Vitals Vitals
        {
            get { return m_Vitals; }
        }
        #endregion

        #region Unity Methods
        protected virtual void Awake()
        {
            m_Inventory.Initialize();
            m_Vitals.Initialize();
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