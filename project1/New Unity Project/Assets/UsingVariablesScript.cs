using UnityEngine;
using System.Collections;

public class UsingVariablesScript : MonoBehaviour {
    // This variable is used to set the starting position of the cube
    public int StartingPosition = 5;

    //Store if the cube is greater than zero
    bool PositionGreaterThanZero;

	// Use this for initialization
	void Start () {
        // This is a local variable to temporarily store and manipulate the transform position
        Vector3 Position = transform.position;
        Position.y = StartingPosition;
        transform.position = Position;

        PositionGreaterThanZero = true;

	}
	
	// Update is called once per frame
	void Update () {
        DropToZero();
	}

    // This is a function to drop the cube to zero
    void DropToZero ()
    {
        // Only work if above zero
        if (PositionGreaterThanZero)
        {
            Vector3 Position = transform.position;

            // Use the change in time to drop the cube 
            Position.y -= Time.deltaTime;

            // If it's below zero make it equal to zero
            if (Position.y < 0)
            {
                Position.y = 0;
                PositionGreaterThanZero = false;
            }

            transform.position = Position;
        }

        else
        {
            Vector3 Position = transform.position;

            // Use the change in time to drop the cube 
            Position.x -= Time.deltaTime;

            // If it's below zero make it equal to zero
            if (Position.x < -2)
            {
                Position.x = -2;
            }

            transform.position = Position;
        }
    }
}
