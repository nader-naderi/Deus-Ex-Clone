using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NDRActionRPG
{
    public abstract class Weapon : MonoBehaviour
    {

        [Space]
        [Header("References")]
        public Animator anim;
        public GameObject m_ProjectilePrefab;


        [Space]
        [Header("Statistics")]
        /// <summary>
        /// Current loaded ammo in magazine.
        /// </summary>
        public int currentAmmo;
        /// <summary>
        /// How many ammo the magazine can take.
        /// </summary>
        public int magCapacityAmmo;
        /// <summary>
        /// how many ammo is provided for this weapon.
        /// </summary>
        public int totalAmmo;
        public float camAimFOV = 40;
        public float m_FireRate = 0.12f;
        public float m_BulletSpread = 0.1f;
        [HideInInspector]
        public float m_BulletSpreadAIModifier;
        public float m_Kick = 0.5f;
        public float m_HUDKick = 0.015f;

        public int damage = 30;
        public float m_MaxRange = 100f;
        public int m_LowAmmoThreshold = 5;

        [Space]
        [Header("Weapon State")]
        public bool m_Silenced;
        public bool m_LaserSight;
        public bool m_ArmorPiercing;


        public virtual void Awake()
        {

        }

        public virtual void Update()
        {

        }

        public virtual void Fire()
        {

        }    


    }
    public enum FireType
    {
        SingleShot,
        RapidFire,
        SemiAuto
    }

    public enum FirstPersonAnimation
    {
        None,
        Idle,
        Fire,
        Reload,
        Walk,
        Draw,
        Holster,
        ThrowGrenade
    }

    public enum WeaponState
    {
        Idle,
        Firing,
        Reloading,
        Holstering,
        Holstered,
        Drawing,
        Aiming
    }
}