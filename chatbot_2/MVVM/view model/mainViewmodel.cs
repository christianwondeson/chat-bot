using chatbot_2.MVVM.model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chatbot_2.MVVM.view_model
{
    class mainViewmodel
    {
        public ObservableCollection<messagemodel> Message { get; set; }

        public ObservableCollection<contactmodel> Contact{ get; set; }

        public mainViewmodel()
        {
            //instanciate our objects
            Message = new ObservableCollection<messagemodel>();
            Contact = new ObservableCollection<contactmodel>(); 

            Message.Add(new messagemodel
            {

                Username = "chris",
                Username_color = "#409AFF",
                Imagesource = "Darksiders II (29263) 7_28_2021 10_02_53 AM.png",
                Messages = "Test",
                Time = DateTime.Now,
                IsnativeOrigin = false,
                Firstmessage = true
            });

            for (int i = 0; i < 3; i++)
            {
                Message.Add(new messagemodel
                {

                    Username = "Chris",
                    Username_color = "#409AFF",
                    Imagesource = "Darksiders II(29263) 7_28_2021 10_02_53 AM.png",
                    Messages = "Test",
                    Time = DateTime.Now,
                    IsnativeOrigin = false,
                    Firstmessage = false
                });
            }
            for (int i = 0; i < 4; i++)
            {
                Message.Add(new messagemodel
                {

                    Username = "Geni",
                    Username_color = "#409AFF",
                    Imagesource = "Darksiders II (29263) 7_28_2021 10_02_53 AM.png",
                    Messages = "Test",
                    Time = DateTime.Now,
                    IsnativeOrigin = true,
                });
            }


            Message.Add(new messagemodel
            {

                Username = "Geni",
                Username_color = "#409aff",
                Imagesource = "Darksiders II (29263) 7_28_2021 10_02_53 AM.png",
                Messages= "Last",
                Time = DateTime.Now,
                IsnativeOrigin = true,
            });

            for (int i = 0; i < 5; i++) 
            {
                Contact.Add(new contactmodel { 
                
                username=$"Chris{i}",
                Imagesource= "Darksiders II (29263) 7_28_2021 10_02_53 AM.png",
                Message=Message
                });
            }
        }
    }
}