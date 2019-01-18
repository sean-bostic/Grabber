using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Grabber
{
    class MicrosoftSammie
    {
        SpeechSynthesizer sammie = new SpeechSynthesizer();
        Scrape scraper = new Scrape();

        public void Say()
        {
            sammie.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            sammie.Speak(scraper.scrape());
        }
    }
}
