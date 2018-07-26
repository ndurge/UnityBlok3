using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour {

	// Use this for initialization
	void Start () {
        var emission = GetComponent<ParticleSystem>().emission;
        emission.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (FindObjectsOfType<EnemyHealth>().Length == 0)
        {
            var emission = GetComponent<ParticleSystem>().emission;
            emission.enabled = true;
        }

        print(FindObjectsOfType<EnemyHealth>().Length);
    }
}
