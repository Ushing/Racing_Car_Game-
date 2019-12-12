using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditFinish : MonoBehaviour {

	// Use this for initialization
	void Start () {

        StartCoroutine(CreditEnd());
	}
    IEnumerator CreditEnd()
    {
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene(0);
    }
}
