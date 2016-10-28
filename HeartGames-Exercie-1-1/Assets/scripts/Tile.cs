using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour {

	public TextMesh value ; 

	public Tile (){
		value = new TextMesh();
		value.text = "";
	}

	public Tile (string text){
		value = new TextMesh();
		value.text = text;
	}

	public Tile (string text, Vector3 position){
		value = new TextMesh();
		value.text = text;
		GetComponent<Rigidbody>().position=position;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
