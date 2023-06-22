using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Leftovers_2DPlatformer
{
    public class HealthBar : MonoBehaviour
    {
        public Slider slider;

        private void Start()
        {
            
        }

        public void SetMaxHealth(int health)
        {
            slider.maxValue = health;
            slider.value = health;
        }

        public void SetHealth(int health)
        {
            slider.value = health;
        }
    }
}
