# delay-tool-unity

this is a easy-to-use delay manager class

for example, if you want to call a function with two args after 2 seconds, you just do it like this:

        DelayMgr.Instance.delay<string, string>(2, "args1", "args2", (string args1, string args2) => {

            Debug.Log("delay 3 second : " + args1 + " " + args2);

        });
        
wish you like it
        
