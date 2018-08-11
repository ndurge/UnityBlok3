using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour {

    public AudioSource fountain;
    public GameObject whales;
    public GameObject wintext;

    // Use this for initialization
    void Start () {
        var emission = GetComponent<ParticleSystem>().emission;
        emission.enabled = false;

        fountain = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        if (FindObjectsOfType<EnemyHealth>().Length == 0 && !fountain.isPlaying)
        {
            var emission = GetComponent<ParticleSystem>().emission;
            emission.enabled = true;

            fountain.Play();

            whales.SetActive(true);
            wintext.SetActive(true);
        }

    }
}
