using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chatbot_2.MVVM.model
{
    class messagemodel
    {
        public string  Username{ get; set; }
        public string Username_color { get; set; }
        public string Imagesource { get; set; }
        public string Messages { get; set; }
        public DateTime Time { get; set; }
        public bool IsnativeOrigin { get; set; }
        public bool? Firstmessage { get; set; }  //we make it nukk able by adding ? mark on bool
    }
}
