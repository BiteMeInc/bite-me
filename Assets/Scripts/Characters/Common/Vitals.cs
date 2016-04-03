/* --------------------------
 *
 * Vitals.cs
 *
 * Description: Simplistic class that takes care of dealing with the health and armour of a character
 *
 * Author: Jeremy Smellie
 *
 * Editors:
 *
 * 3/1/2016 - Starvoxel
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
	public class Vitals
	{
		#region Fields & Properties
		//const
	
		//public
	
		//protected
        [Header("Health")]
        [SerializeField] protected float m_MaxHealth = 100;
        [SerializeField] protected float m_CurrentHealth = 100;

        [Header("Armor")]
        [SerializeField] protected float m_MaxArmor = 0;
        [SerializeField] protected float m_CurrentArmor = 0;

        public event System.Action<Vitals> OnDead;
		//private
	
		//properties
        public float MaxHealth
        {
            get { return m_MaxHealth; }
        }
        public float CurrentHealth
        {
            get { return m_CurrentHealth; }
        }

        public float MaxArmor
        {
            get { return m_MaxArmor; }
        }
        public float CurrentArmor
        {
            get { return m_CurrentArmor; }
        }

        public bool IsAlive
        {
            get { return m_CurrentHealth > 0; }
        }
		#endregion

        #region Public Methods
         public virtual void Initialize()
        {
            UpdateCurrentValues();
        }

        /// <summary>
        /// Udates the health values based off the damage passed in
        /// </summary>
        /// <param name="damage">Damage to be done</param>
        public virtual void TakeDamage(float damage)
        {
            /* TODO jsmellie: Figure out what the algorithm for the damage should be...  How does armor work?  
             * Does it take 100% of the damage while it exists? Is it just some kind of damage reductions?
             * For now armor is just a second health bar more or less
             * */

            // If we have armor, take the damage from that first
            if (m_CurrentArmor != 0)
            {
                if (damage > m_CurrentArmor)
                {
                    damage -= m_CurrentArmor;
                    m_CurrentArmor = 0;
                }
                else
                {
                    m_CurrentArmor -= damage;
                    damage = 0;
                }
            }

            // If there's any damage left to go to the health, do that calculation now
            if (damage > 0)
            {
                m_CurrentHealth -= damage;

                // If we're now dead, fire the dead event
                if (m_CurrentHealth <= 0)
                {
                    if (OnDead != null)
                    {
                        OnDead(this);
                    }
                }
            }
        }
		#endregion
	
		#region Protected Methods
        /// <summary>
        /// Updates the current values to make sure they aren't higher then the max values
        /// </summary>
        protected void UpdateCurrentValues()
        {
            if (m_CurrentHealth > m_MaxHealth)
            {
                m_CurrentHealth = m_MaxHealth;
            }

            if (m_CurrentArmor > m_MaxArmor)
            {
                m_CurrentArmor = m_MaxArmor;
            }
        }
		#endregion
	
		#region Private Methods
		#endregion
	}
	
}