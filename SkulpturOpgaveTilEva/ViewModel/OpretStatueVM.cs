using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using SkulpturOpgaveTilEva.Annotations;
using SkulpturOpgaveTilEva.Model;
using SkulpturOpgaveTilEva.NewFolder1;
using SkulpturOpgaveTilEva.Tools;
using SkulpturOpgaveTilEva.View;

namespace SkulpturOpgaveTilEva.ViewModel
{
    public class OpretStatueVM : INotifyPropertyChanged
    {
        public OpretStatueVM()

        {
            GemStatue = new RelayCommand(GemStatueMetode);

        }

        public void GemStatueMetode()
        {
            Skulptur mInSkulptur = new Skulptur(Navn, Placering, MaterialeOgType, Info, Note, SkulpturID);
            Holder.SelectedSkulptur = mInSkulptur;
            Navigate.To(typeof (RedigerStatue));
        }

        public string Navn { get; set; }
        public string Placering { get; set; }
        public string MaterialeOgType { get; set; }
        public string Info { get; set; }
        public string Note { get; set; }
        public string SkulpturID { get; set; }

        public Skulptur NySkulptur { get; set; }



        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private RelayCommand _GemStatue;

        public RelayCommand GemStatue
        {
            get { return _GemStatue; }
            set { _GemStatue = value; }
        }


        public void CheckNavn(string Navn)
        {
            if (string.IsNullOrWhiteSpace(Navn))
            {
                throw new ArgumentException("Navn er enten null eller tom, Her skal være udfyldt navn");
            }
            if (Navn.Length < 3)
            {
                throw new ArgumentException("Navn er for kort, det skal være på minimum 3 cifre");
            }
            if (Navn.Length > 50)
            {
                throw new ArgumentException("Navn er for langt, det skal være på under 50 cifre");

            }

           
    }
    }
}
