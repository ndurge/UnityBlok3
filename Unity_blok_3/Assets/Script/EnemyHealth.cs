using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour, IDamageable
{
    public GameObject hitParticles;
    public GameObject audioObject;


    void Start()
    {
        
    }

    public void Damage(int damage, Vector3 hitPoint)
    {
        Instantiate(audioObject, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

}