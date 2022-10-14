using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaclecollision : MonoBehaviour
{
    public GameObject thePlayer;
   // public GameObject charModel; ESTO ES PARA PONER EL ANIMADOR DEL PJ

    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        thePlayer.GetComponent<PlayerMove>().enabled = false;
        //charModel.GetComponent<Animator>().Play(""); ACA VA LA ANIMACION DE MORIR
    }
}
