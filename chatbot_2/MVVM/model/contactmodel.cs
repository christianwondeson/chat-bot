using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chatbot_2.MVVM.model
{
    class contactmodel
    {
        public string username { get; set; }  //adding property prop +tab +tab
        public string Imagesource { get; set; }
        public ObservableCollection<messagemodel> Message { get; set; }
        public string Lastmessage => Message.Last().Messages;
    }
}
