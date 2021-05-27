using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundloop : MonoBehaviour
{


 [ SerializeField]  private Vector2 palmulit;
    private Transform camtransform;
    private Vector3 lastcampos;
    private float textureUnitSizeX;
    void Start()
    {
        camtransform = Camera.main.transform;
        lastcampos = camtransform.position;
        Sprite sprite = GetComponent<SpriteRenderer>().sprite;
        Texture2D texture = sprite.texture;
        textureUnitSizeX = texture.width / sprite.pixelsPerUnit;
    }
    private void LateUpdate()
    {
        Vector3 deltaMovement = camtransform.position - lastcampos;
        float palmulit = .5f;
        transform.position += new Vector3(deltaMovement.x * palmulit, deltaMovement.y * palmulit);
        lastcampos = camtransform.position;
        if(camtransform.position.x - transform.position.x >= textureUnitSizeX)
        {
            float offsetPositionX = (camtransform.position.x - transform.position.x) % textureUnitSizeX;
            transform.position = new Vector3(camtransform.position.x + offsetPositionX, transform.position.y);


        }
    }
}