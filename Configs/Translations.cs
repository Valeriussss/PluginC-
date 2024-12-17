using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Interfaces;

namespace StartMessage
{
    public class Translations : ITranslation
    {
        public string StartConsoleMessage { get; set; } = "SigmaMessage";
    }
}
