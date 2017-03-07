using UnityEngine;
using System.Collections;

public class TriggerDestroy : MonoBehaviour
{
    public TriggerLightMoon moon;

    private bool finished = false;

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (!finished)
        {
            finished = true;
            this.StartCoroutine("Work");
        }
    }

    private IEnumerator Work()
    {
        if (moon != null)
        {
            moon.Work();
        }
        yield return new WaitForSeconds(2f);
        if (this.transform.parent != null)
        {
            GameObject.Destroy(this.transform.parent.gameObject);
        }
    }
}