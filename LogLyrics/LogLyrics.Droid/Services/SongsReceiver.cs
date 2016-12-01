using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Util;
using Android.Provider;
using LogLyrics;
using LogLyrics.Entities;

namespace LogLyrics.Droid
{
    [BroadcastReceiver(Enabled = true)]
    [IntentFilter(new[] {
        "com.android.music.metachanged",
        "com.tbig.playerpro.metachanged"
    })]
    public class SongsReceiver : BroadcastReceiver
    {


    
        public override void OnReceive(Context context, Intent intent)
        {

            var action = intent.Action;
            var cmd = intent.GetStringExtra("command");
            Log.Verbose("mIntentReceiver.onReceive ", action + " / " + cmd);
            var lyric = intent.GetStringExtra("lyric");
            var artist1 = intent.GetStringExtra(MediaStore.Audio.AudioColumns.Artist);
            var album1 = intent.GetStringExtra(MediaStore.Audio.AlbumColumns.Album);
            var track1 = intent.GetStringExtra(MediaStore.Audio.AudioColumns.Track);
            var duration1 = intent.GetLongExtra(MediaStore.Audio.AudioColumns.Duration, 0);

            var duracion = "";

            var time = duration1;
            var seconds = time / 1000;
            var minutes = seconds / 60;
            seconds = seconds % 60;

            if (seconds < 10)
            {
                var csongs_duration = minutes.ToString() + ":0" + seconds.ToString();
                duracion = csongs_duration;
            }
            else
            {
                var csongs_duration = minutes.ToString() + ":" + seconds.ToString();
                duracion = csongs_duration;
            }


            Global.Nombre = track1;
           
        }
    }
}