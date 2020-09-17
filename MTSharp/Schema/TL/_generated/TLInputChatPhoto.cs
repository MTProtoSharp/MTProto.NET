using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x8953ad37)]
    public class TLInputChatPhoto : TLAbsInputChatPhoto
    {
        public override uint Constructor
        {
            get
            {
                return 0x8953ad37;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputPhoto Id { get; set; }


    }
}
