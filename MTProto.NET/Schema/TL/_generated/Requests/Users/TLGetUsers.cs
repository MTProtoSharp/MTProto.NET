using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Users
{
    [MTObject(0xd91a548)]
    public class TLGetUsers : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xd91a548;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<TLAbsInputUser> Id { get; set; }


    }
}
