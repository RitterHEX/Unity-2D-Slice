using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlicableWatermellon : MonoBehaviour
{
    [SerializeField] private GameObject unslicedObject;
    private GameObject slicedObject;

    private Rigidbody2D m_rigibody;
    private Collider2D m_collider;

    private void Awake() {
        m_rigibody = GetComponent<Rigidbody2D>();
        m_collider = GetComponent<Collider2D>();
    }

    public void setSlicedObject(GameObject slicedObject){
        this.slicedObject = slicedObject;
    }

    public GameObject getSlicedObject(){
        return slicedObject;
    }

    public void Slice(){
        // Debug.Log("slice!");
        unslicedObject.SetActive(false);
        slicedObject.SetActive(true);

        m_collider.enabled = false;
        
        for(int i = 0; i < slicedObject.transform.childCount; i++){
            Rigidbody2D sliceRigidbody = slicedObject.transform.GetChild(i).GetComponent<Rigidbody2D>();
            sliceRigidbody.velocity = m_rigibody.velocity;
        }

        m_rigibody.bodyType = RigidbodyType2D.Static;
    }
}
