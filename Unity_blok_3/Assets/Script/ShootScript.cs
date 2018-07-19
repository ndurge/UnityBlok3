using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Default
{

    public class ShootScript : MonoBehaviour
    {
        public Bullet prefab;
        public Camera cam;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonUp(0))
            {
                Shoot();
            }
        }

        void Shoot()
        {
            Bullet bullet = Instantiate<Bullet>(prefab, cam.transform.position, Quaternion.identity);

            bullet.direction = cam.transform.forward;
        }
    }
}