using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrinceAudio : MonoBehaviour
{
    [SerializeField]
    Animator animatorPrince;


    // Start is called before the first frame update
    void Start()
    {
        animatorPrince.SetBool("dialogo1", true);
        StartCoroutine(FinDialogoUno()); //llamo el método
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator FinDialogoUno()
    {
        yield return new WaitForSeconds(22);
        animatorPrince.SetBool("dialogo1", false);
        animatorPrince.SetBool("idle", true);
        StartCoroutine(DialogoDos()); //llamo el método
    }

    IEnumerator DialogoDos()
    {
        yield return new WaitForSeconds(13);
        animatorPrince.SetBool("idle", false);
        animatorPrince.SetBool("dialogo2", true);
        StartCoroutine(FinDialogoDos());
    }

    IEnumerator FinDialogoDos()
    {
        yield return new WaitForSeconds(28);
        animatorPrince.SetBool("idle", true);
        animatorPrince.SetBool("dialogo2", false);// 1:25 Animacion avioneta
        StartCoroutine(DialogoTres());
    }

    IEnumerator DialogoTres()
    {
        yield return new WaitForSeconds(29);
        animatorPrince.SetBool("idle", false);
        animatorPrince.SetBool("dialogo3", true);
        StartCoroutine(FinDialogoTres());
    }

    IEnumerator FinDialogoTres()
    {
        yield return new WaitForSeconds(13);
        animatorPrince.SetBool("idle", true);
        animatorPrince.SetBool("dialogo3", false);
        StartCoroutine(DialogoCuatro());
    }

    IEnumerator DialogoCuatro()
    {
        yield return new WaitForSeconds(7);
        animatorPrince.SetBool("idle", false);
        animatorPrince.SetBool("dialogo4", true);
        StartCoroutine(FinDialogoCuatro());
    }

    IEnumerator FinDialogoCuatro()
    {
        yield return new WaitForSeconds(30);
        animatorPrince.SetBool("idle", true);
        animatorPrince.SetBool("dialogo4", false);
        StartCoroutine(DialogoCinco());
    }

    IEnumerator DialogoCinco()
    {
        yield return new WaitForSeconds(54);
        animatorPrince.SetBool("idle", false);
        animatorPrince.SetBool("dialogo5", true);// 2:24 animacion martillo
        StartCoroutine(FinDialogoCinco());
    }

    IEnumerator FinDialogoCinco()
    {
        yield return new WaitForSeconds(6);
        animatorPrince.SetBool("idle", true);
        animatorPrince.SetBool("dialogo5", false);
        
    }
}
