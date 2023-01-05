using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MobileWaterShaderEKV
{
    public class MarCTRL : MonoBehaviour
    {
        public MobileWaterShader_EKV waterScript;
        public WaterControl_EKV waterControl;

       public bool lightingToggle, texturesToggle, transparencyToggle, wavesToggle, reflectionToggle, movementToggle;

        // Start is called before the first frame update
        void Start()
        {
            waterScript.EnableWaves(true);
            waterControl.moveTextures= true;

            //lightingToggle.isOn = waterScript.IsLightingEnabled();
            //texturesToggle.isOn = waterScript.IsTexturesEnabled();
            //transparencyToggle.isOn = waterScript.IsTransparencyEnabled();
            //wavesToggle.isOn = waterScript.IsWavesEnabled();
            //reflectionToggle.isOn = waterScript.IsReflectionEnabled();
            //movementToggle.isOn = waterControl.moveTextures;

            //lightingToggle = true;
            //texturesToggle = true;
            //transparencyToggle = true;
        }

        // Update is called once per frame
        void Update()
        {
            //if (lightingToggle)
            //{
            //    waterScript.IsLightingEnabled();
            //}
            //if (texturesToggle)
            //{
            //    waterScript.IsTexturesEnabled();
            //}
            //if (transparencyToggle)
            //{
            //    waterScript.IsTransparencyEnabled();
            //}
            //if (wavesToggle)
            //{
            //    waterScript.IsWavesEnabled();
            //}
            //if (reflectionToggle)
            //{
            //    waterScript.IsReflectionEnabled();
            //}
            //if (movementToggle)
            //{
            //    waterControl.moveTextures;
            //}
        }
    }
}
