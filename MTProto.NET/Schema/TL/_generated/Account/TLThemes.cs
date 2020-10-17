using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Account
{
    [MTObject(0x7f676421)]
    public class TLThemes : TLAbsThemes
    {
        public override uint Constructor
        {
            get
            {
                return 0x7f676421;
            }
        }

        [MTParameter(Order = 0)]
        public int Hash { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<MTProto.NET.Schema.TL.TLTheme> Themes { get; set; }


    }
}
