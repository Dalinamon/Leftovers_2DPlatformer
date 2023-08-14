using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leftovers_2DPlatformer
{
    public class EnemyDamageSensor : MonoBehaviour
    {
        private IHealth health;

        // Start is called before the first frame update
        void Start()
        {
            health = GetComponentInParent<IHealth>();
        }

        // Update is called once per frame
        void Update()
        {
          
        }

        void OnTriggerEnter2D(Collider2D col)
        {
            health.DecreaseHealth(10);
        }

    }
}
