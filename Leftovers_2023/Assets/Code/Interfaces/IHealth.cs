using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leftovers_2DPlatformer
{
    public interface IHealth
    {
        public int CurrentHealth { get; }

        public int MaxHealth { get; }

        void IncreaseHealth(int amount);

        void DecreaseHealth(int amount);

        void Reset();
    }
}
