using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activity1 : MonoBehaviour
{
    public string favGame = "Divinity: Original Sin 2";
    public int hoursPlayed = 394;
    public float howMuch = 69.45f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("My favourite game is " + favGame 
            + " and I have " + hoursPlayed + " hours played. " +
            "It cost me $" +  howMuch + "." +
            " My dollars per hour is " + howMuch / hoursPlayed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
