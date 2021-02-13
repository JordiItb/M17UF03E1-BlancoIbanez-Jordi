using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    private GameManager gm;
    
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    
    void Update()
    {

    }

    void OnTriggerEnter(Collider collider){

        Debug.Log(collider.gameObject.tag);

        if(collider.gameObject.tag == "Coin"){

            GameObject coin = collider.gameObject;

            gm.increaseCoinCount(coin);

        }

    }
}
