using UnityEngine;
using System.Collections;

public class TriggerLightMoon : MonoBehaviour
{
    private Light light;

    void Awake()
    {
        light = this.transform.GetComponent<Light>();
    }

    public void Work()
    {
        this.StartCoroutine("LightMoon");
    }

    private IEnumerator LightMoon()
    {
        float val = 4, per = 0.05f;
        while (true)
        {
            light.intensity += per;
            val -= per;
            if (val <= 0)
            {
                break;
            }
            yield return new WaitForEndOfFrame();
        }
    }
}