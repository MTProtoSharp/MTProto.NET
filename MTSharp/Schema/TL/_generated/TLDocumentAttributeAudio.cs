using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
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

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 10, FlagType = FlagType.True)]
        public bool Voice { get; set; }
        [MTParameter(Order = 2)]
        public int Duration { get; set; }
        [MTParameter(Order = 3, FromFlag = 0, FlagType = FlagType.Null)]
        public string Title { get; set; }
        [MTParameter(Order = 4, FromFlag = 1, FlagType = FlagType.Null)]
        public string Performer { get; set; }
        [MTParameter(Order = 5, FromFlag = 2, FlagType = FlagType.Null)]
        public byte[] Waveform { get; set; }


    }
}
