using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{

    public int followerCount;
    public int paraCount;

    public Text paraCountText;
    public Text followCountText;

    public int randParaInt;
    public int randFollowInt;

    // Start is called before the first frame update
    void Start()
    {
        //Initialize count to zero.
        paraCount = 1;
        followerCount = 30;

        //Initialze winText to a blank string since we haven't won yet at beginning.
        paraCountText.text = "Paranoia: " + paraCount;
        followCountText.text = "Followers: " + followerCount;

        //Call our SetCountText function which will update the text with the current value for count.
        //SetCountText();
    }

    public void onClickPara() {
        randParaInt = Random.Range(1, 50);
        paraCount = paraCount + randParaInt;
        Debug.Log("clicked" + paraCount);
        paraCountText.text = "Paranoia: " + paraCount.ToString();
        //Update the currently displayed count by calling the SetCountText function.
    }

    public void onClickFollow() {
        randFollowInt = Random.Range(1, 10);
        followerCount = followerCount + randFollowInt;
        Debug.Log("clicked" + paraCount);
        followCountText.text = "Followers: " + followerCount.ToString();
    }

    ////This function updates the text displaying the number of objects we've collected and displays our victory message if we've collected all of them.
    //void SetCountText()
    //{
    //    //Set the text property of our our countText object to "Count: " followed by the number stored in our count variable.
    //    paraCountText.text = "Paranoia: " + paraCount.ToString();
    //    followCountText.text = "Followers:  " + followerCount.ToString();

    //    ////Check if we've collected all 12 pickups. If we have...
    //    //if (count >= 12)
    //    //    //... then set the text property of our winText object to "You win!"
    //    //    winText.text = "You win!";
    //}

    void update()
    {

    }






}
