using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests
{
    [MTObject(0x365275f2)]
    public class TLInvokeWithMessagesRange : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x365275f2;
            }
        }

        [MTParameter(Order = 0)]
        public MTSharp.Schema.TL.TLMessageRange Range { get; set; }
        [MTParameter(Order = 1)]
        public MTObject Query { get; set; }


    }
}
