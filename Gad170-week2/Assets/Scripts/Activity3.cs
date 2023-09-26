using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activity3 : MonoBehaviour
{
    public int strength;
    public int dexterity;
    public int intelligence;
    public int statPool;
    // Start is called before the first frame update
    void Start()
    {
        statPool = 20;

        strength = Random.Range(0,statPool);
        statPool = statPool - strength;

        dexterity = Random.Range(0,statPool);
        statPool = statPool - dexterity;

        intelligence = Random.Range(0,statPool);
        statPool = statPool - intelligence;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Strength is " + strength);
            Debug.Log("Dexterity is " + dexterity);
            Debug.Log("Intelligence is " + intelligence);
        }
    }
}
