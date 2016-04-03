/* --------------------------
 *
 * Inventory.cs
 *
 * Description: Holder class for everything that the character is carrying
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
    [System.Serializable]
    public class Inventory
    {
        #region Fields & Properties
        //const

        //public

        //protected
        protected Weapon m_EquipedWeapon;

        [SerializeField] protected Weapon m_PrimaryWeapon;
        [SerializeField] protected Weapon m_SecondaryWeapon;
        //private

        //properties
        public Weapon EquipedWeapon
        {
            get { return m_EquipedWeapon; }
        }

        public Weapon HolsteredWeapon
        {
            get
            {
                if (m_EquipedWeapon == m_PrimaryWeapon)
                {
                    return m_SecondaryWeapon;
                }
                else
                {
                    return m_PrimaryWeapon;
                }
            }
        }

        public Weapon PrimaryWeapon
        {
            get { return m_PrimaryWeapon; }
        }

        public Weapon SecondaryWeapon
        {
            get { return m_SecondaryWeapon; }
        }
        #endregion

        #region Constructors
        #endregion

        #region Public Methods
        public void Initialize()
        {
            if (m_PrimaryWeapon != null)
            {
                m_EquipedWeapon = m_PrimaryWeapon;
            }
            else
            {
                m_EquipedWeapon = m_SecondaryWeapon;
            }
        }

        public void DropEquipedWeapon()
        {
            //TODO jsmellie:  Do the actual dropping here.  More so then just setting the weapon to null
        }

        public void SwitchWeapons()
        {
            if (m_EquipedWeapon == m_PrimaryWeapon)
            {
                m_EquipedWeapon = m_SecondaryWeapon;
            }
            else
            {
                m_EquipedWeapon = m_PrimaryWeapon;
            }
        }

        #endregion

        #region Protected Methods
        #endregion

        #region Private Methods
        #endregion
    }

}