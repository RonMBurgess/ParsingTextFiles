using UnityEngine;
using System.Collections;
using System.IO;
using System.Text;


public class ReadFromFile : MonoBehaviour {

    string filename = "Resources/Textfile.txt";

	// Use this for initialization
	void Start () {
	var sourse=new StreamReader(Application.dataPath+"/" + filename);
    var fileContents=sourse.ReadToEnd();
    sourse.Close();
    var lines=fileContents.Split("\n"[0]);
    foreach(string line in lines) {
        print(line);
    }
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void readTextFile(string file_path)
    {
        StreamReader inp_stm = new StreamReader(file_path);

        while (!inp_stm.EndOfStream)
        {
            string inp_ln = inp_stm.ReadLine();
            Debug.Log(inp_ln);
            // Do Something with the input. 
        }

        inp_stm.Close();
    }
}
