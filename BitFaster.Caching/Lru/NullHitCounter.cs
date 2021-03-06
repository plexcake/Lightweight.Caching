﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BitFaster.Caching.Lru
{
    public struct NullHitCounter : IHitCounter
    {
        public double HitRatio => 0.0;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void IncrementMiss()
        {
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void IncrementHit()
        {
        }
    }
}
