using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Account
{
    [MTObject(0x6628562c)]
    public class TLUpdateStatus : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x6628562c;
            }
        }

        [MTParameter(Order = 0)]
        public bool Offline { get; set; }


    }
}
