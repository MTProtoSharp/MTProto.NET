using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Help
{
    [MTObject(0x9010ef6f)]
    public class TLGetAppChangelog : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x9010ef6f;
            }
        }

        [MTParameter(Order = 0)]
        public string PrevAppVersion { get; set; }


    }
}
