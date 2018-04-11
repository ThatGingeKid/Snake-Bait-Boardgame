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
<<<<<<< HEAD:Snake Bait Board Game/Assets/Scenes/GameBoard/Rolling.cs
        DiceValues[0] = Random.Range(0, 6);
		DiceValues[1] = Random.Range(0, 6);
		this.transform.GetChild(0).GetComponent<Image>().sprite = DiceOne[DiceValues[0]];
		this.transform.GetChild(1).GetComponent<Image>().sprite = DiceOne[DiceValues[1]];
=======
        //you roll two dice
        DiceValues[0] = Random.Range(1, 7);
		DiceValues[1] = Random.Range(1, 7);

>>>>>>> 4279126e7c50171de27f1638e7a8327cef520f30:Snake Bait Board Game/Assets/GameBoard/Rolling.cs
        Debug.Log("Rolled a " + DiceValues[0] + " and a " + DiceValues[1]);


    }
}