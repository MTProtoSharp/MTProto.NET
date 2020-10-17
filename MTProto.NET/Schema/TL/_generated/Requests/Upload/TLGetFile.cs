using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL.Requests.Upload
{
    [MTObject(0xb15a9afc)]
    public class TLGetFile : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xb15a9afc;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool Precise { get; set; }
        [MTParameter(Order = 2, FlagBitId = 1, FlagType = FlagType.True)]
        public bool CdnSupported { get; set; }
        [MTParameter(Order = 3)]
        public TLAbsInputFileLocation Location { get; set; }
        [MTParameter(Order = 4)]
        public int Offset { get; set; }
        [MTParameter(Order = 5)]
        public int Limit { get; set; }


    }
}
