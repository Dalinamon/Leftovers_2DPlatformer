using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leftovers_2DPlatformer
{
    public class Bomb : MonoBehaviour
    {
        private IMove mover;

        private new SpriteRenderer renderer;

        private new Collider2D collider;

        private Rigidbody2D rb;

        private Vector2 direction;

        [SerializeField]
        private float speed;

        private float timer;


        private void Awake()
        {
            mover = GetComponent<IMove>();
            renderer = GetComponent<SpriteRenderer>();
            collider = GetComponent<Collider2D>();
            rb = GetComponent<Rigidbody2D>();
        }

        // Start is called before the first frame update
        void Start()
        {

            mover.MovementSpeed(speed);

        }

        // Update is called once per frame
        void Update()
        {

            mover.Move(direction);
        }

        public void Launch(Vector2 direction)
        {
            this.direction = direction;

            if (direction.x < 0)
            {
                renderer.flipX = true;
            }


            StartCoroutine(Cooldown());
        }
        public IEnumerator Cooldown()
        {


            yield return new WaitForSeconds(5f);

            Destroy(gameObject);

        }


    }
}
