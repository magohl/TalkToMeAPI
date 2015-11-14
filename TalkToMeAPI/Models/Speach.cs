using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalkToMeAPI.Models
{
    /// <summary>
    /// Class that will be used in the API APP to send the text to be read
    /// This should be extended with stuff like language/voice, speed etc.
    /// </summary>
    public class Speach
    {
        public string TextToRead { get; set; }
    }
}
