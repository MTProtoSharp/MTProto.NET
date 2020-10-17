using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Help
{
    [MTObject(0x3dc0f114)]
    public class TLGetRecentMeUrls : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x3dc0f114;
            }
        }

        [MTParameter(Order = 0)]
        public string Referer { get; set; }


    }
}
