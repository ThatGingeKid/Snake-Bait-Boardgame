using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        DiceValues[0] = Random.Range(0, 6);
		DiceValues[1] = Random.Range(0, 6);
		this.transform.GetChild(0).GetComponent<Image>().sprite = DiceOne[DiceValues[0]];
		this.transform.GetChild(1).GetComponent<Image>().sprite = DiceOne[DiceValues[1]];
        Debug.Log("Rolled a " + DiceValues[0] + " and a " + DiceValues[1]);


    }
}