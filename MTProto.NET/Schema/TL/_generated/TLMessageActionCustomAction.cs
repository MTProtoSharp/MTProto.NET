using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xfae69f56)]
    public class TLMessageActionCustomAction : TLAbsMessageAction
    {
        public override uint Constructor
        {
            get
            {
                return 0xfae69f56;
            }
        }

        [MTParameter(Order = 0)]
        public string Message { get; set; }


    }
}
