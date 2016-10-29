﻿using UnityEngine;
using System.Collections;

public class Key : MonoBehaviour 
{

    public int color;
    private Vector3 myposition;

    /*
     * 1 = AMARELO
     * 2 = VERMELHO
     * 3 = AZUL ESCURO
     * 4 = VERDE
     * 5 = ROXO
     * 6 = ROSA
     * 7 = LARANJA
     * 8 = AZUL CLARO
     */

    public void Start()
    {
        myposition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    public void Updade()
    {
        myposition.x = transform.position.x;
        myposition.y = transform.position.y;
        myposition.z = transform.position.z;
    }
}