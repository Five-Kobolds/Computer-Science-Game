using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile_Destroy : MonoBehaviour
{
    GameObject self;

    private void Update()
    {
        self = this.gameObject;
        Destroy(self, 2f);
    }
}
