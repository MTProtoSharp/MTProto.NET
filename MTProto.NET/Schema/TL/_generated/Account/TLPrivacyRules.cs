using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Account
{
    [MTObject(0x50a04e45)]
    public class TLPrivacyRules : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x50a04e45;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<TLAbsPrivacyRule> Rules { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<TLAbsChat> Chats { get; set; }
        [MTParameter(Order = 2)]
        public TLVector<TLAbsUser> Users { get; set; }


    }
}
