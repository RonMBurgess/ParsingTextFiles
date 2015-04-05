using Parse;
using UnityEngine;
using System.Collections;
using System.Threading.Tasks;

public class Parse_Test_User_Script : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("Creating new User Steve");
        var user = new ParseUser()
        {
            Username = "Steve Johnson",
            Password = "SteveJohnsonIsThebomb2022",
            Email = "SteveJohnsonRules@gmail.com"
            
        };
        Debug.Log("Created new user Steve");
        // other fields can be set just like with ParseObject
        //user["phone"] = "650-555-0000";

        Task signUpTask = user.SignUpAsync();
	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
