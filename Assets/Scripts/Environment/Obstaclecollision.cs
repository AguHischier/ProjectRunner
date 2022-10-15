using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaclecollision : MonoBehaviour
{
    public GameObject thePlayer;
    // public GameObject charModel; ESTO ES PARA PONER EL ANIMADOR DEL PJ
    public GameObject mainCam;
    public GameObject levelControl;

    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        thePlayer.GetComponent<PlayerMove>().enabled = false;
        //charModel.GetComponent<Animator>().Play(""); ACA VA LA ANIMACION DE MORIR
        levelControl.GetComponent<LevelDistance>().enabled = false;
        mainCam.GetComponent<Animator>().enabled = true;
        levelControl.GetComponent<EndRunSequence>().enabled = true;
    }
}
