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
    [SerializeField] private GameManager gameManager;

    public TMP_Text goldText;
    public TMP_Text diamondsText;
    public TMP_Text gemsText;

    [HideInInspector] public int Gold;
    [HideInInspector] public int Diamonds;
    [HideInInspector] public int Gems;

    [HideInInspector] public int rewardGold;
    [HideInInspector] public int rewardDiamonds;
    [HideInInspector] public int rewardGems;
    [HideInInspector] public int percentage;

    public int reward1;
    public int reward2;

    public TMP_Text reward1Text;
    public TMP_Text reward2Text;

    public string reward1Name;
    public string reward2Name;

    public GameObject goldImage1;
    public GameObject goldImage2;
    public GameObject diamondImage1;
    public GameObject diamondImage2;
    public GameObject gemsImage1;
    public GameObject gemsImage2;

    //SFX
    public AudioSource chestOpenSFX;
    public AudioSource itemSelectSFX;

    private void Start()
    {
        furnitureData = (FurnitureData)Resources.Load("GameData");
       
        //furnitureData.LoadGameData();
        popUpMenu.SetActive(false);
        //percentage = Random.Range(0, 100);

        MonsterAnimation = GetComponent<Animator>();
        Gold = 0 ;//SETS furnitur date money as money
        Diamonds = 0 ;//SETS furnitur date money as money
        Gems = 0;//SETS furnitur date money as money

        goldImage1.SetActive(false);
        goldImage2.SetActive(false);
        diamondImage1.SetActive(false);
        diamondImage2.SetActive(false);
        gemsImage1.SetActive(false);
        gemsImage2.SetActive(false);
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
            chestOpenSFX.Play();
            moveSpeed = 0;
            percentage = Random.Range(0, 100);
            RandomizeFirstRewards();
            percentage = Random.Range(0, 100);
            RandomizeSecondRewards();

            //Money = +Random.Range(1, 11);
            //furnitureData.Money = Money;//SETS furnitur date money as money

            popUpMenu.SetActive(true);
            //string m_Path = Application.dataPath;
            //furnitureData.Path = m_Path;
            //furnitureData.SaveGameData();

        }

        if (other.gameObject.CompareTag("Home"))
        {

            SaveData();
            SceneManager.LoadScene("ShopScene");

        }
    }

    public void RandomizeFirstRewards()
    {
        if(percentage <= 64)
        {
            rewardGold = +Random.Range(1, 11);
            reward1 = rewardGold;
            reward1Name = "Gold";
            goldImage1.SetActive(true);
            diamondImage1.SetActive(false);
            gemsImage1.SetActive(false);
            reward1Text.text = " " + reward1;
        }

        if(percentage >= 65 && percentage < 98)
        {
            rewardDiamonds = +Random.Range(3, 7);
            reward1 = rewardDiamonds;
            reward1Name = "Diamonds";
            goldImage1.SetActive(false);
            diamondImage1.SetActive(true);
            gemsImage1.SetActive(false);
            reward1Text.text = " " + reward1;
        }

        if(percentage == 98 || percentage == 99 || percentage == 100)
        {
            rewardGems = +Random.Range(1, 4);
            reward1 = rewardGems;
            reward1Name = "Gems";
            goldImage1.SetActive(false);
            diamondImage1.SetActive(false);
            gemsImage1.SetActive(true);
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
            goldImage2.SetActive(true);
            diamondImage2.SetActive(false);
            gemsImage2.SetActive(false);
            reward2Text.text = " " + reward2;
        }

        if (percentage >= 65 && percentage < 98)
        {
            rewardDiamonds = +Random.Range(3, 7);
            reward2 = rewardDiamonds;
            reward2Name = "Diamonds";
            goldImage2.SetActive(false);
            diamondImage2.SetActive(true);
            gemsImage2.SetActive(false);
            reward2Text.text = " " + reward2;
        }

        if (percentage == 98 || percentage == 99 || percentage == 100)
        {
            rewardGems = +Random.Range(1, 4);
            reward2 = rewardGems;
            reward2Name = "Gems";
            goldImage2.SetActive(false);
            diamondImage2.SetActive(false);
            gemsImage2.SetActive(true);
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

        itemSelectSFX.Play();
        moveSpeed = 5f;
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

        itemSelectSFX.Play();
        moveSpeed = 5f;
    }

    public void SaveData()
    {
        furnitureData.Gold += Gold;

        furnitureData.Diamond += Diamonds;

        furnitureData.Gem += Gems;
    }

    public void ResetMoneyForTestReasons()
    {
        furnitureData.Gold = 10;
        furnitureData.Diamond = 5;
        furnitureData.Gem = 2;
    }
}
