using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x8dbc3336)]
    public class TLRecentMeUrlUser : TLAbsRecentMeUrl
    {
        public override uint Constructor
        {
            get
            {
                return 0x8dbc3336;
            }
        }

        [MTParameter(Order = 0)]
        public string Url { get; set; }
        [MTParameter(Order = 1)]
        public int UserId { get; set; }


    }
}
