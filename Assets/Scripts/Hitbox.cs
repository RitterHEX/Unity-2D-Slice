using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitbox : MonoBehaviour
{
    [SerializeField] private SlicableWatermellon slicable;
    [SerializeField] private GameObject sliced;

    public void OnMouseExit() {
        if(slicable.getSlicedObject() == null){
            slicable.setSlicedObject(sliced);
            slicable.Slice();
        }
    }
}
