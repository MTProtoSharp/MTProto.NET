using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x50f41ccf)]
    public class TLKeyboardButtonGame : TLAbsKeyboardButton
    {
        public override uint Constructor
        {
            get
            {
                return 0x50f41ccf;
            }
        }

        [MTParameter(Order = 0)]
        public string Text { get; set; }


    }
}
