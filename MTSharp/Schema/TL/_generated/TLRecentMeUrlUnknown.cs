using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x46e1d13d)]
    public class TLRecentMeUrlUnknown : TLAbsRecentMeUrl
    {
        public override uint Constructor
        {
            get
            {
                return 0x46e1d13d;
            }
        }

        [MTParameter(Order = 0)]
        public string Url { get; set; }


    }
}
