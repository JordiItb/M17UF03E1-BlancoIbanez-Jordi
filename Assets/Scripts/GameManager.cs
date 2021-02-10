using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public Text time;
    private float internalTime;

    
    void Start()
    {
        
    }

    
    void Update()
    {
        
        internalTime += Time.deltaTime;

        time.text = "" + ((int)internalTime).ToString();

    }
}
