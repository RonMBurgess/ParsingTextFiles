using Parse;
using UnityEngine;
using System.Collections;

public class Parse_Test_Script : MonoBehaviour {

	// Use this for initialization
	void Start () {

        ParseObject testObject = new ParseObject("TestObject");
        testObject["foo"] = "bar";
        testObject.SaveAsync();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

}
