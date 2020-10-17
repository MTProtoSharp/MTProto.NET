using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Account
{
    [MTObject(0x8d9d742b)]
    public class TLGetTheme : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x8d9d742b;
            }
        }

        [MTParameter(Order = 0)]
        public string Format { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsInputTheme Theme { get; set; }
        [MTParameter(Order = 2)]
        public long DocumentId { get; set; }


    }
}
