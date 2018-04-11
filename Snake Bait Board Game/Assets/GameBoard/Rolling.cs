using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rolling : MonoBehaviour {

	// Use this for initialization
	void Start () {
        DiceValues = new int[2];
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public int[] DiceValues;
	public Sprite[] DiceOne;
	public Sprite[] DiceTwo;

    public void RollTheDice()
    {
        //you roll two dice
        for (int i = 0; i < DiceValues.Length; i++)
        {
            DiceValues[i] = Random.Range(1, 7);
        }

        Debug.Log("Rolled a " + DiceValues[0] + " and a " + DiceValues[1]);



    }
}