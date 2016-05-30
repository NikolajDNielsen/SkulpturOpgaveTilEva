using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System;
using Windows.UI.Popups;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml.Controls;

namespace SkulpturOpgaveTilEva.Model
{
    public class Skulptur
    {

        public string Navn { get; set; }
        public string Placering { get; set; }
        public string MaterialeOgType { get; set; }
        public string Info { get; set; }
        public string Note { get; set; }
        public string SkulpturID { get; set; }

        public Skulptur()
        {
            Navn = "";
            Placering = "";
            MaterialeOgType = "";
            Info = "";
            Note = "";
            SkulpturID = "";
        }


        public Skulptur(string navn, string placering, string materialeOgType, string info, string note,
            string skulpturId)
        {
            Navn = navn ?? "";
            Placering = placering ?? "";
            MaterialeOgType = materialeOgType ?? "";
            Info = info ?? "";
            Note = note ?? "";
            SkulpturID = skulpturId ?? "";
        }


        public void Add()
        {
            try
            {
                Validate.IsEmpty(Navn, "Navn");
                Validate.IsEmpty(Placering, "Placering");
                Validate.IsEmpty(MaterialeOgType, "Materiale og Type");
                Validate.IsEmpty(Info, "Info");
                Validate.IsEmpty(Note, "Note");
                Validate.IsEmpty(SkulpturID, "SkulpturID");

            }
            catch (ArgumentException ex)
            {
                MessageDialog message = new MessageDialog(ex.Message);
                message.ShowAsync();
            }



        }

        public class Validate
        {
            public static void IsEmpty(string navn, string p1)
            {
                throw new NotImplementedException();
            }
        }
    }

    

    }
        
