using Exiled.API.Interfaces;

namespace ConsoleWriter
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; }
        public bool Debug { get; set; }
    }
}