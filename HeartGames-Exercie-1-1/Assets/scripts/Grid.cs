using UnityEngine;
using System.Collections;

public class Grid : MonoBehaviour {

	private static int GRID_SIZE = 5;
	private static int TARGET_VALUE = 10 ;
	private static int TILE_MAXIMUM_VALUE = 9 ;

	public GameObject[] grid ;

	public int grid_size = GRID_SIZE ;

	public void CreateGrid(){
		for(int x_tilesCreated = 0 ; x_tilesCreated < grid_size ; x_tilesCreated++){
			for(int y_tilesCreated = 0 ; y_tilesCreated < grid_size ; y_tilesCreated++){
				int random_value = (int)(Random.value*(TILE_MAXIMUM_VALUE-1)+1);
				string value =  random_value.ToString();
				GameObject newTile = GameObject.CreatePrimitive(PrimitiveType.Cube);// (value, new Vector3(x_tilesCreated, 0.0f, y_tilesCreated));
				TextMesh text = new TextMesh();
				text.text = value;
				text.transform.parent = newTile.transform;
				grid[x_tilesCreated+y_tilesCreated*grid_size] = newTile;
			}
		}

		//setting the goal & the player location
		int goal_position = (int)(Random.value*(GRID_SIZE*GRID_SIZE-1));
		int player_position =  (int)(Random.value*(GRID_SIZE*GRID_SIZE-1));
		while(player_position==goal_position)
			player_position = (int)(Random.value*(GRID_SIZE*GRID_SIZE-1));

		grid[goal_position].GetComponent<TextMesh>().text=TARGET_VALUE.ToString();
	}

	// Use this for initialization
	void Start (){
		CreateGrid();
	}
	
	// Update is called once per frame
	void Update (){
	
	}
}
