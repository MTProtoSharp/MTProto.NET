using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xe9a734fa)]
    public class TLPhotoCachedSize : TLAbsPhotoSize
    {
        public override uint Constructor
        {
            get
            {
                return 0xe9a734fa;
            }
        }

        [MTParameter(Order = 0)]
        public string Type { get; set; }
        [MTParameter(Order = 1)]
        public MTProto.NET.Schema.TL.TLFileLocationToBeDeprecated Location { get; set; }
        [MTParameter(Order = 2)]
        public int W { get; set; }
        [MTParameter(Order = 3)]
        public int H { get; set; }
        [MTParameter(Order = 4)]
        public byte[] Bytes { get; set; }


    }
}
