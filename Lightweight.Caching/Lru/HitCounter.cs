﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lightweight.Caching.Lru
{
    public struct HitCounter : IHitCounter
    {
        private long requestHitCount;
        private long requestTotalCount;

        public double HitRatio => (double)requestHitCount / (double)requestTotalCount;

        public void IncrementTotalCount()
        {
            Interlocked.Increment(ref this.requestTotalCount);
        }

        public void IncrementHitCount()
        {
            Interlocked.Increment(ref this.requestHitCount);
        }
    }
}