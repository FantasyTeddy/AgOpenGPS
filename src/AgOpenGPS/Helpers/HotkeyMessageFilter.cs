using System;
using System.Windows.Forms;

namespace AgOpenGPS.Helpers
{
    public sealed class HotkeyMessageFilter : IMessageFilter, IDisposable
    {
        private readonly FormGPS _mf;

        private const int WM_KEYDOWN = 0x0100;
        private const int WM_SYSKEYDOWN = 0x0104;

        public HotkeyMessageFilter(FormGPS mf)
        {
            _mf = mf ?? throw new ArgumentNullException(nameof(mf));
        }

        public bool Enabled { get; set; } = true;

        public bool PreFilterMessage(ref Message m)
        {
            if (!Enabled) return false;
            if (m.Msg is not WM_KEYDOWN and not WM_SYSKEYDOWN) return false;

            // if user in typing in textbox, ignore hotkey
            if (IsTypingContext()) return false;

            Keys key = (Keys)m.WParam.ToInt32();

            // Let FormGPS do the handling
            return _mf.HandleAppWideKey(key);
        }

        private static bool IsTypingContext()
        {
            Form af = Form.ActiveForm;
            if (af == null) return false;
            Control c = af.ActiveControl;
            while (c != null)
            {
                if (c is TextBoxBase) return true;
                c = c.Parent;
            }
            return false;
        }

        public void Dispose() { }
    }
}
