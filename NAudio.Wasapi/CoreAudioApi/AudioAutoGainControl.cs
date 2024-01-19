using NAudio.CoreAudioApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NAudio.Wasapi.CoreAudioApi
{
    public class AudioAutoGainControl
    {
        private IAudioAutoGainControl audioAutoGainControlInterface;

        internal AudioAutoGainControl(IAudioAutoGainControl audioAutoGainControl)
        {
            audioAutoGainControlInterface = audioAutoGainControl;
        }

        public bool AGCEnabled
        {
            get
            {
                audioAutoGainControlInterface.GetEnabled(out var result);
                return result;
            }
            set
            {
                audioAutoGainControlInterface.SetEnabled(value);
            }
        }
    }
}