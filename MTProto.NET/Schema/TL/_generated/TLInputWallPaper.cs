using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xe630b979)]
    public class TLInputWallPaper : TLAbsInputWallPaper
    {
        public override uint Constructor
        {
            get
            {
                return 0xe630b979;
            }
        }

        [MTParameter(Order = 0)]
        public long Id { get; set; }
        [MTParameter(Order = 1)]
        public long AccessHash { get; set; }


    }
}
