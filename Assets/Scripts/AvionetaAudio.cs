using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvionetaAudio : MonoBehaviour
{
    [SerializeField]
    Animator avionetaAnimator;

    // Start is called before the first frame update
    void Start()
    {
        avionetaAnimator.SetBool("vuelo", false);
        StartCoroutine(Volar());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Volar()
    {
        yield return new WaitForSeconds(88);
        avionetaAnimator.SetBool("vuelo", true);
    }

}
