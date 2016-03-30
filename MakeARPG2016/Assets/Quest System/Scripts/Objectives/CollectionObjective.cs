using UnityEngine;
using System.Collections;
using System;

namespace QuestSystem
{
    public class CollectionObjective : IQuestObjective
    {
        private string title;
        private string description;
        private bool isComplete;
        private bool isBonus;
        private string verb;
        private int collectionAmount;   //total amount of whatever we need
        private int currentAmount; //starts at 0
        private GameObject itemToCollect;

        //collect 10 meat
        /// <summary>
        /// This constructor builds a collection objective.
        /// </summary>
        /// <param name="titleVerb">Describes the type of collection.</param>
        /// <param name="totalAmount">Amount required to complete objective.</param>
        /// <param name="item">Item to be collected.</param>
        /// <param name="descrip">Describe what will be collected.</param>
        /// <param name="bonus">Is this a bonus objective?</param>
        public CollectionObjective(string titleVerb, int totalAmount, GameObject item, string descrip, bool bonus)
        {
            title = titleVerb + " " + totalAmount + " " + item.name;
            verb = titleVerb;
            description = descrip;
            itemToCollect = item;
            collectionAmount = totalAmount;
            currentAmount = 0;
            isBonus = bonus;
            CheckProgress();
        }

        public string Title
        {
            get
            {
                return title;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
        }

        public int CollectionAmount
        {
            get
            {
                return collectionAmount;
            }
        }

        public int CurrentAmount
        {
            get
            {
                return currentAmount;
            }
        }

        public GameObject ItemToCollect
        {
            get
            {
                return itemToCollect;
            }
        }

        public bool IsComplete
        {
            get
            {
                return isComplete;
            }
        }

        public bool IsBonus
        {
            get
            {
                return isBonus;
            }
        }

        public void UpdateProgress()
        {
            throw new NotImplementedException();
        }

        public void CheckProgress()
        {
            if (currentAmount >= collectionAmount)
                isComplete = true;
            else
                isComplete = false;
        }

        // 0/10 meat gathered
        public override string ToString()
        {
            return currentAmount + "/" + collectionAmount + " " + itemToCollect.name + " " + verb + "ed!";
        }

    }
}


//location is a specific point in the world
