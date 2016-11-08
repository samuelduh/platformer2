using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour
{

    private Character character;
    private Vector3 offset = new Vector3(0, 0, -10);

	// Use this for initialization
	void Start ()
    {

        character = FindObjectOfType<Character>();
        offset = transform.position - character.transform.position;
        //Debug.Log(offset);

	}
	
	// Update is called once per frame
	void Update ()
    {

        transform.position = character.transform.position + offset;

	}
}


//brianna throws spiders at people;