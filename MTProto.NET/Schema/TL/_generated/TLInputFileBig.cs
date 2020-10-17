using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xfa4f0bb5)]
    public class TLInputFileBig : TLAbsInputFile
    {
        public override uint Constructor
        {
            get
            {
                return 0xfa4f0bb5;
            }
        }

        [MTParameter(Order = 0)]
        public long Id { get; set; }
        [MTParameter(Order = 1)]
        public int Parts { get; set; }
        [MTParameter(Order = 2)]
        public string Name { get; set; }


    }
}
