using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Contacts
{
    [MTObject(0x2c800be5)]
    public class TLImportContacts : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x2c800be5;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<MTSharp.Schema.TL.TLInputPhoneContact> Contacts { get; set; }


    }
}
