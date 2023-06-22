using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leftovers_2DPlatformer
{
    public class Health : MonoBehaviour
    {
        [SerializeField]
        private int maxHealth;

        [SerializeField]
        private int startHealth;

        private int currentHealth = 0;

        public int CurrentHealth
        {
            get { return currentHealth; }
            private set
            {
                currentHealth = Mathf.Clamp(value, 0, MaxHealth);
            }
        }

        public int MaxHealth => maxHealth;

        public void DecreaseHealth(int amount)
        {
            CurrentHealth -= amount;
        }

        public void IncreaseHealth(int amount)
        {
            CurrentHealth += amount;
        }

        public void Reset()
        {
            CurrentHealth = startHealth;
        }


        // Start is called before the first frame update
        void Start()
        {
            Reset();
        }

        // Update is called once per frame
        void Update()
        {
            Debug.Log(CurrentHealth);
        }
    }
}
