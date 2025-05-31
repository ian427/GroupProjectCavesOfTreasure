using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using Unity.VisualScripting;

public class Hunt2 : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed at which the object moves
    public int Scene;
    private Rigidbody2D rb;
    private Animator MonsterAnimation;
    public float moveInput;
    private bool hasOpenedChest;

    private FurnitureData furnitureData;
    public GameObject popUpMenu;
    [SerializeField] private GameManager gameManager;

    private float jumpPower = 7;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Transform feetPos;
    private float groundDistance = 0.3f;
    private float jumpTime = 0.3f;
    private bool isGrounded = false;
    private bool isJumping = false;
    private string moveDirection;

    public TMP_Text goldText;
    public TMP_Text diamondsText;
    public TMP_Text gemsText;

    public GameObject rewardTextImage;
    public TMP_Text rewardText;

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

    //VFX
    public ParticleSystem goldVFX;
    public ParticleSystem diamondVFX;
    public ParticleSystem gemsVFX;
    public GameObject walkVFX;
    public ParticleSystem jumpVFX;

    private void Start()  //Lines 74-89 made by Nova, lines 91-97 made by Dan R
    {
        furnitureData = (FurnitureData)Resources.Load("GameData");

        hasOpenedChest = false;

        //furnitureData.LoadGameData();
        popUpMenu.SetActive(false);
        walkVFX.SetActive(false);

        rewardTextImage.SetActive(false);
        //percentage = Random.Range(0, 100);

        rb = GetComponent<Rigidbody2D>();
        MonsterAnimation = GetComponent<Animator>();
        Gold = 0;//SETS furnitur date money as money
        Diamonds = 0;//SETS furnitur date money as money
        Gems = 0;//SETS furnitur date money as money

        goldImage1.SetActive(false);
        goldImage2.SetActive(false);
        diamondImage1.SetActive(false);
        diamondImage2.SetActive(false);

        gemsImage1.SetActive(false);
        gemsImage2.SetActive(false);
    }

    private void Update() //Lines 109-135 made by Nova, lines 137-158 made by Dan R
    {
        //Constantlty checks for a change in the currency values
        goldText.text = "Gold " + Gold + "";
        diamondsText.text = "Diamonds " + Diamonds + "";
        gemsText.text = "Mystic Gems " + Gems + "";

        isGrounded = Physics2D.OverlapCircle(feetPos.position, groundDistance, groundLayer);

        //When space is pressed while on the ground, the player will jump
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            jumpVFX.Play();
            MonsterAnimation.SetBool("isJumping", true);
            isJumping = true;
            rb.velocity = Vector2.up * jumpPower;
            isGrounded = false;
        }

        //The bool of isGrounded will set the right animations if true or false
        if (isGrounded == true)
        {
            isJumping = false;
            MonsterAnimation.SetBool("isJumping", false);
        }

        if (isGrounded == false)
        {
            MonsterAnimation.SetBool("isWalking", false);
            walkVFX.SetActive(false);
            MonsterAnimation.SetBool("isJumping", true);
        }

        if (moveDirection == "Left")
        {
            MoveLeft();
        }

        if (moveDirection == "Right")
        {
            MoveRight();
        }
    }

    //Moves the player left when holding the left button down
    //Lines 150 to 153 made by Nova
    public void MoveLeft()
    {
        moveDirection = "Left";
        moveSpeed = 5f;
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        transform.localScale = new Vector3(-1f, 1f, 1f);
        MonsterAnimation.SetBool("isWalking", true);
        walkVFX.SetActive(true);

        if (moveInput < 0) // Moving left
        {
            // Set the localScale's x to negative to face left
        }
    }

    //Moves the player right when holding the right button down
    //Lines 167 to 170 made by Nova
    public void MoveRight()
    {
        moveDirection = "Right";
        moveSpeed = 5f;
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        transform.localScale = new Vector3(1f, 1f, 1f);
        MonsterAnimation.SetBool("isWalking", true);
        walkVFX.SetActive(true);

        if (moveInput > 0) // Moving right
        {
            // Set the localScale's x to positive to face right
        }
    }

    //Stops moving when the button is up
    public void StopMoving()
    {
        moveDirection = "Null";
        rb.velocity = Vector2.zero;
        MonsterAnimation.SetBool("isWalking", false);
        walkVFX.SetActive(false);
    }

    //Sets the grounded bool to be true when the player is colliding with the ground
    private void OnCollisionEnter2D(Collision2D collision) //Made by Dan R
    {
        if (collision.gameObject.name == "Floor")
        {
            isGrounded = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D other) //Made by Nova
    {
        // Check if the other object has the "Collectible" tag
        if (other.gameObject.CompareTag("Chest"))
        {
            //StartCoroutine(openChest());
            //Destroy(other.gameObject);


            //Money = +Random.Range(1, 11);
            //furnitureData.Money = Money;//SETS furnitur date money as money

            //string m_Path = Application.persistentDataPath;
            //furnitureData.Path = m_Path;
            //furnitureData.SaveGameData();
        }

        if (other.gameObject.CompareTag("Home"))
        {

            SaveData();
            SceneManager.LoadScene("ShopScene");

        }
    }
    private void OnTriggerStay2D(Collider2D collision) //Made by Nova
    {
        if (collision.gameObject.CompareTag("Chest"))
        {
            if (hasOpenedChest == true)
            {
                //Destroy(collision.gameObject);
                //hasOpenedChest = false;
            }
        }
    }

    //Checks the percentage generated and assigns the appropriate rewards, images and text depending on that choice
    public void RandomizeFirstRewards() //Made by Dan R
    {
        //If gold is selected, this section will be called
        if (percentage <= 64)
        {
            rewardGold = +Random.Range(1, 11);
            reward1 = rewardGold;
            reward1Name = "Gold";
            goldImage1.SetActive(true);
            diamondImage1.SetActive(false);
            gemsImage1.SetActive(false);
            reward1Text.text = " " + reward1;
        }

        //If diamonds is selected, this section will be called
        if (percentage >= 65 && percentage < 98)
        {
            rewardDiamonds = +Random.Range(3, 7);
            reward1 = rewardDiamonds;
            reward1Name = "Diamonds";
            goldImage1.SetActive(false);
            diamondImage1.SetActive(true);
            gemsImage1.SetActive(false);
            reward1Text.text = " " + reward1;
        }

        //If gems is selected, this section will be called
        if (percentage == 98 || percentage == 99 || percentage == 100)
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

    //The second instance of rewards being generated since there are 2 choices
    public void RandomizeSecondRewards() //Made by Dan R
    {
        //If gold is selected, this section will be called
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

        //If diamonds is selected, this section will be called
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

        //If gems is selected, this section will be called
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

    //Depending on what was generated, this function will add the amount of reward to the total
    public void SelectFirstRewards() //Made by Dan R
    {
        //The case for if gold was selected
        if (reward1Name == "Gold")
        {
            goldVFX.Play();
            rewardTextImage.SetActive(true);
            StartCoroutine(disableText());
            rewardText.text = "Gold obtained: " + reward1;
            Gold += reward1;
        }

        //The case for if diamonds were selected
        if (reward1Name == "Diamonds")
        {
            diamondVFX.Play();
            rewardTextImage.SetActive(true);
            StartCoroutine(disableText());
            rewardText.text = "Diamonds obtained: " + reward1;
            Diamonds += reward1;
        }

        //The case for if gems were selected
        if (reward1Name == "Gems")
        {
            gemsVFX.Play();
            rewardTextImage.SetActive(true);
            StartCoroutine(disableText());
            rewardText.text = "Gems obtained: " + reward1;
            Gems += reward1;
        }

        itemSelectSFX.Play();
        moveSpeed = 5f;
        hasOpenedChest = true;
    }

    //Second instance of rewards being added to the count
    public void SelectSecondRewards() //Made by Dan R
    {
        //The case for if gold was selected
        if (reward2Name == "Gold")
        {
            goldVFX.Play();
            rewardTextImage.SetActive(true);
            StartCoroutine(disableText());
            rewardText.text = "Gold obtained: " + reward2;
            Gold += reward2;
        }

        //The case for if diamonds were selected
        if (reward2Name == "Diamonds")
        {
            diamondVFX.Play();
            rewardTextImage.SetActive(true);
            StartCoroutine(disableText());
            rewardText.text = "Diamonds obtained: " + reward2;
            Diamonds += reward2;
        }

        //The case for if gems were selected
        if (reward2Name == "Gems")
        {
            gemsVFX.Play();
            rewardTextImage.SetActive(true);
            StartCoroutine(disableText());
            rewardText.text = "Gems obtained: " + reward2;
            Gems += reward2;
        }

        itemSelectSFX.Play();
        moveSpeed = 5f;
        hasOpenedChest = true;
    }

    //Called at the end of the hunt, adds what was gathered to the total amount
    public void SaveData() //Made by Dan R
    {
        furnitureData.Gold += Gold;

        furnitureData.Diamond += Diamonds;

        furnitureData.Gem += Gems;
    }

    //Connects to the chest scripts, is called when the chest is clicked on
    public void ClickOnChest() //Made by Dan R
    {
        StartCoroutine(openChest());
        chestOpenSFX.Play();
        moveSpeed = 0;
    }

    //Waits for 2 seconds before the reward functions are called
    public IEnumerator openChest() //Made by Dan R
    {
        yield return new WaitForSeconds(2);
        popUpMenu.SetActive(true);
        percentage = Random.Range(0, 100);
        RandomizeFirstRewards();
        percentage = Random.Range(0, 100);
        RandomizeSecondRewards();
    }

    //Disables an animated reward text after the reward is gathered
    private IEnumerator disableText() //Made by Dan R
    {
        yield return new WaitForSeconds(1);
        rewardTextImage.SetActive(false);
    }
}

