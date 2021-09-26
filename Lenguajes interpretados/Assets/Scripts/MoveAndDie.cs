using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAndDie : MonoBehaviour
{
    public void BoolMoveAndDie()
    {
        StartCoroutine("Move");
    }
    IEnumerator Move()
    {
        Debug.Log("Tocado");
        yield return new WaitForSeconds(1f);
        GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
        yield return new WaitForSeconds(3f);
        GetComponent<Rigidbody>().AddForce(Vector3.up * 600f);
        yield return new WaitForSeconds(3f);
        Destroy(this.gameObject);
    }
}
