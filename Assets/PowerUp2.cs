using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp2 : MonoBehaviour
{
    private bool canPowerUp = true;
    private float BirdSize = 0.5f;
    private Vector2 BaseBirdSize;
    private GameManager anotherScript;
    public int PowerNeed = 10;



    // Start is called before the first frame update
    void Start()
    {
        BaseBirdSize = transform.localScale;
        anotherScript = GetComponent<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        BaseBirdSize = transform.localScale;

        if (canPowerUp = true)
        {
            BaseBirdSize = BaseBirdSize * BirdSize;
            Debug.Log("PowerUP");
        }

    }
}
