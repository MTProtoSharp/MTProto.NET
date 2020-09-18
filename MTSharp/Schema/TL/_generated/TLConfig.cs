using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MTSharp;
using MTSharp.Attributes;
using MTSharp.Enums;
using MTSharp.Schema;
using MTSharp.Schema.TL;

namespace MTSharp.Schema.TL
{
    [MTObject(0x330b4067)]
    public class TLConfig : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x330b4067;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FlagBitId=1, FlagType= FlagType.True)]
		public bool PhonecallsEnabled { get; set; }
		[MTParameter(Order = 2, FlagBitId=3, FlagType= FlagType.True)]
		public bool DefaultP2pContacts { get; set; }
		[MTParameter(Order = 3, FlagBitId=4, FlagType= FlagType.True)]
		public bool PreloadFeaturedStickers { get; set; }
		[MTParameter(Order = 4, FlagBitId=5, FlagType= FlagType.True)]
		public bool IgnorePhoneEntities { get; set; }
		[MTParameter(Order = 5, FlagBitId=6, FlagType= FlagType.True)]
		public bool RevokePmInbox { get; set; }
		[MTParameter(Order = 6, FlagBitId=8, FlagType= FlagType.True)]
		public bool BlockedMode { get; set; }
		[MTParameter(Order = 7, FlagBitId=13, FlagType= FlagType.True)]
		public bool PfsEnabled { get; set; }
		[MTParameter(Order = 8)]
		public int Date { get; set; }
		[MTParameter(Order = 9)]
		public int Expires { get; set; }
		[MTParameter(Order = 10)]
		public bool TestMode { get; set; }
		[MTParameter(Order = 11)]
		public int ThisDc { get; set; }
		[MTParameter(Order = 12)]
		public TLVector<MTSharp.Schema.TL.TLDcOption> DcOptions { get; set; }
		[MTParameter(Order = 13)]
		public string DcTxtDomainName { get; set; }
		[MTParameter(Order = 14)]
		public int ChatSizeMax { get; set; }
		[MTParameter(Order = 15)]
		public int MegagroupSizeMax { get; set; }
		[MTParameter(Order = 16)]
		public int ForwardedCountMax { get; set; }
		[MTParameter(Order = 17)]
		public int OnlineUpdatePeriodMs { get; set; }
		[MTParameter(Order = 18)]
		public int OfflineBlurTimeoutMs { get; set; }
		[MTParameter(Order = 19)]
		public int OfflineIdleTimeoutMs { get; set; }
		[MTParameter(Order = 20)]
		public int OnlineCloudTimeoutMs { get; set; }
		[MTParameter(Order = 21)]
		public int NotifyCloudDelayMs { get; set; }
		[MTParameter(Order = 22)]
		public int NotifyDefaultDelayMs { get; set; }
		[MTParameter(Order = 23)]
		public int PushChatPeriodMs { get; set; }
		[MTParameter(Order = 24)]
		public int PushChatLimit { get; set; }
		[MTParameter(Order = 25)]
		public int SavedGifsLimit { get; set; }
		[MTParameter(Order = 26)]
		public int EditTimeLimit { get; set; }
		[MTParameter(Order = 27)]
		public int RevokeTimeLimit { get; set; }
		[MTParameter(Order = 28)]
		public int RevokePmTimeLimit { get; set; }
		[MTParameter(Order = 29)]
		public int RatingEDecay { get; set; }
		[MTParameter(Order = 30)]
		public int StickersRecentLimit { get; set; }
		[MTParameter(Order = 31)]
		public int StickersFavedLimit { get; set; }
		[MTParameter(Order = 32)]
		public int ChannelsReadMediaPeriod { get; set; }
		[MTParameter(Order = 33, FlagBitId=0, FlagType= FlagType.Null)]
		public int? TmpSessions { get; set; }
		[MTParameter(Order = 34)]
		public int PinnedDialogsCountMax { get; set; }
		[MTParameter(Order = 35)]
		public int PinnedInfolderCountMax { get; set; }
		[MTParameter(Order = 36)]
		public int CallReceiveTimeoutMs { get; set; }
		[MTParameter(Order = 37)]
		public int CallRingTimeoutMs { get; set; }
		[MTParameter(Order = 38)]
		public int CallConnectTimeoutMs { get; set; }
		[MTParameter(Order = 39)]
		public int CallPacketTimeoutMs { get; set; }
		[MTParameter(Order = 40)]
		public string MeUrlPrefix { get; set; }
		[MTParameter(Order = 41, FlagBitId=7, FlagType= FlagType.Null)]
		public string AutoupdateUrlPrefix { get; set; }
		[MTParameter(Order = 42, FlagBitId=9, FlagType= FlagType.Null)]
		public string GifSearchUsername { get; set; }
		[MTParameter(Order = 43, FlagBitId=10, FlagType= FlagType.Null)]
		public string VenueSearchUsername { get; set; }
		[MTParameter(Order = 44, FlagBitId=11, FlagType= FlagType.Null)]
		public string ImgSearchUsername { get; set; }
		[MTParameter(Order = 45, FlagBitId=12, FlagType= FlagType.Null)]
		public string StaticMapsProvider { get; set; }
		[MTParameter(Order = 46)]
		public int CaptionLengthMax { get; set; }
		[MTParameter(Order = 47)]
		public int MessageLengthMax { get; set; }
		[MTParameter(Order = 48)]
		public int WebfileDcId { get; set; }
		[MTParameter(Order = 49, FlagBitId=2, FlagType= FlagType.Null)]
		public string SuggestedLangCode { get; set; }
		[MTParameter(Order = 50, FlagBitId=2, FlagType= FlagType.Null)]
		public int? LangPackVersion { get; set; }
		[MTParameter(Order = 51, FlagBitId=2, FlagType= FlagType.Null)]
		public int? BaseLangPackVersion { get; set; }


    }
}
