using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloques : MonoBehaviour {

    public int GolpesParaMatar;
    public int Puntos;
    private int NumerodeGolpes;
    public AudioClip Colision;
    AudioSource audioBloques;

    // Use this for initialization
    void Start () {
        audioBloques = GetComponent<AudioSource>();
        NumerodeGolpes = 0;

		
	}
	
    void OnCollisionEnter2D (Collision2D collision) {

        if (collision.gameObject.tag == "Bola")
        {
            NumerodeGolpes++;
            audioBloques.PlayOneShot(Colision, 0.9f);

            if (NumerodeGolpes == GolpesParaMatar) {
               
                //Destruye el objeto
                Destroy(this.gameObject);
            }
        }

    }


	// Update is called once per frame
	void Update () {
		
	}

}
