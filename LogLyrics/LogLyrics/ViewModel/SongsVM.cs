using LogLyrics.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LogLyrics

{
    public class SongsVM:ObservableBaseObject
    {

        public ObservableCollection<Songs> Canciones { get; set; }

        bool isBusy = true;

        public bool IsBusy
        {
            get { return isBusy; }
            set { isBusy = value; OnPropertyChanged(); }
        }

        public Command LoadSongsCommand
        {
            get; set;
        }

        public SongsVM()
        {
            Canciones = new ObservableCollection<Songs>();
            IsBusy = false;
            LoadSongsCommand = new Command((obj) => LoadSong());
        }


        public async void LoadSong()
        {

            if (!IsBusy)
            {

                IsBusy = true;
                //await Task.Delay(3000);

                //var LoadedDirectory = StudentDirectoryService.LoadStudentDirectory();
                //foreach (var student in LoadedDirectory.Students)
                //{
                //    Students.Add(student);
                //}

                Canciones.Add(new Songs { Nombre= Global.Nombre });

                IsBusy = false;
            }
        }



    }
}
