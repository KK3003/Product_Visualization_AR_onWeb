using System.Collections;
using UnityEngine;

public class AutoHide_Instruction : MonoBehaviour
{
    public GameObject Instructions;
    public int seconds;

    void Start()
    {
        StartCoroutine(RemoveAfterSeconds());
    }

    IEnumerator RemoveAfterSeconds()
    {
        yield return new WaitForSeconds(seconds);
        Instructions.SetActive(false);
    }
}
