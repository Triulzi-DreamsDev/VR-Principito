using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RosaAudio : MonoBehaviour
{
    [SerializeField]
    Animator animatorRosa;

    // Start is called before the first frame update
    void Start()
    {
        animatorRosa.SetBool("idle",true);
        StartCoroutine(CruzarBrazos()); //llamo el método
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CruzarBrazos()
    {
        yield return new WaitForSeconds(14); //poner tiempo
        animatorRosa.SetBool("idle", false);
        animatorRosa.SetBool("enojada", true);
        StartCoroutine(Idle()); //llamo el método
    }

    IEnumerator Idle()
    {
        yield return new WaitForSeconds(19); //poner tiempo
        animatorRosa.SetBool("enojada", false);
        animatorRosa.SetBool("idle", true);
    }

}
