﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloxcrosoft
{
    public class InterProcessLock : IDisposable
    {
        public Mutex Mutex { get; private set; }

        public bool IsAcquired { get; private set; }

        public InterProcessLock(string name, TimeSpan timeout)
        {
            Mutex = new Mutex(false, "Bloxcrosoft-" + name);
            IsAcquired = Mutex.WaitOne(timeout);
        }

        public void Dispose()
        {
            if (IsAcquired)
            {
                Mutex.ReleaseMutex();
                IsAcquired = false;
            }
        }
    }
}
