using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Help
{
    [MTObject(0x3fedc75f)]
    public class TLGetDeepLinkInfo : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x3fedc75f;
            }
        }

        [MTParameter(Order = 0)]
        public string Path { get; set; }


    }
}
