using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.Events.EventArgs.Player;

namespace StartMessage.EventHandlers
{
    public static class Verified
    {
        public static void OnVerified(VerifiedEventArgs ev)
        {
            ev.Player.SendConsoleMessage(Class1.Instance.Translation.StartConsoleMessage, "red");
        }
    }
}
