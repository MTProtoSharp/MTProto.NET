using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xa20db0e5)]
    public class TLUpdateDeleteMessages : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0xa20db0e5;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<int> Messages { get; set; }
        [MTParameter(Order = 1)]
        public int Pts { get; set; }
        [MTParameter(Order = 2)]
        public int PtsCount { get; set; }


    }
}
