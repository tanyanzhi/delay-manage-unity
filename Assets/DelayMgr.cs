using UnityEngine;
using System.Collections;

//delay manager
public class DelayMgr : MonoBehaviour{

    public static DelayMgr Instance = null;

    void Awake() {

        Instance = this;

    }

    //delay callback with no args
    public void delay(float delayTime, Callback callback){

        StartCoroutine(startDelay(delayTime, callback));

    }

    //delay callback with 1 args
    public void delay<T>(float delayTime, T args1, Callback<T> callback) {

        StartCoroutine(startDelay<T>(delayTime, args1, callback));

    }

    //delay callback with 2 args
    public void delay<T, U>(float delayTime, T args1, U args2, Callback<T, U> callback) {

        StartCoroutine(startDelay<T, U>(delayTime, args1, args2, callback));

    }

    //delay callback with 3 args
    public void delay<T, U, V>(float delayTime, T args1, U args2, V args3, Callback<T, U, V> callback) {

        StartCoroutine(startDelay<T, U, V>(delayTime, args1, args2, args3, callback));

    }

    //delay callback with 4 args
    public void delay<T, U, V, W>(float delayTime, T args1, U args2, V args3, W args4, Callback<T, U, V, W> callback) {

        StartCoroutine(startDelay<T, U, V, W>(delayTime, args1, args2, args3, args4, callback));

    }



    private IEnumerator startDelay(float delayTime, Callback callback) {

        yield return new WaitForSeconds(delayTime);

        callback();

    }

    private IEnumerator startDelay<T>(float delayTime, 
                                      T args1, 
                                      Callback<T> callback) {

        yield return new WaitForSeconds(delayTime);

        callback(args1);

    }

    private IEnumerator startDelay<T, U>(float delayTime, 
                                         T args1, 
                                         U args2, 
                                         Callback<T, U> callback) {

        yield return new WaitForSeconds(delayTime);

        callback(args1, args2);

    }

    private IEnumerator startDelay<T, U, V>(float delayTime, 
                                            T args1, 
                                            U args2, 
                                            V args3, 
                                            Callback<T, U, V> callback) {

        yield return new WaitForSeconds(delayTime);

        callback(args1, args2, args3);

    }

    private IEnumerator startDelay<T, U, V, W>(float delayTime, 
                                               T args1, 
                                               U args2, 
                                               V args3, 
                                               W args4, 
                                               Callback<T, U, V, W> callback) {

        yield return new WaitForSeconds(delayTime);

        callback(args1, args2, args3, args4);


    }
	
}

public delegate void Callback();
public delegate void Callback<T>(T args1);
public delegate void Callback<T, U>(T args1, U args2);
public delegate void Callback<T, U, V>(T args1, U args2, V args3);
public delegate void Callback<T, U, V, W>(T args1, U args2, V args3, W args4);
