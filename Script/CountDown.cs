using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour {

    public GameObject CountDowns;
    public AudioSource GetReady;
    public AudioSource GoAudio;
    public GameObject LapTimer;
   public GameObject CarControls;
   public AudioSource LevelMusic;
	void Start () {

        StartCoroutine(CountStart());
	}
	
    IEnumerator CountStart()
    {
        yield return new WaitForSeconds(0.5f);
        CountDowns.GetComponent<Text>().text = "3";
        GetReady.Play();
        CountDowns.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDowns.SetActive(false);
        CountDowns.GetComponent<Text>().text = "2";
        GetReady.Play();
        CountDowns.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDowns.SetActive(false);
        CountDowns.GetComponent<Text>().text = "1";
        GetReady.Play();
        CountDowns.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDowns.SetActive(false);
        GoAudio.Play();
        LevelMusic.Play();
        LapTimer.SetActive(true);
        CarControls.SetActive(true);
    }
	
}
