using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SBLerpBlender : MonoBehaviour
{
    public Material skyboxMaterial;
    public Material skyboxMaterial2;
    public float blendValue, blendValue2;
    public bool skyChange, skyTwoChange;

    public float minimum = 0F;
    public float maximum = 1.0F;
    public float minimum2 = 0F;
    public float maximum2 = 1.0F;
    // starting value for the Lerp
    static float t = 0.0f, t2 = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        RenderSettings.skybox = skyboxMaterial;
        blendValue = 0.1f;
        blendValue2=0.1f;
        skyboxMaterial.SetFloat("_Blend", blendValue /* Your value here */);
        skyChange = false;
        skyTwoChange = false;
        Invoke("BlendSky", 80f); //hace el blend del primer material
    }

    // Update is called once per frame
    void Update()
    {
        if (skyChange)
        {
            t += 0.5f * Time.deltaTime;
            blendValue = Mathf.Lerp(minimum, maximum, t);
            skyboxMaterial.SetFloat("_Blend", (blendValue) /* Your value here */);
            Invoke("ChangeSkyMat",26f);//hace el blend del segundo material
        }

        if (skyTwoChange)
        {
            t2 += 0.5f * Time.deltaTime;
            blendValue2 = Mathf.Lerp(minimum2, maximum2, t2);
            skyboxMaterial2.SetFloat("_Blend", (blendValue2) /* Your value here */);
        }

    }

    public void BlendSky()
    {
            skyChange = true;
    }

    public void ChangeSkyMat()
    {
        skyboxMaterial2.SetFloat("_Blend", (blendValue2) /* Your value here */);
        RenderSettings.skybox = skyboxMaterial2;
        Invoke("BlendSkyTwo", 5f);
    }

    public void BlendSkyTwo()
    {
        skyChange = false;
        skyTwoChange = true;
        ChangeSkyMat();
    }

  
}
