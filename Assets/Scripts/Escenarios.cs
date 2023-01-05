using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escenarios : MonoBehaviour
{

    public GameObject desierto;

    public GameObject campo;

    public GameObject playa;

    public GameObject nieve;

    public GameObject estrado;

    public GameObject colina;

    public GameObject luz;

    public GameObject avioneta;

    public GameObject martillo;

    public GameObject castillo;

    public GameObject habitacion;


    // Start is called before the first frame update
    void Start()
    {
        desierto.SetActive(true);
        campo.SetActive(false);
        playa.SetActive(false);
        nieve.SetActive(false);
        estrado.SetActive(false);
        colina.SetActive(false);
        luz.SetActive(true);
        avioneta.SetActive(false);
        martillo.SetActive(false);
        castillo.SetActive(false);
        habitacion.SetActive(false);
        StartCoroutine(Findesierto());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Findesierto()
    {
        yield return new WaitForSeconds(48);
        desierto.SetActive(false);
        campo.SetActive(true);
        playa.SetActive(false);
        nieve.SetActive(false);
        estrado.SetActive(false);
        colina.SetActive(false);
        luz.SetActive(true);
        avioneta.SetActive(false);
        martillo.SetActive(false);
        StartCoroutine(Campo()); //llamo el método
    }

    IEnumerator Campo()
    {
        yield return new WaitForSeconds(31);
        desierto.SetActive(false);
        campo.SetActive(false);
        playa.SetActive(true);
        nieve.SetActive(false);
        estrado.SetActive(false);
        colina.SetActive(false);
        luz.SetActive(true);
        avioneta.SetActive(true);
        martillo.SetActive(false);
        StartCoroutine(Fincampo());

    }

    IEnumerator Fincampo()
    {
        yield return new WaitForSeconds(32);
        desierto.SetActive(false);
        campo.SetActive(false);
        playa.SetActive(false);
        nieve.SetActive(true);
        estrado.SetActive(false);
        colina.SetActive(false);
        luz.SetActive(false);
        avioneta.SetActive(true);
        martillo.SetActive(false);
        StartCoroutine(Dianublado());
    }

    IEnumerator Dianublado()
    {
        yield return new WaitForSeconds(31);
        desierto.SetActive(false);
        campo.SetActive(false);
        playa.SetActive(false);
        nieve.SetActive(false);
        estrado.SetActive(true);
        colina.SetActive(false);
        luz.SetActive(false);
        avioneta.SetActive(false);
        martillo.SetActive(true);
        StartCoroutine(Findianublado());
    }

    IEnumerator Findianublado()
    {
        yield return new WaitForSeconds(68);
        desierto.SetActive(false);
        campo.SetActive(false);
        playa.SetActive(false);
        nieve.SetActive(false);
        estrado.SetActive(false);
        colina.SetActive(true);
        luz.SetActive(false);
        avioneta.SetActive(false);
        martillo.SetActive(false);

    }

}

