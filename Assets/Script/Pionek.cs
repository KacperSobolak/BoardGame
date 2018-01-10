using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pionek : MonoBehaviour {

    public GameObject gamecontorller;
    bool config_player = false;
    public Vector3 spawntrans;
    public Vector3 starttrans;

    void Start () {

	}
	
	void Update () {
		
	}

    public void Wyjscie()
    {
        this.transform.position = starttrans;
    }

    public void SetSpawnPoint(GameObject spawn)
    {
        spawntrans = spawn.GetComponent<Transform>().position;
        spawntrans.y += 1.36F;
    }

    public void ConfigPlayer(GameObject spawn)
    {
        config_player = true;
        Destroy(GetComponent<Rigidbody>());
        SpawnAllPole sap = spawn.GetComponent<SpawnAllPole>();
        starttrans = sap.escape.transform.position;
        starttrans.y += 1.36F;
        this.GetComponentInChildren<MeshRenderer>().material = sap.playermat;
        Wyjscie();
    }

    void OnCollisionEnter(Collision coll)
    {
        if (coll.transform.tag == "Respawn")
        {
            SetSpawnPoint(coll.gameObject);
            Debug.Log("dsdsd");
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "RespawnConfig" && config_player == false)
        {
            ConfigPlayer(other.gameObject);
        }
    }

}
