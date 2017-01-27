using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delays : MonoBehaviour {

    IEnumerator DeathDelay ()
    {
        yield return new WaitForSeconds(3);
    }
}
