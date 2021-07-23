using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageRandomizer : MonoBehaviour
{
    public SpriteRenderer randomSpriteRenderer; //The sprite renderer that will display the random image
    public Sprite[] randomSprites;  //An Array of sprites that will be used for the image randomization

    public float timeBetweenChange = 0.2f;   //The amount of time between switching the image
    public float timeUntilStopping = 5.0f;   //The total amount of time until randomization stops

    private int RandomImageIndex = 0;   //Keep track of which image we're currently displaying
    private float ImageChangeTimer;    //How much time is left until we switch to new image
    void Start()
    {
        // Set this timer variable as soon as the script starts so it's ready for the update function
        ImageChangeTimer = timeBetweenChange;
    }

    // Update is called once per frame
    void Update()
    {
        
        ImageChangeTimer -= Time.deltaTime;
        timeUntilStopping -= Time.deltaTime;

        // If we've fully run out of time we need to select a final random image
        if (timeUntilStopping <= 0.0f)
        {
            //final image will be selected at random
            randomSpriteRenderer.sprite = randomSprites[Random.Range(0, randomSprites.Length)];
            // Destroy this script immediately stopping it from running anymore in the future
            DestroyImmediate(this);
            // Return so no other code runs in this Update function call
            return;
        }
        if (ImageChangeTimer <= 0.0f)
        {
            RandomImageIndex++;
            if (RandomImageIndex >= randomSprites.Length)
            {
                RandomImageIndex = 0;
            }
            randomSpriteRenderer.sprite = randomSprites[RandomImageIndex];
            ImageChangeTimer = timeBetweenChange;
        }
    }
}
