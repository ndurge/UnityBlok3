using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour, IDamageable
{

    public int startingHealth = 3;
    public GameObject hitParticles;

    private int currentHealth;

    void Start()
    {
        currentHealth = startingHealth;
    }

    public void Damage(int damage, Vector3 hitPoint)
    {
        Destroy(gameObject);
    }

    void Defeated()
    {
        gameObject.SetActive(false);
    }

}