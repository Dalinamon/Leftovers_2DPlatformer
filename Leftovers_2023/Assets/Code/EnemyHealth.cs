using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leftovers_2DPlatformer
{
    public class EnemyHealth : MonoBehaviour
    {
        [SerializeField]
        private int maxHealth;

        [SerializeField]
        private int startHealth;

        private int currentHealth = 0;
        private bool isDead = false;

        public HealthBar healthBar;
        public float fallForce = 5f;

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
            if (isDead) return;

            CurrentHealth -= amount;
            healthBar.SetHealth(CurrentHealth);

            if (CurrentHealth <= 0)
            {
                Die();
            }
        }

        public void IncreaseHealth(int amount)
        {
            if (isDead) return;

            CurrentHealth += amount;
            healthBar.SetHealth(CurrentHealth);
        }

        public void Reset()
        {
            CurrentHealth = startHealth;
            isDead = false;
            healthBar.SetMaxHealth(MaxHealth);
        }

        private void Die()
        {
            isDead = true;

            // Disable the EnemyFollow script
            EnemyFollow enemyFollow = GetComponent<EnemyFollow>();
            if (enemyFollow != null)
            {
                enemyFollow.enabled = false;
            }

            // Apply force to make the enemy fall towards the player
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                GameObject player = GameObject.FindGameObjectWithTag("Player");
                if (player != null)
                {
                    Vector2 forceDirection = transform.position - player.transform.position;
                    forceDirection.Normalize();
                    rb.AddForce(forceDirection * fallForce, ForceMode2D.Impulse);
                }
                else
                {
                    Debug.LogWarning("Player object not found!");
                }
            }

            // Additional actions to perform when the enemy is defeated
            // For example, play death animation, disable colliders, etc.
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
