using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hud : MonoBehaviour {

    public Bola Bola;
    public GameObject Barra_Vida;
    private Animator Anim;
    public const string Estado_Vidas = "Vidas";

	// Use this for initialization
	void Start ()
    {
        Anim = Barra_Vida.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        Anim.SetInteger(Estado_Vidas, Bola.Vidas1);
	}
}
