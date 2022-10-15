namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8441FC271F1896CA, NameHash = 0x489841A427B2161E)]
    public class GcInventoryStackSizeGroup : NMSTemplate
    {
        // size: 0xC
        public enum InventoryStackSizeGroupEnum {
            Default,
            Personal,
            PersonalCargo,
            Ship,
            ShipCargo,
            Freighter,
            FreighterCargo,
            Vehicle,
            Chest,
            BaseCapsule,
            MaintenanceObject,
            UIPopup
        }
        /* 0x0 */ public InventoryStackSizeGroupEnum InventoryStackSizeGroup;
    }
}