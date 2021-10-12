using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Ammo_System
{
    class Program
    {

       
        static int[] ammo = new int[3];
        static string[] weaponName = new string[3];
        static int[] ammoCapacity = new int[3];

        

        static void Main(string[] args)
        {
            int weapon = 2; //current weapon

            void Fire()
            {
                ammo[weapon] = ammo[weapon] - 1;
            }

            void Reload()
            {
                ammo[weapon] = ammoCapacity[weapon];
            }

            void ShowHUD()
            {
                Console.WriteLine(weaponName[weapon] + " Ammo: " + ammo[weapon]);
            }

            Console.WriteLine("Reload System with Arrays");

            // weapon ammo
            ammo[0] = 6; //revolver
            ammo[1] = 8; //repeater
            ammo[2] = 4; //shotty
            // weapon name 
            weaponName[0] = "Revolver";
            weaponName[1] = "Repeater";
            weaponName[2] = "Shotty";
            // weapon capacity
            ammoCapacity[0] = 6;
            ammoCapacity[1] = 8;
            ammoCapacity[2] = 4;

            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Reload();
            ShowHUD();

            Console.ReadKey(true);
        }
    }
}
