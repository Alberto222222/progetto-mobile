using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour
{
    private void OnTriggerEnter(Collider other ){

        if (other.CompareTag("Player")){

            FindObjectOfType<GameManager>().Explode();


        }
    }
}
