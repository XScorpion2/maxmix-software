﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMix.Services.Communication
{
    internal class MessageSettings : IMessage
    {
        #region Constructor
        public MessageSettings(bool displayNewSession, bool sleepWhenInactive, int sleepAfterSeconds)
        {
            _displayNewSession = displayNewSession;
            _sleepWhenInactive = sleepWhenInactive;
            _sleepAfterSeconds = sleepAfterSeconds;
        }
        #endregion

        #region Consts
        #endregion

        #region Fields
        public bool _displayNewSession;
        public bool _sleepWhenInactive;
        public int _sleepAfterSeconds;
        #endregion

        #region Properties
        public bool DisplayNewSession { get => _displayNewSession; }
        public bool SleepWhenInactive { get => _sleepWhenInactive; }
        public int SleepAfterSeconds { get => _sleepAfterSeconds; }
        #endregion

        #region Private Methods
        #endregion

        #region Public Methods

        /*
        * ---------------------------------------------------
        * CHUNK                     TYPE        SIZE (BYTES)
        * ---------------------------------------------------
        * DISPLAYNEWSESSION         BYTE        1
        * SLEEPWHENINACTIVE         BYTE        1
        * SLEEPAFTERSECONDS         BYTE        1
        * CHECKFORUPDATES           BYTE        1
        * ---------------------------------------------------
        */

        public byte[] GetBytes()
        {
            var result = new List<byte>();           

            result.Add(Convert.ToByte(DisplayNewSession));
            result.Add(Convert.ToByte(SleepWhenInactive));
            result.Add(Convert.ToByte(SleepAfterSeconds));

            return result.ToArray();
        }

        public bool SetBytes(byte[] bytes)
        {
            throw new NotImplementedException("Should never be called");
        }
        #endregion
    }
}