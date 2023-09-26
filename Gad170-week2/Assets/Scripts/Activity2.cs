using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Activity2 : MonoBehaviour
{
    public float randomNumber;
    // Start is called before the first frame update
    void Start()
    {
        randomNumber = Random.Range(1, 10);

        if (randomNumber == 1)
        {
            Debug.Log("The number is 1!");
        }
        else if (randomNumber > 7 || randomNumber < 5)
        {
            Debug.Log("The number is greater than 7 or less than 5");
        }
        else if (randomNumber > 1 && randomNumber < 5)
        {
            Debug.Log("The number is between 1 and 5");
        }
        else if (randomNumber == 6 || randomNumber == 7)
        {
            Debug.Log("The number was 6 or 7");
        }
        else
        {
            Debug.Log("The number is greater than 3");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
