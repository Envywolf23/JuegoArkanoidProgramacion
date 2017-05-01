using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloques : MonoBehaviour {

    public int GolpesParaMatar;
    public int Puntos;
    private int NumerodeGolpes;
    public AudioClip Colision;
    AudioSource audioBloques;
    public GUIText PuntitosTexto;
    public int Score;
    private int puntos = 0;
    private const string score1 = "Score1";

    public static string Score1
    {
        get
        {
            return score1;
        }
    }


    // Use this for initialization
    void Start () {
        audioBloques = GetComponent<AudioSource>();
        NumerodeGolpes = 0;
        PuntitosTexto.text = "Score:" + Puntos.ToString();
    
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
        PuntitosTexto.text = "Score:" + Puntos.ToString();
    }


	// Update is called once per frame
	void Update ()
    {
		
	}
    void OnTriggerEnter2D(Collider2D Collider)
    {
        if (Collider.tag.Equals(Score1))
        {
            Collider.gameObject.SetActive(false);
            Puntos++;
        }
    }
}
