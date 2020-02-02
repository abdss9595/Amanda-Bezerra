using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField]
    private float maxmoX;
    [SerializeField]
    private float minimoX;
    [SerializeField]
    private float minomoY;
    [SerializeField]
    private float maximoY;

    public Transform player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(player.position.x, minimoX, maxmoX), Mathf.Clamp(player.position.y, minomoY, maximoY), transform.position.z);
    }
}
