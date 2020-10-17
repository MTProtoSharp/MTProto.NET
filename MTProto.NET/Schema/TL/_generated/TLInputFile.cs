using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xf52ff27f)]
    public class TLInputFile : TLAbsInputFile
    {
        public override uint Constructor
        {
            get
            {
                return 0xf52ff27f;
            }
        }

        [MTParameter(Order = 0)]
        public long Id { get; set; }
        [MTParameter(Order = 1)]
        public int Parts { get; set; }
        [MTParameter(Order = 2)]
        public string Name { get; set; }
        [MTParameter(Order = 3)]
        public string Md5Checksum { get; set; }


    }
}
