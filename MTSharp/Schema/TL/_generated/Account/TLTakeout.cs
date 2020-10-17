using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Account
{
    [MTObject(0x4dba4501)]
    public class TLTakeout : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x4dba4501;
            }
        }

        [MTParameter(Order = 0)]
        public long Id { get; set; }


    }
}
