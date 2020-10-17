using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xa01b22f9)]
    public class TLRecentMeUrlChat : TLAbsRecentMeUrl
    {
        public override uint Constructor
        {
            get
            {
                return 0xa01b22f9;
            }
        }

        [MTParameter(Order = 0)]
        public string Url { get; set; }
        [MTParameter(Order = 1)]
        public int ChatId { get; set; }


    }
}
