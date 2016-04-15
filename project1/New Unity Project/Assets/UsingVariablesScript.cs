using UnityEngine;
using System.Collections;

public class UsingVariablesScript : MonoBehaviour {
    // This variable is used to set the starting position of the cube
    public int StartingPosition = 5;

    //Store if the cube is greater than zero
    bool PositionGreaterThanZero;
    bool Adding;

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
        DropToZeroBounce(2);
	}

    // This is a function to drop the cube to zero and then bounce back and forth between the passed param
    void DropToZeroBounce (int Xlimit)
    {
        // Drop the cube if above zero
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
                Adding = true;
            }

            transform.position = Position;
        }

        else if (Adding)
        {
            Vector3 Position = transform.position;

            // Use the change in time to drop the cube 
            int i = 5;
            while (i > 0)
            {
                Position.x += Time.deltaTime;
                i--;
            }

            Position.x += Time.deltaTime;

            //
            if (Position.x > Xlimit)
            {
                Position.x = Xlimit;
                Adding = false;

            }

            transform.position = Position;
        }

        else
        {
            Vector3 Position = transform.position;

            // Use the change in time to drop the cube 
            for (int i = 0; i < 10; i++) { 
                Position.x -= Time.deltaTime;
            }

            //
            if (Position.x < -Xlimit)
            {
                Position.x = -Xlimit;
                Adding = true;

            }

            transform.position = Position;
        }

    }
}
