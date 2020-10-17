using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x4792929b)]
    public class TLMessageActionScreenshotTaken : TLAbsMessageAction
    {
        public override uint Constructor
        {
            get
            {
                return 0x4792929b;
            }
        }



    }
}
