using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopControlScript : MonoBehaviour {

	int moneyAmount;
	int isElephantSold;
	int isgiraffeSold;
	int ishippoSold;
	int ismonkeySold;
	int ispandaSold;
	int ispenguinSold;
	int ispigSold;
	int israbbitSold;
	
	

	public Text Points;

	public Text riflePrice;
	public Button buyButton;
	public Button elephantSelectButton;

	public Text giraffePrice;
	public Button giraffebuyButton;
	public Button giraffeSelectButton;

	public Text hippoPrice;
	public Button hippobuyButton;
	public Button hippoSelectButton;

	public Text monkeyPrice;
	public Button monkeybuyButton;
	public Button monkeySelectButton;

	public Text pandaPrice;
	public Button pandabuyButton;
	public Button pandaSelectButton;

	public Text penguinPrice;
	public Button penguinbuyButton;
	public Button penguinSelectButton;

	public Text pigPrice;
	public Button pigbuyButton;
	public Button pigSelectButton;

	public Text rabbitPrice;
	public Button rabbitbuyButton;
	public Button rabbitSelectButton;




	// Use this for initialization
	void Start () {
		moneyAmount = PlayerPrefs.GetInt ("Score");
	}
	
	// Update is called once per frame
	void Update () {
		
		Points.text = "Points: " + moneyAmount.ToString();

		isElephantSold = PlayerPrefs.GetInt ("isElephantSold");
		isgiraffeSold = PlayerPrefs.GetInt("isgiraffeSold");
		ishippoSold = PlayerPrefs.GetInt("ishippoSold");
		ismonkeySold = PlayerPrefs.GetInt("ismonkeySold");
		ispandaSold = PlayerPrefs.GetInt("ispandaSold");
		ispenguinSold = PlayerPrefs.GetInt("ispenguinSold");
		ispigSold = PlayerPrefs.GetInt("ispigSold");
		israbbitSold = PlayerPrefs.GetInt("israbbitSold");

		if (moneyAmount >= 5 && isElephantSold == 0)
			buyButton.interactable = true;
		else
			buyButton.interactable = false;

		if (moneyAmount >= 5 && isgiraffeSold == 0)
			giraffebuyButton.interactable = true;
		else
			giraffebuyButton.interactable = false;

		if (moneyAmount >= 5 && ishippoSold == 0)
			hippobuyButton.interactable = true;
		else
			hippobuyButton.interactable = false;

		if (moneyAmount >= 5 && ismonkeySold == 0)
			monkeybuyButton.interactable = true;
		else
			monkeybuyButton.interactable = false;

		if (moneyAmount >= 5 && ispandaSold == 0)
			pandabuyButton.interactable = true;
		else
			pandabuyButton.interactable = false;

		if (moneyAmount >= 5 && ispenguinSold == 0)
			penguinbuyButton.interactable = true;
		else
			penguinbuyButton.interactable = false;

		if (moneyAmount >= 5 && ispigSold == 0)
			pigbuyButton.interactable = true;
		else
			pigbuyButton.interactable = false;

		if (moneyAmount >= 5 && israbbitSold == 0)
			rabbitbuyButton.interactable = true;
		else
			rabbitbuyButton.interactable = false;

		if (isElephantSold == 0)
			elephantSelectButton.interactable = false;
		else
			elephantSelectButton.interactable = true;

		if (isgiraffeSold == 0)
			giraffeSelectButton.interactable = false;
		else
			giraffeSelectButton.interactable = true;

		if (ishippoSold == 0)
			hippoSelectButton.interactable = false;
		else
			hippoSelectButton.interactable = true;

		if (ismonkeySold == 0)
			monkeySelectButton.interactable = false;
		else
			monkeySelectButton.interactable = true;

		if (ispandaSold == 0)
			pandaSelectButton.interactable = false;
		else
			pandaSelectButton.interactable = true;

		if (ispenguinSold == 0)
			penguinSelectButton.interactable = false;
		else
			penguinSelectButton.interactable = true;

		if (ispigSold == 0)
			pigSelectButton.interactable = false;
		else
			pigSelectButton.interactable = true;

		if (israbbitSold == 0)
			rabbitSelectButton.interactable = false;
		else
			rabbitSelectButton.interactable = true;
	}

	public void buyRifle()
	{
		moneyAmount -= 5;
		PlayerPrefs.SetInt ("isElephantSold", 1);
		PlayerPrefs.SetInt("Score", moneyAmount);
		riflePrice.text = "Sold!";
		buyButton.gameObject.SetActive (false);
		PlayerPrefs.SetInt("Animal", 1);
	}

	public void buygiraffe()
	{
		moneyAmount -= 5;
		PlayerPrefs.SetInt("isgiraffeSold", 1);
		PlayerPrefs.SetInt("Score", moneyAmount);
		giraffePrice.text = "Sold!";
		giraffebuyButton.gameObject.SetActive(false);
		PlayerPrefs.SetInt("Animal", 2);
	}

	public void buyhippo()
	{
		moneyAmount -= 5;
		PlayerPrefs.SetInt("ishippoSold", 1);
		PlayerPrefs.SetInt("Score", moneyAmount);
		hippoPrice.text = "Sold!";
		hippobuyButton.gameObject.SetActive(false);
		PlayerPrefs.SetInt("Animal", 3);
	}

	public void buymonkey()
	{
		moneyAmount -= 5;
		PlayerPrefs.SetInt("ismonkeySold", 1);
		PlayerPrefs.SetInt("Score", moneyAmount);
		monkeyPrice.text = "Sold!";
		monkeybuyButton.gameObject.SetActive(false);
		PlayerPrefs.SetInt("Animal", 4);
	}

	public void buypanda()
	{
		moneyAmount -= 5;
		PlayerPrefs.SetInt("ispandaSold", 1);
		PlayerPrefs.SetInt("Score", moneyAmount);
		pandaPrice.text = "Sold!";
		pandabuyButton.gameObject.SetActive(false);
		PlayerPrefs.SetInt("Animal", 5);
	}

	public void buypenguin()
	{
		moneyAmount -= 5;
		PlayerPrefs.SetInt("ispenguinSold", 1);
		PlayerPrefs.SetInt("Score", moneyAmount);
		penguinPrice.text = "Sold!";
		penguinbuyButton.gameObject.SetActive(false);
		PlayerPrefs.SetInt("Animal", 6);
	}

	public void buypig()
	{
		moneyAmount -= 5;
		PlayerPrefs.SetInt("ispigSold", 1);
		PlayerPrefs.SetInt("Score", moneyAmount);
		pigPrice.text = "Sold!";
		pigbuyButton.gameObject.SetActive(false);
		PlayerPrefs.SetInt("Animal", 7);
	}

	public void buyrabbit()
	{
		moneyAmount -= 5;
		PlayerPrefs.SetInt("israbbitSold", 1);
		PlayerPrefs.SetInt("Score", moneyAmount);
		rabbitPrice.text = "Sold!";
		rabbitbuyButton.gameObject.SetActive(false);
		PlayerPrefs.SetInt("Animal", 8);
	}

	public void exitShop()
	{
		//PlayerPrefs.SetInt ("MoneyAmount", moneyAmount);
		SceneManager.LoadScene ("Menu");
	}

	public void resetPlayerPrefs()
	{
		moneyAmount = 0;
		buyButton.gameObject.SetActive (true);
		riflePrice.text = "Price: 5$";
		PlayerPrefs.DeleteAll ();
	}

}
