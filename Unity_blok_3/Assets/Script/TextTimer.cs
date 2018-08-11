using UnityEngine;
using System.Collections;

public class TextTimer : MonoBehaviour
{
    float time = 5f; //Seconds to read the text

    void Start()
    {
        Invoke("Hide", time);
    }

    void Hide()
    {
        gameObject.SetActive(false);
    }

}
