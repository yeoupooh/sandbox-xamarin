using System.Collections.Generic;
using System.Diagnostics;
using Android.Speech.Tts;
using TextToSpeech.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(TextToSpeechImplementation))]
namespace TextToSpeech.Droid
{
    public class TextToSpeechImplementation : Java.Lang.Object, ITextToSpeech, Android.Speech.Tts.TextToSpeech.IOnInitListener
    {
        Android.Speech.Tts.TextToSpeech speaker;
        string toSpeak;

        public void Speak(string text)
        {
            var ctx = Forms.Context; // useful for many Android SDK features
            toSpeak = text;
            if (speaker == null)
            {
                speaker = new Android.Speech.Tts.TextToSpeech(ctx, this);
            }
            else
            {
                var p = new Dictionary<string, string>();
                speaker.Speak(toSpeak, QueueMode.Flush, p);
                Debug.WriteLine("tts android: speak=" + toSpeak);
            }
        }

        #region IOnInitListener implementation
        public void OnInit(OperationResult status)
        {
            if (status.Equals(OperationResult.Success))
            {
                var p = new Dictionary<string, string>();
                speaker.Speak(toSpeak, QueueMode.Flush, p);
                Debug.WriteLine("tts android: init success");
            }
            else
            {
                Debug.WriteLine("tts android: init failed");
            }
        }
        #endregion
    }
}
