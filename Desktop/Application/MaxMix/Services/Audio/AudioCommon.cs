﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMix.Services.Audio
{
    public delegate void AudioSessionDelegate(object sender, int pid, string displayName, int volume, bool isMuted);
    public delegate void AudioSessionVolumeDelegate(object sender, int pid, int volume, bool isMuted);
    public delegate void AudioSessionNameDelegate(object sender, int pid, string displayName);
}
