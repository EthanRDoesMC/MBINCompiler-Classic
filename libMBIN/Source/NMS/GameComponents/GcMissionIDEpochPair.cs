namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0D2B07B00F953DE26)]
    public class GcMissionIDEpochPair : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string MissionID;
        public ulong RecurrenceDeadline;
    }
}