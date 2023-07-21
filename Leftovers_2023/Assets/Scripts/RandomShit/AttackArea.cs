using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leftovers_2DPlatformer
{
    public class AttackArea : MonoBehaviour
    {


        private void OntriggerEnter2D(Collider2D collider)
        {
            Destroy(gameObject);

        }
    }
}
