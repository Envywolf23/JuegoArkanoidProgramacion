using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float Velocidad = 20;
    Vector2 Direccion = new Vector2(1, 0);
    public float Limites = 20;
    Vector3 playerPosition;
    [SerializeField]
    public Transform LimiteDer;
    [SerializeField]
    public Transform LimiteIzq;


    // Use this for initialization
    void Start()
    {
        // Posicion inicial barra
        playerPosition = gameObject.transform.position;

       
    }

    // Update is called once per frame
    void Update()
    {
        // Posicion inicial barra
        playerPosition = gameObject.transform.position;

        if (Input.GetAxis("Horizontal") != 0)
        {
            GetComponent<Transform>().Translate(Direccion * Velocidad);

            if (Input.GetAxis("Horizontal") > 0)
            {
                Direccion = new Vector2(1, 0);

            }
            else
            {
                Direccion = new Vector2(-1, 0);

            }

            
            //Limites

        if (playerPosition.x < LimiteIzq.position.x+2)
            {

                transform.position = new Vector3(LimiteIzq.position.x+2, playerPosition.y, playerPosition.z);

                if (Input.GetAxis("Horizontal") != 0)
                {
                    GetComponent<Transform>().Translate(Direccion * Velocidad);

                    if (Input.GetAxis("Horizontal") > 0)
                    {
                        Direccion = new Vector2(1, 0);

                    }
                    else
                    {
                        Direccion = new Vector2(0, 0);

                    }
                }

            }

            if (playerPosition.x > LimiteDer.position.x-2)
            {

                transform.position = new Vector3(LimiteDer.position.x-2, playerPosition.y, playerPosition.z);

                if (Input.GetAxis("Horizontal") != 0)
                {
                    GetComponent<Transform>().Translate(Direccion * Velocidad);

                    if (Input.GetAxis("Horizontal") > 0)
                    {
                        Direccion = new Vector2(0, 0);

                    }
                    else
                    {
                        Direccion = new Vector2(-1, 0);

                    }
                }

            }


            // Limites
            /* if (playerPosition.x < -Limites)
             {

                 transform.position = new Vector3(-Limites, playerPosition.y, playerPosition.z);

                 if (Input.GetAxis("Horizontal") != 0)
                 {
                     GetComponent<Transform>().Translate(Direccion * Velocidad);

                     if (Input.GetAxis("Horizontal") > 0)
                     {
                         Direccion = new Vector2(1, 0);

                     }
                     else
                     {
                         Direccion = new Vector2(0, 0);

                     }
                 }
             }
             if (playerPosition.x > Limites)
                 {
                     transform.position = new Vector3(Limites, playerPosition.y, playerPosition.z);

                     if (Input.GetAxis("Horizontal") != 0)
                     {
                         GetComponent<Transform>().Translate(Direccion * Velocidad);

                         if (Input.GetAxis("Horizontal") > 0)
                         {
                             Direccion = new Vector2(0, 0);

                         }
                         else
                         {
                             Direccion = new Vector2(-1, 0);

                         }

                     }

                 }*/
        }
        }
    }
