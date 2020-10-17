using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Messages
{
    [MTObject(0x84d19185)]
    public class TLAffectedMessages : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x84d19185;
            }
        }

        [MTParameter(Order = 0)]
        public int Pts { get; set; }
        [MTParameter(Order = 1)]
        public int PtsCount { get; set; }


    }
}
