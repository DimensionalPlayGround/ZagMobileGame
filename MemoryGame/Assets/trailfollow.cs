using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trailfollow : MonoBehaviour
{
    TrailRenderer TR;
    // Start is called before the first frame update
    void Start()
    {
        TR = gameObject.GetComponent<TrailRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        TR.AddPosition(new Vector3(1, 0, 0));
    }
}
