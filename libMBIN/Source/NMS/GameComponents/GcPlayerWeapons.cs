﻿namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0D688A2199D952E15)]
    public class GcPlayerWeapons : NMSTemplate
    {
		public enum WeaponModeEnum { Bolt, Shotgun, Burst, Laser, Rail, Grenade, MineGrenade, Scope, FrontShield, TerrainEdit }
		public WeaponModeEnum WeaponMode;
    }
}