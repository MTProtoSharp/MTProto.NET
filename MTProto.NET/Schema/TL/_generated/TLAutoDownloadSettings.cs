using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xe04232f3)]
    public class TLAutoDownloadSettings : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xe04232f3;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool Disabled { get; set; }
        [MTParameter(Order = 2, FlagBitId = 1, FlagType = FlagType.True)]
        public bool VideoPreloadLarge { get; set; }
        [MTParameter(Order = 3, FlagBitId = 2, FlagType = FlagType.True)]
        public bool AudioPreloadNext { get; set; }
        [MTParameter(Order = 4, FlagBitId = 3, FlagType = FlagType.True)]
        public bool PhonecallsLessData { get; set; }
        [MTParameter(Order = 5)]
        public int PhotoSizeMax { get; set; }
        [MTParameter(Order = 6)]
        public int VideoSizeMax { get; set; }
        [MTParameter(Order = 7)]
        public int FileSizeMax { get; set; }
        [MTParameter(Order = 8)]
        public int VideoUploadMaxbitrate { get; set; }


    }
}
