using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Contacts
{
    [MTObject(0xeae87e42)]
    public class TLContacts : TLAbsContacts
    {
        public override uint Constructor
        {
            get
            {
                return 0xeae87e42;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<MTProto.NET.Schema.TL.TLContact> Contacts { get; set; }
        [MTParameter(Order = 1)]
        public int SavedCount { get; set; }
        [MTParameter(Order = 2)]
        public TLVector<TLAbsUser> Users { get; set; }


    }
}
