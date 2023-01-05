using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour
{

    public TransitionManager transitionManager;
    public FadeScreen fadeScreen;

    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(Fadeout());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Fadeout()
    {
        yield return new WaitForSeconds(46);
        transitionManager.FadeTransition();
        StartCoroutine(no());
    }

    IEnumerator no()
    {
        yield return new WaitForSeconds(1);
        //transitionManager.FadeTransition();
        StartCoroutine(playa());
    }


    IEnumerator playa()
    {
        yield return new WaitForSeconds(30);
        transitionManager.FadeTransition();
        StartCoroutine(noo());

    }

    IEnumerator noo()
    {
        yield return new WaitForSeconds(1);
        //transitionManager.FadeTransition();
        StartCoroutine(Nieve());
    }

    IEnumerator Nieve()
    {
        yield return new WaitForSeconds(31);
        transitionManager.FadeTransition();
        StartCoroutine(noon());
    }

    IEnumerator noon()
    {
        yield return new WaitForSeconds(1);
        //transitionManager.FadeTransition();
        StartCoroutine(Estrado());
    }

    IEnumerator Estrado()
    {
        yield return new WaitForSeconds(30);
        transitionManager.FadeTransition();
        StartCoroutine(noonn());
    }

    IEnumerator noonn()
    {
        yield return new WaitForSeconds(1);
        //transitionManager.FadeTransition();
        StartCoroutine(Estrellas());

    }


    IEnumerator Estrellas()
    {
        yield return new WaitForSeconds(67);
        transitionManager.FadeTransition();
        StartCoroutine(Final());
    }

    IEnumerator Final()
    {
        yield return new WaitForSeconds(117);
        StartCoroutine(StartFadeOut());
    }


    IEnumerator StartFadeOut()
    {
        fadeScreen.FadeOut();
        yield return new WaitForSeconds(fadeScreen.fadeDuration);

    }

}
