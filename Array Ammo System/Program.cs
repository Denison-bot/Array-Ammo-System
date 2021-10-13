using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Ammo_System
{
    class Program
    {

        static void Main(string[] args)
        {
            // arrays 

            // weapon capacity
            int[] ammo = new int[3];
            ammo[0] = 6; //revolver
            ammo[1] = 8; //repeater
            ammo[2] = 4; //shotty
            // weapon capacity
            string[] weaponName = new string[3];
            weaponName[0] = "Revolver";
            weaponName[1] = "Repeater";
            weaponName[2] = "Shotty";
            // weapon capacity
            int[] ammoCapacity = new int[3];           
            ammoCapacity[0] = 6;
            ammoCapacity[1] = 8;
            ammoCapacity[2] = 4;
            // ammo reserves
            // ammo reserves are mesured in clips
            int[] ammoReserves = new int[3];
            ammoReserves[0] = 4;
            ammoReserves[1] = 3;
            ammoReserves[2] = 2;

            // add ammo reserves
            Random rnd = new Random();
            int ammoPack = rnd.Next(1, 4);

            int weapon = 1; //current weapon

            void Fire()
            {
                ammo[weapon] = ammo[weapon] - 1;

                if (ammo[weapon] <= 0)
                {
                    ammo[weapon] = 0;
                }
            }
            void FireTwice()
            {
                ammo[weapon] = ammo[weapon] - 2;
                if (ammo[weapon] <= 0)
                {
                    ammo[weapon] = 0;
                }
            }

            void Reload()
            {
                
                ammoReserves[weapon] = ammoReserves[weapon] - 1;
                if (ammoReserves[weapon] <= 0)
                {
                    ammoReserves[weapon] = 0;
                }
                if (ammoReserves[weapon] <= 0) 
                {
                    ammo[weapon] = 0;
                }
                else if (ammoReserves[weapon] > 0) 
                {
                    ammo[weapon] = ammoCapacity[weapon];
                }
            }

            void PickUpAmmoPack()
            {
                ammoPack = rnd.Next(1, 4);
                ammoReserves[weapon] = ammoReserves[weapon] + ammoPack;
            }

            void ShowHUD()
            {
                Console.WriteLine(" ");
                Console.WriteLine("----------------------");
                Console.WriteLine(weaponName[weapon] + " Ammo: " + ammo[weapon]);
                Console.WriteLine(weaponName[weapon] + " Ammo Reserves: " + ammoReserves[weapon]);
                Console.WriteLine("----------------------");
                Console.WriteLine(" ");
                Console.ReadKey(true);
            }

            Console.WriteLine("Reload System with Arrays");
            ShowHUD();
            PickUpAmmoPack();
            ShowHUD();
            Fire();
            ShowHUD();
            FireTwice();
            ShowHUD();
            Reload();
            ShowHUD();
            Fire();
            ShowHUD();
            PickUpAmmoPack();
            ShowHUD();
            FireTwice();
            ShowHUD();
            Reload();
            ShowHUD();
            PickUpAmmoPack();
            ShowHUD();




            Console.ReadKey(true);
        }
    }
}
