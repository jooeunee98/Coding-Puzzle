using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSet : MonoBehaviour
{
    static public string[][] stage = new string[][]     //1은 땅 2는 물 3은 없어 
            {

        new string[]
        {
            "   33333   ",
            "   11111   ",
            "   11111   ",
            "   33333   ",
            "   33333   "
        },

            new string[]
        {
            "   33333   ",
            "   11111   ",
            "   11111   ",
            "   12221   ",
            "   33333   "

        },

            new string[]
        {
            "   33333   ",
            "   11133   ",
            "   11133   ",
            "   21133   ",
            "   11133   "

        },

           new string[]
        {
            "   33333   ",
            "   11111   ",
            "   11111   ",
            "   11111   ",
            "   12222   "

        },

            new string[]
        {
            "   11111   ",
            "   11111   ",
            "   11111   ",
            "   22211   ",
            "   11111   "

        },

          new string[]
        {
            "   33333   ",
            "   11111   ",
            "   11111   ",
            "   33333   ",
            "   33333   "

        },
          new string[]
        {
            "   11111   ",
            "   22221   ",
            "   22221   ",
            "   22221   ",
            "   11111   "

        },
          new string[]
        {
            "   11121   ",
            "   11211   ",
            "   12112   ",
            "   21121   ",
            "   11211   "

        },

      };
}
