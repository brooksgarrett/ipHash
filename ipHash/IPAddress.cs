using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ipHash
{
    /// <summary>
    /// This is a helper class for hashing and reverse hasing IP Addresses.
    /// </summary>
    class IPAddress
    {
        /// <summary>
        /// String representation of the hash.
        /// </summary>
        private string ipHashST = String.Empty;
        /// <summary>
        /// Numeric representation of the hash.
        /// </summary>
        private uint ipHash = 0;

        public string IPHash
        {
            get { return ipHashST; }
            set { ipHashST = value; }
        }
        private string ip = String.Empty;

        public string IP
        {
            get { return ip; }
            set { ip = value; }
        }
        private string subnetMask = String.Empty;
        
        // Single point of management
        const string invalidIPMessage = @"The IP Address entered is not valid. A valid IP contains 4 Octets between 0 and 255 each seperated by a '.'";
        const string invalidHashMessage = @"The Hash Address entered is not valid. A valid Hash is an integer between 0 and 4294967295";
        const string ipRegexString = @"\b(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b";


        public IPAddress()
        {
            // Null constructor;
        }

        public uint hash()
        {
            if (!validateIP())
            {
                throw new Exception(invalidIPMessage);
            }
            
            uint a, b, c, d = 0;            

            string[] temp = ip.Split('.');

            a = uint.Parse(temp[0]);
            b = uint.Parse(temp[1]);
            c = uint.Parse(temp[2]);
            d = uint.Parse(temp[3]);

            return (((a * 256 + b) * 256 + c) * 256 + d);
        }
        public string reverseHash()
        {
            if (!validateHash())
            {
                throw new Exception(invalidHashMessage);
            }
            
            uint a, b, c, d = 0;
            
            d = ipHash % 256;
            c = ((ipHash - d) / 256) % 256;
            b = ((((ipHash - d) / 256) - c) / 256) % 256;
            a = (((((ipHash - d) / 256) - c) / 256) - b) / 256;
            return a + "." + b + "." + c + "." + d;
        }

        private bool validateIP()
        {
            Regex validIP = new Regex(ipRegexString);
            return validIP.IsMatch(ip, 0);
        }
        private bool validateHash()
        {
            if (uint.TryParse(ipHashST, out ipHash) && ipHash < 4294967295) return true;
            else return false;
        }

        
    }
}
