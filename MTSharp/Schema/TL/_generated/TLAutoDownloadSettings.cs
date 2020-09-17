using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
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

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 0, FlagType = FlagType.True)]
        public bool Disabled { get; set; }
        [MTParameter(Order = 2, FromFlag = 1, FlagType = FlagType.True)]
        public bool VideoPreloadLarge { get; set; }
        [MTParameter(Order = 3, FromFlag = 2, FlagType = FlagType.True)]
        public bool AudioPreloadNext { get; set; }
        [MTParameter(Order = 4, FromFlag = 3, FlagType = FlagType.True)]
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
