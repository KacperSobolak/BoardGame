using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAllPole : MonoBehaviour {

    public int spawnnb;
    // 0 - blue, 1 - green, 2 - yellow, 3 - red
    public Material[] materials;
    public Material playermat;
    public Transform escape;

    void Start () {
        SetColor();
    }
	
	void Update () {
		
	}

    void SetColor()
    {
        playermat = materials[spawnnb];
    }
}
