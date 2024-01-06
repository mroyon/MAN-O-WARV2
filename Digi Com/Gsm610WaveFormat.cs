using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digi_Com
{
    public class Gsm610WaveFormat : WaveFormat
    {
        private short samplesPerBlock;

        public Gsm610WaveFormat()
        {
            this.waveFormatTag = WaveFormatEncoding.Gsm610;
            this.channels = 1;
            this.averageBytesPerSecond = 1625; // 13kbps
            this.bitsPerSample = 0; // must be zero
            this.blockAlign = 65;
            this.sampleRate = 8000;

            this.extraSize = 2;
            this.samplesPerBlock = 320;
        }

        public short SamplesPerBlock { get { return this.samplesPerBlock; } }
    }
}
