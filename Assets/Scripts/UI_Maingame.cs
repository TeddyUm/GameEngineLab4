using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Character
{
    public class UI_Maingame : MonoBehaviour
    {
        public Text ammoText;
        public WeaponHolder weapon;

        // Update is called once per frame
        void Update()
        {
            ammoText.text = "Ammo: " + weapon.GetEquipWeapon().WeaponStats.BulletsInClip;
        }
    }
}