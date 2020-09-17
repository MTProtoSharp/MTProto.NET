using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Help
{
    [MTObject(0x522d5a7d)]
    public class TLGetAppUpdate : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x522d5a7d;
            }
        }

        [MTParameter(Order = 0)]
        public string Source { get; set; }


    }
}
