using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCharacterScript : MonoBehaviour {

	// referenses to controlled game objects
	public GameObject Parot, Elephant, giraffe, hippo, monkey, panda, penguin, pig, rabbit;
	private int whichAvatarIsOn;

	// variable contains which avatar is on and active
	//int whichAvatarIsOn = 1;

	// Use this for initialization
	void Start () {

		// anable first avatar and disable another one
		//Parot.gameObject.SetActive (true);
		//Elephant.gameObject.SetActive (false);
		whichAvatarIsOn = PlayerPrefs.GetInt("Animal");
		SwitchAvatar();

	}

	// public method to switch avatars by pressing UI button
	public void SwitchAvatar()
	{
		whichAvatarIsOn = PlayerPrefs.GetInt("Animal");
		// processing whichAvatarIsOn variable
		switch (whichAvatarIsOn) {

		// if the first avatar is on
		case 1:

			// then the second avatar is on now
			whichAvatarIsOn = 2;

			// disable the first one and anable the second one
			Parot.gameObject.SetActive (false);
			Elephant.gameObject.SetActive (true);
			giraffe.gameObject.SetActive(false);
			hippo.gameObject.SetActive(false);
			monkey.gameObject.SetActive(false);
			panda.gameObject.SetActive(false);
			penguin.gameObject.SetActive(false);
			pig.gameObject.SetActive(false);
			rabbit.gameObject.SetActive(false);
				break;

		// if the second avatar is on
		case 0:

			// then the first avatar is on now
			whichAvatarIsOn = 1;

			// disable the second one and anable the first one
			Parot.gameObject.SetActive (true);
			Elephant.gameObject.SetActive (false);
			giraffe.gameObject.SetActive(false);
			hippo.gameObject.SetActive(false);
			monkey.gameObject.SetActive(false);
			panda.gameObject.SetActive(false);
			penguin.gameObject.SetActive(false);
			pig.gameObject.SetActive(false);
			rabbit.gameObject.SetActive(false);
			break;

			case 2:
				//giraffe
				// then the first avatar is on now
				whichAvatarIsOn = 1;

				// disable the second one and anable the first one
				Parot.gameObject.SetActive(false);
				Elephant.gameObject.SetActive(false);
				giraffe.gameObject.SetActive(true);
				hippo.gameObject.SetActive(false);
				monkey.gameObject.SetActive(false);
				panda.gameObject.SetActive(false);
				penguin.gameObject.SetActive(false);
				pig.gameObject.SetActive(false);
				rabbit.gameObject.SetActive(false);
				break;

			case 3:
				//hippo
				// then the first avatar is on now
				whichAvatarIsOn = 1;

				// disable the second one and anable the first one
				Parot.gameObject.SetActive(false);
				Elephant.gameObject.SetActive(false);
				giraffe.gameObject.SetActive(false);
				hippo.gameObject.SetActive(true);
				monkey.gameObject.SetActive(false);
				panda.gameObject.SetActive(false);
				penguin.gameObject.SetActive(false);
				pig.gameObject.SetActive(false);
				rabbit.gameObject.SetActive(false);
				break;

			case 4:
				//monkey
				// then the first avatar is on now
				whichAvatarIsOn = 1;

				// disable the second one and anable the first one
				Parot.gameObject.SetActive(false);
				Elephant.gameObject.SetActive(false);
				giraffe.gameObject.SetActive(false);
				hippo.gameObject.SetActive(false);
				monkey.gameObject.SetActive(true);
				panda.gameObject.SetActive(false);
				penguin.gameObject.SetActive(false);
				pig.gameObject.SetActive(false);
				rabbit.gameObject.SetActive(false);
				break;

			case 5:
				//panda
				// then the first avatar is on now
				whichAvatarIsOn = 1;

				// disable the second one and anable the first one
				Parot.gameObject.SetActive(false);
				Elephant.gameObject.SetActive(false);
				giraffe.gameObject.SetActive(false);
				hippo.gameObject.SetActive(false);
				monkey.gameObject.SetActive(false);
				panda.gameObject.SetActive(true);
				penguin.gameObject.SetActive(false);
				pig.gameObject.SetActive(false);
				rabbit.gameObject.SetActive(false);
				break;

			case 6:
				//penguin
				// then the first avatar is on now
				whichAvatarIsOn = 1;

				// disable the second one and anable the first one
				Parot.gameObject.SetActive(false);
				Elephant.gameObject.SetActive(false);
				giraffe.gameObject.SetActive(false);
				hippo.gameObject.SetActive(false);
				monkey.gameObject.SetActive(false);
				panda.gameObject.SetActive(false);
				penguin.gameObject.SetActive(true);
				pig.gameObject.SetActive(false);
				rabbit.gameObject.SetActive(false);
				break;

			case 7:
				//pig
				// then the first avatar is on now
				whichAvatarIsOn = 1;

				// disable the second one and anable the first one
				Parot.gameObject.SetActive(false);
				Elephant.gameObject.SetActive(false);
				giraffe.gameObject.SetActive(false);
				hippo.gameObject.SetActive(false);
				monkey.gameObject.SetActive(false);
				panda.gameObject.SetActive(false);
				penguin.gameObject.SetActive(false);
				pig.gameObject.SetActive(true);
				rabbit.gameObject.SetActive(false);
				break;

			case 8:
				//rabbit
				// then the first avatar is on now
				whichAvatarIsOn = 1;

				// disable the second one and anable the first one
				Parot.gameObject.SetActive(false);
				Elephant.gameObject.SetActive(false);
				giraffe.gameObject.SetActive(false);
				hippo.gameObject.SetActive(false);
				monkey.gameObject.SetActive(false);
				panda.gameObject.SetActive(false);
				penguin.gameObject.SetActive(false);
				pig.gameObject.SetActive(false);
				rabbit.gameObject.SetActive(true);
				break;

		}
			
	}
}
