using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour {

	// Use this for initialization
	void Start () {

        //delay 1 second : no args
        DelayMgr.Instance.delay(1, () => {

            Debug.Log("delay 1 second : no args");

        });

        //delay 2 second : 1 args
        DelayMgr.Instance.delay<string>(2, "args1", (string args1) => {

            Debug.Log("delay 2 second : " + args1);

        });

        //delay 3 second : 2 args
        DelayMgr.Instance.delay<string, string>(3, "args1", "args2", (string args1, string args2) => {

            Debug.Log("delay 3 second : " + args1 + " " + args2);

        });

        //delay 4 second : 3 args
        DelayMgr.Instance.delay<string, string, string>(4, "args1", "args2", "args3", (string args1, string args2, string args3) => {

            Debug.Log("delay 4 second : " + args1 + " " + args2 + " " + args3);

        });

        //delay 5 second : 4 args
        DelayMgr.Instance.delay<string, string, string, string>(5, "args1", "args2", "args3", "args4", (string args1, string args2, string args3, string args4) => {

            Debug.Log("delay 5 second : " + args1 + " " + args2 + " " + args3 + " " + args4);

        });
	
	}
	
}
