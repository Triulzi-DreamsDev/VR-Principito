using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MartilloAudio : MonoBehaviour
{
    [SerializeField]
    Animator martilloAnimator;

    // Start is called before the first frame update
    void Start()
    {
        martilloAnimator.SetBool("martillo", false);
        StartCoroutine(Golpe());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Golpe()
    {
        yield return new WaitForSeconds(143);
        martilloAnimator.SetBool("martillo", true);
    }
}
