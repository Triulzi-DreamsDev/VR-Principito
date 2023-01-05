using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionManager : MonoBehaviour
{

    public FadeScreen fadeScreen;

    public void Update()
    {

    }
    public void FadeTransition()
    {
        StartCoroutine(StartFadeOut());
    }

   IEnumerator StartFadeOut()
    {
        fadeScreen.FadeOut();
        yield return new WaitForSeconds(fadeScreen.fadeDuration);

        StartCoroutine(StartFadeIn());

    }

    IEnumerator StartFadeIn()
    {
        fadeScreen.FadeIn();

        yield return new WaitForSeconds(fadeScreen.fadeDuration);

    }
}
