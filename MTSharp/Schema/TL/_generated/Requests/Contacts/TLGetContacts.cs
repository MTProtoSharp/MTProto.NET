using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Contacts
{
    [MTObject(0xc023849f)]
    public class TLGetContacts : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xc023849f;
            }
        }

        [MTParameter(Order = 0)]
        public int Hash { get; set; }


    }
}
