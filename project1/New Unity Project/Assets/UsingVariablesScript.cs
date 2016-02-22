using UnityEngine;
using System.Collections;

public class UsingVariablesScript : MonoBehaviour {
    // This variable is used to set the starting position of the cube
    public int StartingPosition = 5;

	// Use this for initialization
	void Start () {
        // This is a local variable to temporarily store and manipulate the transform position
        Vector3 Position = transform.position;
        Position.y = StartingPosition;
        transform.position = Position;
	}
	
	// Update is called once per frame
	void Update () {
        DropToZero();
	}

    // This is a function to drop the cube to zero
    void DropToZero ()
    {
        // Only work if above zero
        if (transform.position.y > 0)
        {
            Vector3 Position = transform.position;
            
            // Use the change in time to drop the cube 
            Position.y -= Time.deltaTime;
            
            // If it's below zero make it equal to zero
            if (Position.y < 0)
            {
                Position.y = 0;
            }
            transform.position = Position;
        }
    }
}
