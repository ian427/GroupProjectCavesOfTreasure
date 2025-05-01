using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Hunt2 : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed at which the object moves
    public int Scene;
    private Animator MonsterAnimation;
    public float moveInput;

    private FurnitureData furnitureData;
    public GameObject popUpMenu;

    public TMP_Text goldText;
    public TMP_Text diamondsText;
    public TMP_Text gemsText;

    public int Gold;
    public int Diamonds;
    public int Gems;

    public int rewardGold;
    public int rewardDiamonds;
    public int rewardGems;
    public int percentage;

    public int reward1;
    public int reward2;

    public TMP_Text reward1Text;
    public TMP_Text reward2Text;

    public string reward1Name;
    public string reward2Name;


    private void Start()
    {
        furnitureData = (FurnitureData)Resources.Load("GameData");
        string m_Path = Application.dataPath;
        furnitureData.Path = m_Path;
        Debug.Log(m_Path);
        furnitureData.LoadGameData();
        popUpMenu.SetActive(false);
        //percentage = Random.Range(0, 100);

        MonsterAnimation = GetComponent<Animator>();
        //Money= furnitureData.Money ;//SETS furnitur date money as money
    }

    private void Update()
    {
        goldText.text = "Gold " + Gold + "";
        diamondsText.text = "Diamonds " + Diamonds + "";
        gemsText.text = "Mystic Gems " + Gems + "";

        // Get horizontal input (left and right arrow keys, A/D, etc.)
        float moveInput = Input.GetAxis("Horizontal");

        // Move the GameObject left and right
        transform.Translate(Vector3.right * moveInput * moveSpeed * Time.deltaTime);

        // Flip the GameObject when moving left or right
        if (moveInput > 0) // Moving right
        {
            // Set the localScale's x to positive to face right
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        else if (moveInput < 0) // Moving left
        {
            // Set the localScale's x to negative to face left
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }

        // If the player is moving, play the walking animation
        if (moveInput != 0)
        {
            MonsterAnimation.SetBool("isWalking", true);
        }
        else
        {
            // If no movement input, stop the walking animation
            MonsterAnimation.SetBool("isWalking", false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the other object has the "Collectible" tag
        if (other.gameObject.CompareTag("Chest"))
        {
            Destroy(other.gameObject);
            percentage = Random.Range(0, 100);
            RandomizeFirstRewards();
            percentage = Random.Range(0, 100);
            RandomizeSecondRewards();

            //Money = +Random.Range(1, 11);
            //furnitureData.Money = Money;//SETS furnitur date money as money

            popUpMenu.SetActive(true);
            string m_Path = Application.dataPath;
            furnitureData.Path = m_Path;
            furnitureData.SaveGameData();

        }

        if (other.gameObject.CompareTag("Home"))
        {


            SceneManager.LoadScene("ShopTest");

        }
    }

    public void RandomizeFirstRewards()
    {
        if(percentage <= 64)
        {
            rewardGold = +Random.Range(1, 11);
            reward1 = rewardGold;
            reward1Name = "Gold";
            reward1Text.text = " " + reward1;
        }

        if(percentage >= 65 && percentage < 98)
        {
            rewardDiamonds = +Random.Range(3, 7);
            reward1 = rewardDiamonds;
            reward1Name = "Diamonds";
            reward1Text.text = " " + reward1;
        }

        if(percentage == 98 || percentage == 99 || percentage == 100)
        {
            rewardGems = +Random.Range(1, 4);
            reward1 = rewardGems;
            reward1Name = "Gems";
            reward1Text.text = " " + reward1;
        }
    }

    public void RandomizeSecondRewards()
    {
        if (percentage <= 64)
        {
            rewardGold = +Random.Range(1, 11);
            reward2 = rewardGold;
            reward2Name = "Gold";
            reward2Text.text = " " + reward2;
        }

        if (percentage >= 65 && percentage < 98)
        {
            rewardDiamonds = +Random.Range(3, 7);
            reward2 = rewardDiamonds;
            reward2Name = "Diamonds";
            reward2Text.text = " " + reward2;
        }

        if (percentage == 98 || percentage == 99 || percentage == 100)
        {
            rewardGems = +Random.Range(1, 4);
            reward2 = rewardGems;
            reward2Name = "Gems";
            reward2Text.text = " " + reward2;
        }
    }

    public void SelectFirstRewards()
    {
        if(reward1Name == "Gold")
        {
            Gold += reward1;
        }

        if (reward1Name == "Diamonds")
        {
            Diamonds += reward1;
        }

        if (reward1Name == "Gems")
        {
            Gems += reward1;
        }
    }

    public void SelectSecondRewards()
    {
        if (reward2Name == "Gold")
        {
            Gold += reward2;
        }

        if (reward2Name == "Diamonds")
        {
            Diamonds += reward2;
        }

        if (reward2Name == "Gems")
        {
            Gems += reward2;
        }
    }
}
