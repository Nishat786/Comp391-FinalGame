using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyByContact : MonoBehaviour {

    public int DeathWaitTime = 2;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
            Destroy(col.gameObject);
        StartCoroutine(WaitSomeSeconds());
    }
    IEnumerator WaitSomeSeconds()
    {
        yield return new WaitForSeconds(DeathWaitTime);
        SceneManager.LoadScene("SampleScene");
    }
}
