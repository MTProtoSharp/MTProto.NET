using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Account
{
    [MTObject(0xf257106c)]
    public class TLSaveTheme : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xf257106c;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputTheme Theme { get; set; }
        [MTParameter(Order = 1)]
        public bool Unsave { get; set; }


    }
}
