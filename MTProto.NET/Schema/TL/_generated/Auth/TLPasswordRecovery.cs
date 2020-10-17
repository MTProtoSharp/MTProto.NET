using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Auth
{
    [MTObject(0x137948a5)]
    public class TLPasswordRecovery : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x137948a5;
            }
        }

        [MTParameter(Order = 0)]
        public string EmailPattern { get; set; }


    }
}
