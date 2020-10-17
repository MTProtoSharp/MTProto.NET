using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x9852f9c6)]
    public class TLDocumentAttributeAudio : TLAbsDocumentAttribute
    {
        public override uint Constructor
        {
            get
            {
                return 0x9852f9c6;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 10, FlagType = FlagType.True)]
        public bool Voice { get; set; }
        [MTParameter(Order = 2)]
        public int Duration { get; set; }
        [MTParameter(Order = 3, FlagBitId = 0, FlagType = FlagType.Null)]
        public string Title { get; set; }
        [MTParameter(Order = 4, FlagBitId = 1, FlagType = FlagType.Null)]
        public string Performer { get; set; }
        [MTParameter(Order = 5, FlagBitId = 2, FlagType = FlagType.Null)]
        public byte[] Waveform { get; set; }


    }
}
