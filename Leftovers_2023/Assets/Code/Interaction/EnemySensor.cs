using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leftovers_2DPlatformer
{
    public class EnemySensor : MonoBehaviour
    {
        private Health health;

        // Start is called before the first frame update
        void Start()
        {
            health = GetComponentInParent<Health>();
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
