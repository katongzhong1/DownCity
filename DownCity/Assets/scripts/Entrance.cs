using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GST.CharaSpace;
using GST.CategorySpace;

public class Entrance : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(Activity());
        string result = "Assets/scripts/main/data/global/characters/config/person.txt".ReadText();
        result = result.Split('\n')[1];

        Chara person = new Chara(result);
        Debug.Log(person.surname);
        Debug.Log(person.lastname);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator Activity() {

        yield return 0;
    }
}
