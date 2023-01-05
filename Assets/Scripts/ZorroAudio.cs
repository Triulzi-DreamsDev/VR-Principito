using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZorroAudio : MonoBehaviour
{
    [SerializeField]
    Animator animatorZorro;

    // Start is called before the first frame update
    void Start()
    {
        animatorZorro.SetBool("Idle", true);
        StartCoroutine(animacion1());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator animacion1()
    {
        yield return new WaitForSeconds(5); //poner tiempo
        animatorZorro.SetBool("Idle", false);
        animatorZorro.SetBool("animacion1", true);
        StartCoroutine(Idle()); //llamo el método
    }

    IEnumerator Idle()
    {
        yield return new WaitForSeconds(16); //poner tiempo
        animatorZorro.SetBool("animacion1", false);
        animatorZorro.SetBool("Idle", true);
    }

}
