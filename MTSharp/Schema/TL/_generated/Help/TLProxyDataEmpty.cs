using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Help
{
    [MTObject(0xe09e1fb8)]
    public class TLProxyDataEmpty : TLAbsProxyData
    {
        public override uint Constructor
        {
            get
            {
                return 0xe09e1fb8;
            }
        }

        [MTParameter(Order = 0)]
        public int Expires { get; set; }


    }
}
