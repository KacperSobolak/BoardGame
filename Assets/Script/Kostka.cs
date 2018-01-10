using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kostka : MonoBehaviour {

    public Text numbereyes_text;
    public int numbereyes_int;

	void Start () {
		
	}
	
	void Update () {
		
	}

    public void Rzuc_BTN()
    {
        numbereyes_int = Random.RandomRange(1, 7);
        numbereyes_text.text = numbereyes_int.ToString();
    }
}
