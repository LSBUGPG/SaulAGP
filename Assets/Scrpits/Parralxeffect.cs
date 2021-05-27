using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parralxeffect : MonoBehaviour
{
    public Transform[] backgrounds;
    private float[] paralaxScales;
    public float smoothing = 1f;

    private Transform cam;
    private Vector3 previousCampos;

    void Awake()
    {
        cam = Camera.main.transform;
    }
    void Start()
    {
        previousCampos = cam.position;

        paralaxScales = new float[backgrounds.Length];

        for (int i = 0; i < backgrounds.Length; i++)
        {
            paralaxScales[i] = backgrounds[i].position.z - 1;
        }

    }
    void Update()
    {
        for (int i = 0; i < backgrounds.Length; i++)
        {
            float parallax = (previousCampos.x - cam.position.x) * paralaxScales[i];
            float backgroundTargetposx = backgrounds[i].position.x + parallax;
            Vector3 backgroundTargetPos = new Vector3(backgroundTargetposx, backgrounds[i].position.y, backgrounds[i].position.z);
            backgrounds[i].position = Vector3.Lerp(backgrounds[i].position, backgroundTargetPos, smoothing * Time.deltaTime);
        }
    }
}