using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Account
{
    [MTObject(0xcff43f61)]
    public class TLSetContactSignUpNotification : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xcff43f61;
            }
        }

        [MTParameter(Order = 0)]
        public bool Silent { get; set; }


    }
}
