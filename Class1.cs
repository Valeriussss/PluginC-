using Exiled.API.Features;
using Exiled.Loader;
using player = Exiled.Events.Handlers.Player;

namespace StartMessage
{
    public class Class1 : Plugin<Config, Translations>

    {
        public override string Name => "ConsoleWriter";
        public static Class1 Instance;
        public override void OnEnabled()
        {
            Instance = this;
            player.Verified += StartMessage.EventHandlers.Verified.OnVerified;
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Instance = null;
            player.Verified -= StartMessage.EventHandlers.Verified.OnVerified;
            base.OnDisabled();
        }
    }
}