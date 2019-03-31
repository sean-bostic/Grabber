using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grabber
{
    public class Scrape
    {
        //public Grabber MyForm;

        //public Scrape(Grabber form)
        //{
        //    this.MyForm = form;
        //}
        /// <summary>
        /// Main engine of the scraper. It will perform the function of scraping from the website and writing it to a file to read from. fadsfasfadsfasdfasdf
        /// </summary>
        /// <returns></returns>
        public string scrape()
        {
            string text = File.ReadAllText(@"Z:\code\Miscellaneous Projects\Grabber\Grabber\test.txt");
            return text;
        }

        /// <summary>
        /// Grabs the source from the form of the urlSource textbox.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public string GetSource(string source)
        {
            string textSource = source;
            return textSource;
        }

        /// <summary>
        /// Takes the scraped text and displays it in a quick read format one word at a time at varying speeds.
        /// </summary>
        /// <returns></returns>    
        public void SpeedRead()
        {
            Grabber grabber = new Grabber();
            //1.)Take what is in the output file and display it one word at a time in the richTextBox
            string[] lines = File.ReadAllLines(@"Z:\code\Miscellaneous Projects\Grabber\Grabber\test.txt");
            foreach (string line in lines)
            {

            }
            //string[] lines = textFromFile.Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //2.)Varying speeds of how fast each word is shown
        }
    }
}
