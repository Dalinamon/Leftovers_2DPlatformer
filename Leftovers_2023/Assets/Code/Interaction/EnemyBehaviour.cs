using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leftovers_2DPlatformer
{
    public class EnemyBehaviour : MonoBehaviour
    {
        private IHealth health;

        // Start is called before the first frame update
        void Start()
        {
            health = GetComponent<IHealth>();
        }

        // Update is called once per frame
        void Update()
        {
            if(health.CurrentHealth == 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
