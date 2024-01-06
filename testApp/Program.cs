using ManOWarEncLibrary;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace testApp
{
    class Program
    {
        static void Main(string[] args)
        {

            clsEncLibrary objEncDec2 = new clsEncLibrary();
            string originalStr = "Good girl! said Larth, proud of his daughter’s memory and powers of observation. He was a strong, handsome man with flecks of gray in his black beard. His wife had borne several children, but all had died very young except Lara, the last, whom his wife had died bearing. Lara was very precious to him. Like her mother, she had golden hair. Now that she had reached the age of childbearing, Lara was beginning to display the fullness of a woman’s hips and breasts. It was Larth’s greatest wish that he might live to see his own grandchildren. Not every man lived that long, but Larth was hopeful. He had been healthy all his life, partly, he believed, because he had always been careful to show respect to the numina he encountered on his journeys.";
            originalStr += "  Respecting the numina was important.The numen of the river could suck a man under and drown him.The numen of a tree could trip a man with its roots, or drop a rotten branch on his head.Rocks could give way underfoot, chuckling with amusement at their own treachery.Even the sky, with a roar of fury, sometimes sent down fingers of fire that could roast a man like a rabbit on a spit, or worse, leave him alive but robbed of his senses.Larth had heard that the earth itself could open and swallow a man; though he had never actually seen such a thing, he nevertheless performed a ritual each morning, asking the earth’s permission before he went striding across it.";
            originalStr += " There’s something so special about this place,” said Lara, gazing at the sparkling river to her left and then at the rocky, tree-spotted hills ahead and to her right. How was it made? Who made it ?";
            originalStr += "  Larth frowned. The question made no sense to him.A place was never made, it simply was.Small features might change over time. Uprooted by a storm, a tree might fall into the river. A boulder might decide to tumble down the hillside.The numina that animated all things went about reshaping the landscape from day to day, but the essential things never changed, and had always existed: the river, the hills, the sky, the sun, the sea, the salt beds at the mouth of the river. He was trying to think of some way to express these thoughts to Lara, when a deer, drinking at the river, was startled by their approach.The deer bolted up the brushy bank and onto the path.Instead of running to safety, the creature stood and stared at them.As clearly as if the animal had whispered aloud, Larth heard the words “Eat me.” The deer was offering herself.";
            originalStr += "  Larth turned to shout an order, but the most skilled hunter of the group, a youth called Po, was already in motion.Po ran forward, raised the sharpened stick he always carried and hurled it whistling through the air between Larth and Lara. A heartbeat later, the spear struck the deer’s breast with such force that the creature was knocked to the ground.Unable to rise, she thrashed her neck and flailed her long, slender legs.Po ran past Larth and Lara. When he reached the deer, he pulled the spear free and stabbed the creature again. The deer released a stifled noise, like a gasp, and stopped moving. There was a cheer from the group.Instead of yet another dinner of fish from the river, tonight there would be venison.";
            originalStr += "  The distance from the riverbank to the island was not great, but at this time of year—early summer—the river was too high to wade across. Lara’s people had long ago made simple rafts of branches lashed together with leather thongs, which they left on the riverbanks, repairing and replacing them as needed.When they last passed this way, there had been three rafts, all in good condition, left on the east bank. Two of the rafts were still there, but one was missing.";
            
            string callerCode = "CAL01";
            DateTime truncatedDateTime = DateTime.Now;
            string frequency = "FRE0091";
            string secrateKey = "secretKey";

            string timestamp = truncatedDateTime.ToString("yyyyMMddHH");
            timestamp = objEncDec2.encryptSimple(timestamp);
            string key = objEncDec2.encryptSimple(callerCode + timestamp + frequency + secrateKey);

            Console.WriteLine("Starting encryption process.");
            string encryptedText = objEncDec2.EncryptStringBasic(originalStr, key);

            Console.WriteLine("Starting decryption process.");

            string deccryptedText = objEncDec2.DecryptStringBasic(encryptedText, key);

            //var blockByte = objEncDec2.EncryptMaster_v2(callerCode, truncatedDateTime, frequency, secrateKey, originalStr);

            //Console.WriteLine("Time to encrypte: " + DateTime.Now.ToString("HH mm ss"));
            //Console.WriteLine("Starting decryption process.");
            //var decString = objEncDec2.DecryptMaster_v2(blockByte.Item1, blockByte.Item2);
            //Console.WriteLine("Time to decrypte: " + DateTime.Now.ToString("HH mm ss"));



            //string filePath = @"C:\Users\rezay\Music\DGCOM Recordings\Sample-1.txt";

            //objEncDec2.FileEncrypt(filePath, callerCode, truncatedDateTime, frequency, secrateKey);


            //string filePath2 = @"C:\Users\rezay\Music\DGCOM Recordings\Sample-1_FR#.txt_#RF_SE#136#AT_.m-o-war";

            //objEncDec2.FileDeccrypt(filePath2);

            objEncDec2.Dispose();

            Console.Read();
        }
    }
}
