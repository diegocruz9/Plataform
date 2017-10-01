using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

  
    private Rigidbody2D rb2d;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Start () {
	
	}
	
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log(Input.anyKey);
        }
    }

   
}
