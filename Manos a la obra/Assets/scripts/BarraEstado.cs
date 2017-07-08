using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraEstado : MonoBehaviour {

    float timelife, maxTime = 100f, time;
    public Image stateBar;
	// Use this for initialization
	void Start () {
        timelife = maxTime;
	}
	
	// Update is called once per frame
	void Update () {
        Timer(time = 1 * Time.deltaTime);
	}

    public void Timer(float amount)
    {
        timelife = Mathf.Clamp(timelife - amount, 0f, maxTime);
        stateBar.transform.localScale = new Vector2(timelife/maxTime, 0.8101366f);
    }
}
